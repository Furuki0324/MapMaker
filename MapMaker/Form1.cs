﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace MapMaker
{
    public partial class Form1 : Form
    {
        private const float scalar = 0.95f;
        private SQLiteConnection sq;
        private Image _image = null;
        private PreviewForm _preview;

        public Form1()
        {
            _preview = new PreviewForm(this);
            _preview.Show();
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
            //SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.FileName = "NewDatabase.db";
            //saveFile.InitialDirectory = @"C:\";
            //saveFile.Filter = "すべてのファイル(*.*)|*.*";
            //saveFile.Title = "保存先を選択してください";

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNGファイル|*.png|JPGファイル|*.jpg;*.jpeg";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                if(_image != null)
                {
                    _image.Dispose();
                }
                _image = Image.FromFile(openFile.FileName);
                ChipSet.Image = _image;
                ChipSet.Size = _image.Size;
                //var stream = saveFile.FileName;
                Console.WriteLine("Success");
                //Console.WriteLine(stream);

                using(var settingForm = new SettingForm(this))
                {
                    settingForm.ShowDialog();
                }
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if(_preview != null)
            {
                _preview.Close();
            }
        }

        private void OnFormResize(object sender, EventArgs e)
        {
            BottomContainer.Width = (int)(ActiveForm.Width * scalar);
            TopContainer.Width = (int)(ActiveForm.Width * scalar);
        }

        private void OnChipSetClick(object sender, EventArgs e)
        {
            Point mousePoint = MousePosition;
            Point chipSetOrigin = PointToScreen(ChipSet.Location);

            int x = mousePoint.X - chipSetOrigin.X;
            int y = mousePoint.Y - chipSetOrigin.Y;
            int chipWidth = 1;
            int chipHeight = 1;
            if(ChipWidthBox.TextLength == 0
                || !int.TryParse(ChipWidthBox.Text, out chipWidth)
                || ChipHeightBox.TextLength == 0
                || !int.TryParse(ChipHeightBox.Text, out chipHeight))
            {
                CurrentChip.Text = "NaN";
                return;
            }

            int chipsInRow = ChipSet.Width / chipWidth;
            int currentChip = (y / chipHeight) * chipsInRow + x / chipWidth;
            CurrentChip.Text = currentChip.ToString();
        }

        private void OnGridSelectionChanged(object sender, EventArgs e)
        {
            if(CurrentChip.TextLength == 0
                || CurrentChip.Text == "NaN")
            {
                return;
            }

            int.TryParse(CurrentChip.Text, out int value);
            MapGrid.SelectedCells[0].Value = value;
        }

        private void RefleshPreviewForm()
        {
            if(_preview == null)
            {
                _preview = new PreviewForm(this);
                _preview.Show();
            }


        }

        public void ClosePreviewForm()
        {
            _preview = null;
        }

        private void OnClosePreviewClicked(object sender, EventArgs e)
        {
            _preview.Close();
            _preview = null;
        }

        private void OnRefleshPreviewClicked(object sender, EventArgs e)
        {
            if(_preview == null)
            {
                _preview = new PreviewForm(this);
                _preview.Show();
            }

            _preview.Reflesh();
        }

        private void OnGenerateCsvClicked(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSVファイル|*.csv";
            saveFile.FileName = "NewMapData.csv";
            saveFile.Title = "保存先を選択してください";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName, false,Encoding.GetEncoding("shift-jis")))
                {
                    for(int i = 0; i < MapGrid.RowCount; ++i)
                    {
                        List<string> csvData = new List<string>();
                        for (int j = 0; j < MapGrid.ColumnCount; ++j)
                        {
                            csvData.Add(MapGrid[j, i].Value.ToString());
                        }
                        //string[] array = csvData.ToArray();
                        string output = string.Join(",", csvData.ToArray());
                        writer.WriteLine(output);
                    }
                }
            }
        }
    }
}
