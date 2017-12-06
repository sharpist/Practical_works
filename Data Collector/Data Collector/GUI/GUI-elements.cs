using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Collector
{
    public partial class Form
    {
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value % 2 != 0) trackBar.Value += 1;
        }
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            info.Text = $"Страниц в обработке: {(Math.Round(trackBar.Value / 1.0)).ToString()}";
        }
        private void Form_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
        }
        private async void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            SqlDataReader sqlReader = null;  // получить таблицу в табличном представлении
            // запрос к DB                         инструкция запрос         соединение
            SqlCommand command = new SqlCommand("SELECT * FROM [Profile]", sqlConnection); // (*) считывать все колонки во всех строках


            try
            {
                // метод ExecuteReader выполняет комманды, возвращающие табличные представления (данные)
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    textBox.Text += Convert.ToString(sqlReader["Id"]) + "  " + Convert.ToString(sqlReader["Company"]) + "  " + Convert.ToString(sqlReader["Profession"]) + "  " + Convert.ToString(sqlReader["Salary"]);
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { if (sqlReader != null) sqlReader.Close(); }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Data Collector\" пример программы для сбора данных с веб ресурса.\nBy Alexander Usov", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void setGUI(byte key)
        {
            switch (key) {
                case 0: textBox.Text = $"Получение данных с веб-ресурса...{Environment.NewLine}Процесс работает в фоновом режиме...";
                trackBar.Enabled = false;
                useFilter_button.MouseEnter   -= useFilter_button_MouseEnter; // отписка для 'Фильтр'
                goWalker_button.MouseEnter    -= goWalker_button_MouseEnter;  // отписка для 'Извлечь'
                insertDB_button.MouseEnter    -= insertDB_button_MouseEnter;  // отписка для 'Вставить'
                recordDB_button.MouseEnter    -= recordDB_button_MouseEnter;  // отписка для 'Запись'
                delDB_button.MouseEnter       -= delDB_button_MouseEnter;     // отписка для 'Удалить'
                trackBar.MouseEnter           -= trackBar_MouseEnter;         // отписка для 'trackBar'
                textBoxCompany.MouseEnter     -= textBoxCompany_MouseEnter;
                textBoxProfession.MouseEnter  -= textBoxProfession_MouseEnter;
                textBoxSalary.MouseEnter      -= textBoxSalary_MouseEnter;
                textBoxDescription.MouseEnter -= textBoxDescription_MouseEnter;
                textBoxDemand.MouseEnter      -= textBoxDemand_MouseEnter;
                break;

                case 1: trackBar.Enabled = true;
                useFilter_button.MouseEnter   += useFilter_button_MouseEnter; // подписка для 'Фильтр'
                goWalker_button.MouseEnter    += goWalker_button_MouseEnter;  // подписка для 'Извлечь'
                insertDB_button.MouseEnter    += insertDB_button_MouseEnter;  // подписка для 'Вставить'
                recordDB_button.MouseEnter    += recordDB_button_MouseEnter;  // подписка для 'Запись'
                delDB_button.MouseEnter       += delDB_button_MouseEnter;     // подписка для 'Удалить'
                trackBar.MouseEnter           += trackBar_MouseEnter;         // подписка для 'trackBar'
                textBoxCompany.MouseEnter     += textBoxCompany_MouseEnter;
                textBoxProfession.MouseEnter  += textBoxProfession_MouseEnter;
                textBoxSalary.MouseEnter      += textBoxSalary_MouseEnter;
                textBoxDescription.MouseEnter += textBoxDescription_MouseEnter;
                textBoxDemand.MouseEnter      += textBoxDemand_MouseEnter;
                break;
            }
        }
        private void useFilter_button_MouseEnter(object sender, EventArgs e) // курсор внутри 'Фильтр'
        {
            info.Text = "Вырезать результаты отклоняющиеся на 10% от средней з/п?";
        }
        private void useFilter_button_MouseLeave(object sender, EventArgs e) // курсор снаружи 'Фильтр'
        {
            info.Text = "";
        }
        private void goWalker_button_MouseEnter(object sender, EventArgs e)  // курсор внутри 'Извлечь'
        {
            info.Text = "Запустить сбор данных?";
        }
        private void goWalker_button_MouseLeave(object sender, EventArgs e)  // курсор снаружи 'Извлечь'
        {
            info.Text = "";
        }
        private void insertDB_button_MouseEnter(object sender, EventArgs e)  // курсор внутри 'Вставить'
        {
            info.Text = "Добавить введённые данные в DB?";
        }
        private void insertDB_button_MouseLeave(object sender, EventArgs e)  // курсор снаружи 'Вставить'
        {
            info.Text = "";
        }
        private void recordDB_button_MouseEnter(object sender, EventArgs e)  // курсор внутри 'Запись'
        {
            info.Text = "Записать все данные в DB?";
        }
        private void recordDB_button_MouseLeave(object sender, EventArgs e)  // курсор снаружи 'Запись'
        {
            info.Text = "";
        }
        private void delDB_button_MouseEnter(object sender, EventArgs e)     // курсор внутри 'Удалить'
        {
            info.Text = "Для удаления строки выберите лежащую в ней ячейку.";
        }
        private void delDB_button_MouseLeave(object sender, EventArgs e)     // курсор снаружи 'Удалить'
        {
            info.Text = "";
        }
        private void trackBar_MouseEnter(object sender, EventArgs e)         // курсор внутри 'trackBar'
        {
            info.Text = "Установить число просматриваемых страниц?";
        }
        private void trackBar_MouseLeave(object sender, EventArgs e)         // курсор снаружи 'trackBar'
        {
            info.Text = "";
        }
        private void textBoxCompany_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Компания...";
        }
        private void textBoxCompany_MouseLeave(object sender, EventArgs e)
        {
            info.Text = "";
        }
        private void textBoxProfession_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Должность...";
        }
        private void textBoxProfession_MouseLeave(object sender, EventArgs e)
        {
            info.Text = "";
        }
        private void textBoxSalary_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Зарплата...";
        }
        private void textBoxSalary_MouseLeave(object sender, EventArgs e)
        {
            info.Text = "";
        }
        private void textBoxDescription_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Описание...";
        }
        private void textBoxDescription_MouseLeave(object sender, EventArgs e)
        {
            info.Text = "";
        }
        private void textBoxDemand_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Требования...";
        }
        private void textBoxDemand_MouseLeave(object sender, EventArgs e)
        {
            info.Text = "";
        }
    }
}
