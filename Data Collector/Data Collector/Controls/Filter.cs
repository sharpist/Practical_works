using System;
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
                sign = false;

                // отбросить некорректные данные
                IEnumerable<Profile> selection = from Profile profile in profiles.ToList()
                                                 where profile.Salary != "з/п не указана"
                                                 select profile;
                // найти среднее значение
                double average = selection.Average(profile => int.Parse(profile.Salary));

                // определить границы
                double max = average * 1.1;
                double min = average * 0.9;


                foreach (var profile in selection)
                {
                    if (double.Parse(profile.Salary) <= max &&
                        double.Parse(profile.Salary) >= min)
                        filteredProfiles.Add(profile);
                }
                profiles.Clear();

                textBox.Text = "";
                for (ushort i = 0; i < filteredProfiles.Count; i++)
                {
                    textBox.Text += $"Компания: {filteredProfiles[i].Company}" + "\t" + $"Профессия: {filteredProfiles[i].Profession}" + Environment.NewLine;
                    textBox.Text += $"Зарплата: {filteredProfiles[i].Salary}" + Environment.NewLine;
                    textBox.Text += filteredProfiles[i].Description           + Environment.NewLine;
                    textBox.Text += filteredProfiles[i].Demand                + Environment.NewLine;
                    textBox.Text +=                                             Environment.NewLine;
                }
            }

            else { textBox.Text = "Данные для фильтра не собраны!"; }
        }
    }
}
