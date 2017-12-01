using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Collector
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form() {
            InitializeComponent();

            this.pages = new List<string>();
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

        private string[] patterns;         // шаблоны
        private List<string> pages, links; // страницы / ссылки анкет
        private List<Profile> profiles;    // найденная информация в анкетах
        private readonly ushort limit = 1; // ограничитель страниц


        private async void goWalker_button_Click(object sender, EventArgs e)
        {
            try
            {
                // получить HTML страницы
                for (ushort i = 1; i <= limit; i++)
                {
                    pages.Add(await getHtmlAsync(@"https://job.ru/catalog/production/page/" + i.ToString()));
                }

                await parsHtmlPageAsync(this.pages); // получить ссылки анкет
                //await parsHtmlLinkAsync(this.links); // получить данные анкет
                parsHtmlLink(this.links);
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
        private async Task parsHtmlPageAsync(List<string> pages)
        {
            Task task = Task.Run(() => parsHtmlPage(this.pages));
            await task;
        }
        //private async Task parsHtmlLinkAsync(List<string> links)
        //{
        //    Task task = Task.Run(() => parsHtmlLink(this.links));
        //    await task;
        //}
    }
}
