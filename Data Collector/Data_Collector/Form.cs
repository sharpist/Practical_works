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
            this.profiles = new List<Profile>();
            this.patterns = new string[3]
            {
                // анкета
                @"href=\D(\/[-a-z]{2,}\w+\/+[0-9]{5,7})\/\D\s",
                // профессия
                @"<h1 data-id=\D[0-9]{7}\D>([А-Яа-я\s-0-9]{2,64})",
                // заработная плата
                @"=\Dsalary not-setted\D>([а-я\s\/]{14})|=\Dsalary\D>[отд\s]+<b>([0-9]+)&nbsp;([0-9]+)",
                // описание
                //"<h3>Описание вакансии<\\/h3>\\s+<div class=\\Dtext\\D>\\s+([0-9A-Za-zА-Яа-я\\s\\-\\.,:;\"()<>«»]+)\\.",
                // требования
                //"<h3>Требования<\\/h3>\\s+<div class=\\Dtext\\D>\\s+<ul>\\s+<\\/ul>\\s+<br>\\s+([0-9A-Za-zА-Яа-я\\s\\-\\.,:;\"()<>«»]+)\\."
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
                await getHtmlAsync(0, limit, @"https://job.ru/catalog/production/page/");
                // получить ссылки анкет
                await parsHtmlPageAsync();
                // получить HTML профилей
                await getHtmlAsync(1, (ushort)links.Count);
                links.Clear();
                // получить данные анкет
                //await parsHtmlProfileAsync();
                parsHtmlProfile();
            }

            catch (Exception ex)
            { textBox.Text = ex.Message; }
        }


        private async Task getHtmlAsync(byte key, ushort limit, string url = null)
        {
            Task task = Task.Run(() => getHtml(key, limit, url));
            await task;
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
