﻿using System;
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
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Data Collector\" пример программы для сбора данных с веб ресурса.\nBy Alexander Usov", "О программе");
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
    }
}
