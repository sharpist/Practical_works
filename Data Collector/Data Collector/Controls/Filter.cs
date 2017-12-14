using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Data_Collector
{
    public partial class Form
    {
        private void useFilter_button_Click(object sender, EventArgs e)
        {
            if (profiles.Count != 0)
            {
                // отбросить некорректные данные
                IEnumerable<Profile> selection = from Profile profile in profiles.ToList()
                                                 where profile.Salary != "з/п не указана"
                                                 select profile;
                // найти среднее значение
                double average = selection.Average(profile => int.Parse(profile.Salary));

                // определить границы
                double max = average * 1.1;
                double min = average * 0.9;


                // заполнить profiles
                this.profiles = new ConcurrentBag<Profile>();
                foreach (var profile in selection)
                {
                    if (double.Parse(profile.Salary) <= max &&
                        double.Parse(profile.Salary) >= min)
                        profiles.Add(profile);
                }

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

            else { textBox.Text = "Данные для фильтра не собраны!"; }
        }
    }
}
