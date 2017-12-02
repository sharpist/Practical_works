using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Collector
{
    public partial class Form
    {
        private void useFilter_button_Click(object sender, EventArgs e)
        {
            if (profiles.Count != 0)
            {
                IEnumerable<Profile> result = from Profile profile in profiles
                                              where profile.Salary != "з/п не указана"
                                              select profile;

                // ToDO
            }

            else { textBox.Text = "Данные для фильтра не собраны!"; }
        }
    }
}
