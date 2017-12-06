using System;
using System.IO;
using System.Windows.Forms;

namespace Data_Collector
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

#if DEBUG == false // в режиме DEBUG код не будет вкл. в собираемые сборки RELEASE
            // указываем путь к DB после установки программы
            String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //String dbPathAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String dbPath = Path.Combine(dbPathMyDocs, "Data CollectorDB");
            // переопределение значения переменной DataDirectory
            AppDomain.CurrentDomain.SetData("DataDirectory", dbPath);
#endif


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
