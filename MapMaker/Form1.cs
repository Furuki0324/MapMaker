using System;
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
        private int _chipWidth = 1;
        private int _chipHeight = 1;
        private int _chipsInRow = 1;
        private Bitmap _previewBitmap;
        private bool _showPreview = false;
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

                using(var settingForm = new SettingForm(this))
                {
                    settingForm.ShowDialog();
                }

                _previewBitmap = new Bitmap(MapPreviewBox.Width, MapPreviewBox.Height);
                MapPreviewBox.Image = _previewBitmap;
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
            if(ChipWidthBox.TextLength == 0
                || !int.TryParse(ChipWidthBox.Text, out _chipWidth)
                || ChipHeightBox.TextLength == 0
                || !int.TryParse(ChipHeightBox.Text, out _chipHeight))
            {
                CurrentChip.Text = "NaN";
                return;
            }

            _chipsInRow = ChipSet.Width / _chipWidth;
            int currentChip = (y / _chipHeight) * _chipsInRow + x / _chipWidth;
            CurrentChip.Text = currentChip.ToString();
        }

        private void OnGridSelectionChanged(object sender, EventArgs e)
        {
            //if(CurrentChip.TextLength == 0
            //    || CurrentChip.Text == "NaN")
            //{
            //    return;
            //}

            //int.TryParse(CurrentChip.Text, out int value);
            //foreach(DataGridViewCell cell in MapGrid.SelectedCells)
            //{
            //    cell.Value = value;
            //    DrawGrid(cell.RowIndex, cell.ColumnIndex);
            //}
        }

        private void DrawGrid(int selectedRow, int selectedColumn)
        {
            Graphics graphics = Graphics.FromImage(_previewBitmap);
            GraphicsUnit unit = GraphicsUnit.Pixel;

            Rectangle destRect = new Rectangle();
            destRect.X = selectedColumn * _chipWidth;
            destRect.Y = selectedRow * _chipHeight;
            destRect.Width = _chipWidth;
            destRect.Height = _chipHeight;

            Rectangle sourceRect = new Rectangle();
            int.TryParse(CurrentChip.Text, out int currentChip);
            int currentChipRow, currentChipColumn;
            currentChipRow = currentChip / _chipsInRow;
            currentChipColumn = currentChip % _chipsInRow;
            sourceRect.X = currentChipColumn * _chipHeight;
            sourceRect.Y = currentChipRow * _chipWidth;
            sourceRect.Width = _chipWidth;
            sourceRect.Height = _chipHeight;
            graphics.DrawImage(ChipSet.Image, destRect, sourceRect, unit);

            graphics.Dispose();
            MapPreviewBox.Refresh();
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

            if(ChipSet.Image != null)
            {
                int.TryParse(MapWidthBox.Text, out int mapWidth);
                int.TryParse(MapHeightBox.Text, out int mapHeight);

                Bitmap chipSet = new Bitmap(ChipSet.Image);
                Bitmap preview = new Bitmap(mapWidth, mapHeight);
                for(int i = 0; i < MapGrid.RowCount; ++i)
                {
                    for(int j = 0; j < MapGrid.ColumnCount; ++j)
                    {

                    }
                }
                _preview.Reflesh(preview);
            }
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
                        
                        string output = string.Join(",", csvData.ToArray());
                        writer.WriteLine(output);
                    }
                }
            }
        }

        private void OnShowPreviewButtonClicked(object sender, MouseEventArgs e)
        {
            _showPreview = !_showPreview;
            MapPreviewBox.Visible = _showPreview;
        }

        private void OnMouseUpOverGrid(object sender, MouseEventArgs e)
        {
            if (CurrentChip.TextLength == 0
                || CurrentChip.Text == "NaN")
            {
                return;
            }

            int.TryParse(CurrentChip.Text, out int value);
            foreach (DataGridViewCell cell in MapGrid.SelectedCells)
            {
                cell.Value = value;
                DrawGrid(cell.RowIndex, cell.ColumnIndex);
            }
        }
    }
}
