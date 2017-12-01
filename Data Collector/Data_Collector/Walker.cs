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
    public partial class Form
    {
        // получить данные страницы/анкеты
        private string getHtml(string url)
        {
            string HtmlText = string.Empty;
            HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
            StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
            HtmlText = strm.ReadToEnd();
            return HtmlText;
        }


        // парсит по заданному шаблону страницу
        private void parsHtmlPage(List<string> pages)
        {
            for (ushort i = 0; i < pages.Count; i++)
            {
                // найденные соответствия
                MatchCollection matches = Regex.Matches(pages[i], patterns[0], RegexOptions.IgnoreCase);

                if (matches.Count == 0) // проверяем найден ли
                { MessageBox.Show("не найден"); }

                else // если найдено, перебираем масив matches
                {
                    for (ushort j = 0; j < matches.Count; j++) // выводим ссылки в коллекцию
                    { this.links.Add(@"https://www.job.ru" + (matches[j]).Groups[1].Value); }
                }
            }
        }


        // парсит по заданному шаблону анкету
        private void parsHtmlLink(List<string> links)
        {
            for (ushort i = 0; i < links.Count; i++)
            {
                for (ushort j = 1; j <= 3; j++) // перебираем регулярные выражения
                {
                    // найденные соответствия
                    MatchCollection matches = Regex.Matches(getHtml(links[i]), patterns[j], RegexOptions.IgnoreCase);
                    if (matches.Count != 0)
                    {
                        textBox.Text += ((matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value) + Environment.NewLine;
                    }
                }
                textBox.Text += Environment.NewLine;
            }
        }
    }
}
