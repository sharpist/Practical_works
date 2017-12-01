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
        private string getHtmlPage(string url)
        {
            string HtmlText = string.Empty;
            HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
            StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
            HtmlText = strm.ReadToEnd();
            return HtmlText;
        }


        // парсит по заданному шаблону страницу
        private void parsHtml(string HtmlText)
        {
            // найденные соответствия
            MatchCollection matches = Regex.Matches(HtmlText, patterns[0], RegexOptions.IgnoreCase);

            if (matches.Count == 0) // проверяем найден ли
            { MessageBox.Show("не найден"); }

            else // если найдено, перебираем масив matches
            {
                for (ushort i = 0; i < matches.Count; i++) // выводим ссылки в коллекцию
                { this.allLinks.Add(@"https://www.job.ru" + (matches[i]).Groups[1].Value); }
            }
        }


        // парсит по заданному шаблону анкету
        private void parsHtml(List<string> allLinks)
        {
            for (ushort i = 0; i < allLinks.Count; i++) // получаем ссылку на анкету
            {
                string HtmlText = getHtmlPage(allLinks[i]);

                for (ushort j = 1; j <= 3; j++) // перебираем регулярные выражения
                {
                    // найденные соответствия
                    MatchCollection matches = Regex.Matches(HtmlText, patterns[j], RegexOptions.IgnoreCase);
                    if (matches.Count != 0)
                    {
                        Match match = matches[0];
                        textBox.Text += (match.Groups[1].Value + match.Groups[2].Value) + Environment.NewLine;
                    }
                }
                textBox.Text += Environment.NewLine; // доп.пустая строка
            }
        }
    }
}
