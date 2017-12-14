using System;
using System.IO;
using System.Linq;
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

                    case 1: address = links.ElementAt(i - 1);
                    break;
                }

                StreamReader strm = null;
                try
                {
                    HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(address);
                    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                    strm = new StreamReader(myHttpWebResponse.GetResponseStream());
                    htmlText.Add(strm.ReadToEnd());
                }
                catch (Exception ex) { textBox.Text = ex.Message; }
                finally { if (strm != null) strm.Close(); }
            }
        }


        // парсит по заданному шаблону страницу
        private void parsHtmlPage(int start, int stop)
        {
            for (; start < stop; start++)
            {
                // найденные соответствия
                MatchCollection matches = Regex.Matches(htmlText.ElementAt(start), patterns[0], RegexOptions.IgnoreCase);

                if (matches.Count == 0) // проверяем найден ли
                { MessageBox.Show("не найден"); }

                else // если найдено, перебираем массив matches
                {
                    for (ushort i = 0; i < matches.Count; i++) // выводим ссылки в коллекцию
                    { links.Add(@"https://www.job.ru" + (matches[i]).Groups[1].Value); }
                }
            }
        }


        // парсит по заданному шаблону анкету
        private void parsHtmlProfile(int start, int stop)
        {
            for (; start < stop; start++)
            {
                Profile profile = default(Profile);   // новый профиль

                for (ushort key = 1; key <= 5; key++) // перебираем регулярные выражения
                {
                    // найденные соответствия
                    MatchCollection matches = Regex.Matches(htmlText.ElementAt(start), patterns[key], RegexOptions.IgnoreCase);
                    if (matches.Count != 0)
                    {
                        switch (key) {
                            case 1: profile.Company = (matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value + (matches[0]).Groups[3].Value;
                            break;

                            case 2: profile.Profession = (matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value + (matches[0]).Groups[3].Value;
                            break;

                            case 3: profile.Salary = (matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value + (matches[0]).Groups[3].Value;
                            break;

                            case 4: profile.Description = (matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value + (matches[0]).Groups[3].Value;
                            break;

                            case 5: profile.Demand = (matches[0]).Groups[1].Value + (matches[0]).Groups[2].Value + (matches[0]).Groups[3].Value;
                            break;
                        }
                    }
                }
                profiles.Add(profile);
            }
        }
    }
}
