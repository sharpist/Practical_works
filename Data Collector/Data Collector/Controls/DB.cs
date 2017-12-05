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
            string dirName = System.IO.Directory.GetCurrentDirectory(), myDB = dirName + @"\DB.mdf";
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + myDB;

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
                    textBox.Text += Convert.ToString(sqlReader["Id"])          + "  " +
                                    Convert.ToString(sqlReader["Company"])     + "  " +
                                    Convert.ToString(sqlReader["Profession"])  + "  " +
                                    Convert.ToString(sqlReader["Salary"])      + "  " +
                                    Convert.ToString(sqlReader["Description"]) + "  " +
                                    Convert.ToString(sqlReader["Demand"])      + Environment.NewLine;
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { if (sqlReader != null) sqlReader.Close(); }


            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Profile". При необходимости она может быть перемещена или удалена.
            this.profileTableAdapter.Fill(this.dBDataSet.Profile);
        }
        private async void insertDB_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCompany.Text)     && !string.IsNullOrWhiteSpace(textBoxCompany.Text)     &&
                !string.IsNullOrEmpty(textBoxProfession.Text)  && !string.IsNullOrWhiteSpace(textBoxProfession.Text)  &&
                !string.IsNullOrEmpty(textBoxSalary.Text)      && !string.IsNullOrWhiteSpace(textBoxSalary.Text)      &&
                !string.IsNullOrEmpty(textBoxDescription.Text) && !string.IsNullOrWhiteSpace(textBoxDescription.Text) &&
                !string.IsNullOrEmpty(textBoxDemand.Text)      && !string.IsNullOrWhiteSpace(textBoxDemand.Text))
            {
                //                                                                       наименование колонок                                           ключи
                SqlCommand command = new SqlCommand("INSERT INTO [Profile] (Company, Profession, Salary, Description, Demand)VALUES(@Company, @Profession, @Salary, @Description, @Demand)", sqlConnection);
                //                                ключ            значение
                command.Parameters.AddWithValue("Company",     textBoxCompany.Text);
                command.Parameters.AddWithValue("Profession",  textBoxProfession.Text);
                command.Parameters.AddWithValue("Salary",      textBoxSalary.Text);
                command.Parameters.AddWithValue("Description", textBoxDescription.Text);
                command.Parameters.AddWithValue("Demand",      textBoxDemand.Text);

                // выполнить команды INSERT
                await command.ExecuteNonQueryAsync();
            }
            else { textBox.Text = "Коллекция profiles не содержит данные!"; }
        }
        private void profileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);
        }
    }
}
