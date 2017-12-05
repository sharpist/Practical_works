using System;
using System.Data;
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
                case 0:
                textBox.Text = $"Получение данных с веб-ресурса...{Environment.NewLine}Процесс работает в фоновом режиме...";
                trackBar.Enabled = false;
                useFilter_button.MouseEnter -= useFilter_button_MouseEnter;  // отписка для 'Фильтр'
                goWalker_button.MouseEnter -= goWalker_button_MouseEnter;    // отписка для 'Извлечь'
                writeDB_button.MouseEnter -= writeDB_button_MouseEnter;      // отписка для 'DB'
                trackBar.MouseEnter -= trackBar_MouseEnter;                  // отписка для 'trackBar'
                break;

                case 1:
                textBox.Text = "";
                trackBar.Enabled = true;
                useFilter_button.MouseEnter += useFilter_button_MouseEnter;  // подписка для 'Фильтр'
                goWalker_button.MouseEnter += goWalker_button_MouseEnter;    // подписка для 'Извлечь'
                writeDB_button.MouseEnter += writeDB_button_MouseEnter;      // подписка для 'DB'
                trackBar.MouseEnter += trackBar_MouseEnter;                  // подписка для 'trackBar'
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
        private void writeDB_button_MouseEnter(object sender, EventArgs e)   // курсор внутри 'DB'
        {
            info.Text = "Сохранить данные?";
        }
        private void writeDB_button_MouseLeave(object sender, EventArgs e)   // курсор снаружи 'DB'
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
    }
}
