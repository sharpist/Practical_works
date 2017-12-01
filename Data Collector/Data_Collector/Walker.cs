using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Data_Collector
{
    public partial class Form
    {
        // получить данные страницы/анкеты
        private string getHtml(string url)
        {
            HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
            StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
            return strm.ReadToEnd();
        }


        // парсит по заданному шаблону страницу
        private void parsHtmlPage()
        {
            for (ushort i = 0; i < htmlText.Count; i++)
            {
                // найденные соответствия
                MatchCollection matches = Regex.Matches(htmlText[i], patterns[0], RegexOptions.IgnoreCase);

                if (matches.Count == 0) // проверяем найден ли
                { MessageBox.Show("не найден"); }

                else // если найдено, перебираем масив matches
                {
                    for (ushort j = 0; j < matches.Count; j++) // выводим ссылки в коллекцию
                    { links.Add(@"https://www.job.ru" + (matches[j]).Groups[1].Value); }
                }
            }
            htmlText.Clear();
        }


        // парсит по заданному шаблону анкету
        private void parsHtmlProfile()
        {
            for (ushort i = 0; i < htmlText.Count; i++)
            {
                for (ushort j = 1; j <= 3; j++) // перебираем регулярные выражения
                {
                    // найденные соответствия
                    MatchCollection matches = Regex.Matches(htmlText[i], patterns[j], RegexOptions.IgnoreCase);
                    if (matches.Count != 0)
                    {
                        textBox.Text += ((matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value) + Environment.NewLine;
                    }
                }
                textBox.Text += Environment.NewLine;
            }
            htmlText.Clear();
        }
    }
}
