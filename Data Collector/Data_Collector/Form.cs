using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data_Collector
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form() {
            InitializeComponent();

            this.htmlText = new List<string>();
            this.links = new List<string>();

            this.patterns = new string[4]
            {
                // анкета
                @"href=\D(\/[-a-z]{2,}\w+\/+[0-9]{5,7})\/\D\s",
                // профессия
                @"<h1 data-id=\D[0-9]{7}\D>([А-Яа-я\s-0-9]{2,64})",
                // заработная плата
                @"=\Dsalary not-setted\D>([а-я\s\/]{14})",
                @"=\Dsalary\D>[отд\s]+<b>([0-9]+)&nbsp;([0-9]+)",
                //@"..."
            };
        }

        private string[] patterns;            // шаблоны
        private List<string> htmlText, links; // html-текст / ссылки анкет
        private List<Profile> profiles;       // найденная информация в анкетах
        private readonly ushort limit = 1;    // ограничитель страниц


        private async void goWalker_button_Click(object sender, EventArgs e)
        {
            try
            {
                // получить HTML страниц
                for (ushort i = 1; i <= limit; i++)
                {
                    htmlText.Add(await getHtmlAsync(@"https://job.ru/catalog/production/page/" + i.ToString()));
                }

                await parsHtmlPageAsync(); // получить ссылки анкет

                // получить HTML профилей
                for (ushort i = 0; i < links.Count; i++)
                {
                    htmlText.Add(await getHtmlAsync(links[i]));
                }
                links.Clear();

                //await parsHtmlProfileAsync(); // получить данные анкет
                parsHtmlProfile();
            }

            catch (Exception ex)
            { textBox.Text = ex.Message; }
        }


        private async Task<string> getHtmlAsync(string param)
        {
            Task<string> task = Task.Run(() => getHtml(param));
            await task;
            return task.Result;
        }
        private async Task parsHtmlPageAsync()
        {
            Task task = Task.Run(() => parsHtmlPage());
            await task;
        }
        private async Task parsHtmlProfileAsync()
        {
            Task task = Task.Run(() => parsHtmlProfile());
            await task;
        }
    }
}
