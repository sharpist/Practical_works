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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Collector
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form() {
            InitializeComponent();
            allLinks = new List<string>();
            patterns = new string[4]
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

        // ссылки анкет на страницах каталога
        private List<string> allLinks;
        // шаблоны
        private string[] patterns;
        // ограничитель страниц
        private readonly ushort pagesLimit = 1;

        private void goWalker_button_Click(object sender, EventArgs e)
        {
            for (ushort i = 1; i <= pagesLimit; i++)
            {
                // получить данные страницы
                parsHtml(getHtmlPage(@"https://job.ru/catalog/production/page/" + i.ToString()));
            }
            // получить данные анкеты
            parsHtml(allLinks);
        }
    }
}
