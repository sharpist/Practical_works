using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Data_Collector
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form() {
            InitializeComponent();

            // откл. столбец Id
            profileDataGridView.Columns[0].Visible = false;

            this.htmlText = new ConcurrentBag<String>();
            this.links    = new ConcurrentBag<String>();
            this.profiles = new ConcurrentBag<Profile>();

            this.patterns = new string[6]
            {
                // анкета
                @"href=\D(\/[-a-z]{2,}\w+\/+[0-9]{5,7})\/\D\s",
                // компания
                @"<span class=\Dcompany-name\D>([0-9A-Za-zА-Яа-я\s-_\+.,:;()<>«»!▪@#\']+)<\/span>",
                // профессия
                @"<h1 data-id=\D[0-9]{7}\D>([А-Яа-я\s-0-9]{2,64})",
                // заработная плата
                @"=\Dsalary not-setted\D>([а-я\s\/]{14})|=\Dsalary\D>[отд\s]+<b>([0-9]+)&nbsp;([0-9]+)",
                // описание
                @"<h3>Описание вакансии<\/h3>\s+<div class=\Dtext\D>\s+<?\D?\D?\D?>?\s+<?\D?\D?\D?>?\s+<?\D?\D?\D?>?\s+([0-9A-Za-zА-Яа-я\s-_\+.,:;()<>«»!▪@#\']+)\n",
                // требования
                @"<h3>Требования<\/h3>\s+<div class=\Dtext\D>\s+<?\D?\D?\D?>?\s+<?\D?\D?\D?>?\s+<?\D?\D?\D?>?\s+([0-9A-Za-zА-Яа-я\s-_\+.,:;()<>«»!▪@#\']+)\n"
            };
        }
        
        private string[] patterns;                     // шаблоны
        private ConcurrentBag<String> htmlText, links; // html-текст / ссылки анкет
        private ConcurrentBag<Profile> profiles;       // найденная информация в анкетах


        private async void goWalker_button_Click(object sender, EventArgs e)
        {
            // ограничитель страниц
            var limit = (ushort)trackBar.Value;
            setGUI(0); // GUI disabled

            try
            {
                await getHtmlAsync(0, limit, @"https://job.ru/catalog/production/page/"); // получить HTML страниц

                await parsHtmlPageAsync(htmlText.Count);                                  // получить ссылки анкет

                await getHtmlAsync(1, (ushort)links.Count);                               // получить HTML профилей
                this.links = new ConcurrentBag<String>();

                await parsHtmlProfileAsync(htmlText.Count);                               // получить данные анкет


                textBox.Text = "";
                foreach (var profile in profiles)
                {
                    textBox.Text += $"Компания: {profile.Company}" + "\t" + $"Профессия: {profile.Profession}" + Environment.NewLine;
                    textBox.Text += $"Зарплата: {profile.Salary}" + Environment.NewLine;
                    textBox.Text += profile.Description           + Environment.NewLine;
                    textBox.Text += profile.Demand                + Environment.NewLine;
                    textBox.Text +=                                 Environment.NewLine;
                }
            }

            catch (Exception ex)
            { textBox.Text = ex.Message; }
            finally { setGUI(1); } // GUI enabled
        }


        #region группа асинхронных методов
        private async Task getHtmlAsync(byte key, ushort limit, string url = null)
        {
            Task task = Task.Run(() => getHtml(key, limit, url));
            await task;
        }
        private async Task parsHtmlPageAsync(int range)
        {
            Task task1 = Task.Run(() => parsHtmlPage(0, range / 2));
            Task task2 = Task.Run(() => parsHtmlPage(range / 2, range));
            await task1; await task2;

            this.htmlText = new ConcurrentBag<String>();
        }
        private async Task parsHtmlProfileAsync(int range)
        {
            Task task1 = Task.Run(() => parsHtmlProfile(0, range / 2));
            Task task2 = Task.Run(() => parsHtmlProfile(range / 2, range));
            await task1; await task2;

            this.htmlText = new ConcurrentBag<String>();
        }
        #endregion
    }
}
