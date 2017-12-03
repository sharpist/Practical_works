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
            this.filteredProfiles = new List<Profile>();
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

        private string[] patterns;                        // шаблоны
        private List<string> htmlText, links;             // html-текст / ссылки анкет
        private List<Profile> profiles, filteredProfiles; // найденная информация в анкетах
        private byte limit;                               // ограничитель страниц


        private async void goWalker_button_Click(object sender, EventArgs e)
        {
            try
            {
                limit = (byte)trackBar.Value;
                setGUI(0);


                await getHtmlAsync(0, limit, @"https://job.ru/catalog/production/page/"); // получить HTML страниц

                await parsHtmlPageAsync();                                                // получить ссылки анкет

                await getHtmlAsync(1, (ushort)links.Count);                               // получить HTML профилей
                links.Clear();

                await parsHtmlProfileAsync();                                             // получить данные анкет


                setGUI(1);
                for (ushort i = 0; i < profiles.Count; i++)
                {
                    textBox.Text += profiles[i].Profession + Environment.NewLine;
                    textBox.Text += profiles[i].Salary     + Environment.NewLine;
                    textBox.Text +=                          Environment.NewLine;
                }
            }

            catch (Exception ex)
            { textBox.Text = ex.Message; }
        }


        #region группа асинхронных методов
        private async Task getHtmlAsync(byte key, ushort limit, string url = null)
        {
            Task task = Task.Run(() => getHtml(key, limit, url));
            await task;
        }
        private async Task parsHtmlPageAsync()
        {
            Task task1 = Task.Run(() => parsHtmlPage(0, htmlText.Count / 2));
            Task task2 = Task.Run(() => parsHtmlPage(htmlText.Count / 2, htmlText.Count));
            await task1; await task2;
            htmlText.Clear();
        }
        private async Task parsHtmlProfileAsync()
        {
            Task task1 = Task.Run(() => parsHtmlProfile(0, htmlText.Count / 2));
            Task task2 = Task.Run(() => parsHtmlProfile(htmlText.Count / 2, htmlText.Count));
            await task1; await task2;
            htmlText.Clear();
        }
        #endregion
    }
}
