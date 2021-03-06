﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Collector
{
    public partial class Form
    {
        private SqlConnection sqlConnection; // соединение с DB
        private string connectionString;     // строка подключения


        // загрузка формы/подключение к DB
        private async void Form_Load(object sender, EventArgs e)
        {
            // подготовить адрес
            //string dirName = System.IO.Directory.GetCurrentDirectory(), myDB = dirName + @"\DB.mdf";
            //connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + myDB;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf";

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
                    textBox.Text += $"Компания: {sqlReader["Company"].ToString()}" + "\t" + $"Профессия: {sqlReader["Profession"].ToString()}" + Environment.NewLine;
                    textBox.Text += $"Зарплата: {sqlReader["Salary"].ToString()}" + Environment.NewLine;
                    textBox.Text += sqlReader["Description"].ToString()           + Environment.NewLine;
                    textBox.Text += sqlReader["Demand"].ToString()                + Environment.NewLine;
                    textBox.Text +=                                                 Environment.NewLine;
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { if (sqlReader != null) sqlReader.Close(); }


            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Profile". При необходимости она может быть перемещена или удалена.
            this.profileTableAdapter.Fill(this.dBDataSet.Profile);
        }


        // вставить/сохранить строку
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

                this.profileTableAdapter.Fill(this.dBDataSet.Profile);
            }
            else { textBox.Text = "Заполните все поля!"; }
        }


        // записывать в DB
        private void recordDB_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (profiles.Count != 0 && !profiles.IsEmpty)
                {
                    foreach (var profile in profiles)
                    {
                        this.profileTableAdapter.Insert(profile.Company,
                                                        profile.Profession,
                                                        profile.Salary,
                                                        profile.Description,
                                                        profile.Demand);

                        this.profileTableAdapter.Fill(this.dBDataSet.Profile);
                    }
                }
                else { textBox.Text = "Отсутствуют захваченные данные к записи!"; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        // удалить выбранную строку
        private void delDB_button_Click(object sender, EventArgs e)
        {
            try
            {
                int row = profileDataGridView.CurrentRow.Index;
                int Id = Convert.ToInt32(profileDataGridView.Rows[row].Cells[0].Value);
                //profileDataGridView.Rows.RemoveAt(profileDataGridView.CurrentCell.RowIndex);

                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = $"DELETE FROM [Profile] WHERE Id = '{Id}'";
                command.ExecuteNonQuery();
                this.profileTableAdapter.Fill(this.dBDataSet.Profile);
            }
            catch (Exception ex)
            { textBox.Text = ex.Message; }
        }


        // выборка по значению
        private void finderDB_button_Click(object sender, EventArgs e)
        {
            textBox.Text = "";

            if (!string.IsNullOrEmpty(textBoxSalary.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSalary.Text))
            {
                SqlDataReader sqlReader = null;
                try
                {
                    foreach (char c in textBoxSalary.Text)
                    { if (!Char.IsNumber(c)) throw new Exception("Неверные данные!"); }

                    SqlCommand command= sqlConnection.CreateCommand();
                    command.CommandText = $"SELECT Company, Profession FROM [Profile] WHERE Salary = '{textBoxSalary.Text}'";
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        textBox.Text += $"Компания: {sqlReader["Company"].ToString()}" + "\t" + $"Профессия: {sqlReader["Profession"].ToString()}" + Environment.NewLine;
                        textBox.Text += Environment.NewLine;
                    }
                }
                catch (Exception ex) { textBox.Text = ex.Message; }
                finally { sqlReader.Close(); }
            }
            else { textBox.Text = "Неверные данные!"; }
        }



        private void profileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);
        }
    }
}
