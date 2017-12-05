using System;
using System.Data.SqlClient;

namespace Data_Collector
{
    public partial class Form
    {
        private static string connectionString = @"";
        SqlConnection sqlConnection = new SqlConnection(connectionString);


        private async void Form_Load(object sender, EventArgs e)
        {




            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Profile". При необходимости она может быть перемещена или удалена.
            this.profileTableAdapter.Fill(this.dBDataSet.Profile);
        }
        private void writeDB_button_Click(object sender, EventArgs e)
        {
            //TODO: работа с базой
        }
        private void profileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);
        }
    }
}
