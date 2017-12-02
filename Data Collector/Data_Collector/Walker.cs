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
        private void getHtml(byte key, ushort limit, string url)
        {
            string address = string.Empty;
            for (ushort i = 1; i <= limit; i++)
            {
                switch (key) {
                    case 0: address = url + i.ToString();
                    break;
                    case 1: address = links[i-1];
                    break;
                }
                HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(address);
                HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
                StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
                htmlText.Add(strm.ReadToEnd());
                strm.Close();
            }
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

                else // если найдено, перебираем массив matches
                {
                    for (ushort j = 0; j < matches.Count; j++) // выводим ссылки в коллекцию
                    { links.Add(@"https://www.job.ru" + (matches[j]).Groups[1].Value); }
                }
            }
            htmlText.Clear();
        }


        // парсит по заданному шаблону анкету
        private void parsHtmlProfile(int start, int stop)
        {
            for (; start < stop; start++)
            {
                Profile profile = new Profile(); // новый профиль

                for (ushort key = 1; key <= 2; key++)  // перебираем регулярные выражения
                {
                    // найденные соответствия
                    MatchCollection matches = Regex.Matches(htmlText[start], patterns[key], RegexOptions.IgnoreCase);
                    if (matches.Count != 0)
                    {
                        switch (key) {
                            case 1: profile.Profession = (matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value + (matches[0]).Groups[3].Value;
                            break;
                            case 2: profile.Salary = (matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value + (matches[0]).Groups[3].Value;
                            break;
                            case 3: profile.Undefined = null;
                            break;
                        }
                    }
                }
                profiles.Add(profile);
            }
            htmlText.Clear();
        }
    }
}
