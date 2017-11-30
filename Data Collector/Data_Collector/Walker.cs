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
            // шаблон (регулярное выражение)
            string pattern = this.patterns[0];


            // найденные соответствия
            MatchCollection matches = Regex.Matches(HtmlText, pattern, RegexOptions.IgnoreCase);


            if (matches.Count == 0)  // проверяем найден ли
            { MessageBox.Show("не найден"); }

            else // если найдено, перебираем масив matches
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    Match match = matches[i];

                    this.allLinks.Add(@"https://www.job.ru" + match.Groups[1].Value);
                }
            }
        }


        // парсит по заданному шаблону анкету
        private void parsHtml(List<string> allLinks)
        {
            foreach (string link in allLinks) // получаем ссылку на анкету
            {
                string HtmlText = getHtmlPage(link);

                // найденные соответствия
                MatchCollection matches = null;
                for (byte i = 1; i <= 3; i++) // перебираем регулярные выражения
                {
                    matches = Regex.Matches(HtmlText, patterns[i], RegexOptions.IgnoreCase);
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
