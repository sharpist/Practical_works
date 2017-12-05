using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Collector
{
    public partial class Form
    {
        private SqlConnection sqlConnection; // соединение с DB
        private string connectionString;     // строка подключения


        private async void Form_Load(object sender, EventArgs e)
        {
            // подготовить адрес
            string dirName = System.IO.Directory.GetCurrentDirectory(), myDB = dirName + "\\DB.mdf";
            connectionString = "Data Source=" + myDB;

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync(); // открываем соединение с DB

            SqlDataReader sqlReader = null;  // получить таблицу в табличном представлении
            // запрос к DB                         инструкция запрос         соединение
            SqlCommand command = new SqlCommand("SELECT * FROM [Profile]", sqlConnection); // (*) считывать все колонки во всех строках


            try
            {
                // метод ExecuteReader выполняет комманды, возвращающие табличные представления (данные)
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    textBox.Text += Convert.ToString(sqlReader["Id"]) + " " + Convert.ToString(sqlReader["Company"]) + " " + Convert.ToString(sqlReader["Profession"]) + " " + Convert.ToString(sqlReader["Salary"]);
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { if (sqlReader != null) sqlReader.Close(); }


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
