using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MapMaker
{
    public partial class Form1 : Form
    {
        private const float scalar = 0.95f;
        private SQLiteConnection sq;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnMakeNewButtonClicked(object sender, EventArgs e)
        {
            //var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "DZ.db" };

            //using(var cn = new SQLiteConnection(sqlConnectionSb.ToString()))
            //{
            //    cn.Open();

            //    using(var cmd = new SQLiteCommand(cn))
            //    {
            //        cmd.CommandText = "CREATE TABLE IF NOT EXISTS DZ(" +
            //            "no INTEGER NOT NULL PRIMARY KEY," +
            //            "name TEXT NOT NULL," +
            //            "path TEXT NOT NULL," +
            //            "value TEXT NOT NULL";
            //        cmd.ExecuteNonQuery();


            //    }
            //}
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "NewDatabase.db";
            saveFile.InitialDirectory = @"C:\";
            saveFile.Filter = "すべてのファイル(*.*)|*.*";
            saveFile.Title = "保存先を選択してください";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                var stream = saveFile.FileName;
                Console.WriteLine("Success");
                Console.WriteLine(stream);

                MapGrid.ColumnCount = 4;
                MapGrid.Rows.Add(0, 0, 0, 0);
                MapGrid.Rows.Add(0, 0, 0, 0);
                MapGrid.Rows.Add(0, 0, 0, 0);
                MapGrid.Rows.Add(0, 0, 0, 0);
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void OnFormResize(object sender, EventArgs e)
        {
            BottomContainer.Width = (int)(ActiveForm.Width * scalar);
            TopContainer.Width = (int)(ActiveForm.Width * scalar);
        }
    }
}
