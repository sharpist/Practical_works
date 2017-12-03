using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

#if DEBUG == false
            // путь к данным
            String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //String dbPathAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String dbPath = Path.Combine(dbPathMyDocs, "Data_CollectorLocalDB");
            AppDomain.CurrentDomain.SetData("DataDirectory", dbPath);
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
