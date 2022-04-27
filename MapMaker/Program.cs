using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MapMaker
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }

    class Data
    {
        private void ExecuteNonQuery(string query)
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=DataBase.sqlite"))
                using(var command = conn.CreateCommand())
                {
                    //データベースに接続
                    conn.Open();

                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
