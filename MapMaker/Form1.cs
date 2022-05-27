using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        private Image _image = null;
        private ProjectData projectData = new ProjectData();

        public Form1()
        {
            InitializeComponent();
        }

        private void OnMakeNewButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNGファイル|*.png|JPGファイル|*.jpg;*.jpeg";
            openFile.Title = "マップチップの画像を選択してください";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                if(_image != null)
                {
                    _image.Dispose();
                }
                _image = Image.FromFile(openFile.FileName);
                ChipSet.Image = _image;
                ChipSet.Size = _image.Size;

                //この周辺は別フォームで変数を変更したりこっちのフォームで変更したりしていて
                //一貫性が無い。修正が必要。
                using(var settingForm = new SettingForm(this))
                {
                    settingForm.ShowDialog();
                }

                _previewBitmap = new Bitmap(MapPreviewBox.Width, MapPreviewBox.Height);
                MapPreviewBox.Image = _previewBitmap;

                int.TryParse(MapWidthBox.Text, out int mapWidth);
                int.TryParse(MapHeightBox.Text, out int mapHeight);
                int.TryParse(ChipWidthBox.Text, out int chipWidth);
                int.TryParse(ChipHeightBox.Text, out int chipHeight);
                projectData.mapChipFilePath = openFile.FileName;
                projectData.mapWidth = mapWidth;
                projectData.mapHeight = mapHeight;
                projectData.chipWidth = chipWidth;
                projectData.chipHeight = chipHeight;

                _chipsInRow = ChipSet.Width / _chipWidth;
                projectData.chipsInRow = _chipsInRow;
            }
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
            projectData.chipsInRow = _chipsInRow;
            int currentChip = (y / _chipHeight) * _chipsInRow + x / _chipWidth;
            CurrentChip.Text = currentChip.ToString();
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
            int.TryParse(MapGrid.Rows[selectedRow].Cells[selectedColumn].Value.ToString(), out int selected);
            int.TryParse(CurrentChip.Text, out int currentChip);
            int currentChipRow, currentChipColumn;
            currentChipRow = selected / _chipsInRow;
            currentChipColumn = selected % _chipsInRow;
            sourceRect.X = currentChipColumn * _chipHeight;
            sourceRect.Y = currentChipRow * _chipWidth;
            sourceRect.Width = _chipWidth;
            sourceRect.Height = _chipHeight;
            graphics.DrawImage(ChipSet.Image, destRect, sourceRect, unit);

            graphics.Dispose();
            MapPreviewBox.Refresh();
        }

        private void OnGenerateCsvClicked(object sender, EventArgs e)
        {
            if(projectData.mapCsvFilePath == null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "CSVファイル|*.csv";
                saveFile.FileName = "NewMapData.csv";
                saveFile.Title = "グリッドデータの保存先を選択してください";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFile.FileName, false, Encoding.UTF8))
                    {
                        for (int i = 0; i < MapGrid.RowCount; ++i)
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

                    projectData.mapCsvFilePath = saveFile.FileName;
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(projectData.mapCsvFilePath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < MapGrid.RowCount; ++i)
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

        private void OnLoadFileClicked(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jsonファイル|*.json";
            openFile.Title = "プロジェクトデータを選択してください";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFile.FileName);
                projectData = JsonSerializer.Deserialize<ProjectData>(jsonString);

                if(!File.Exists(projectData.mapCsvFilePath))
                {
                    MessageBox.Show("保存した場所にCSVファイルが存在しません。\n移動または削除された可能性があります。", "エラー", MessageBoxButtons.OK);
                    return;
                }
                if(!File.Exists(projectData.mapChipFilePath))
                {
                    MessageBox.Show("使用しているマップチップの画像を見つけられませんでした。\n移動または削除された可能性があります。", "エラー", MessageBoxButtons.OK);
                    return;
                }

                MapGrid.Width = projectData.mapWidth;
                MapGrid.Height = projectData.mapHeight;
                MapGrid.RowCount = projectData.mapHeight / projectData.chipHeight;
                MapGrid.ColumnCount = projectData.mapWidth / projectData.chipWidth;
                for(int i = 0; i < MapGrid.RowCount; ++i)
                {
                    MapGrid.Rows[i].Height = projectData.chipHeight;
                    for(int j = 0; j < MapGrid.ColumnCount; ++j)
                    {
                        if(i == 0)
                        {
                            MapGrid.Columns[j].Width = projectData.chipWidth;
                        }
                    }
                }
                MapPreviewBox.Width = projectData.mapWidth;
                MapPreviewBox.Height = projectData.mapHeight;
                _previewBitmap = new Bitmap(MapPreviewBox.Width, MapPreviewBox.Height);
                MapPreviewBox.Image = _previewBitmap;

                MapWidthBox.Text = projectData.mapWidth.ToString();
                MapHeightBox.Text = projectData.mapHeight.ToString();
                ChipWidthBox.Text = projectData.chipWidth.ToString();
                ChipHeightBox.Text = projectData.chipHeight.ToString();
                _chipWidth = projectData.chipWidth;
                _chipHeight = projectData.chipHeight;

                if(_image != null)
                {
                    _image.Dispose();
                }
                _image = Image.FromFile(projectData.mapChipFilePath);
                ChipSet.Image = _image;
                ChipSet.Size = _image.Size;
                _chipsInRow = ChipSet.Width / _chipWidth;
                using(TextFieldParser parser = new TextFieldParser(projectData.mapCsvFilePath, Encoding.UTF8))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    int rowCount = 0;
                    while(!parser.EndOfData)
                    {
                        string[] line = parser.ReadFields();
                        for(int i = 0; i < line.Length; ++i)
                        {
                            MapGrid.Rows[rowCount].Cells[i].Value = line[i];
                            if (line[i] != "0") DrawGrid(rowCount, i);
                        }
                        ++rowCount;
                    }
                }
            }
        }

        private void OnSaveFileClicked(object sender, EventArgs e)
        {
            if(projectData.projectDataPath == null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "jsonファイル|*.json";
                saveFile.FileName = "NewProjectData.json";
                saveFile.Title = "プロジェクトの保存先を選択してください";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    projectData.projectDataPath = saveFile.FileName;
                }
                else
                {
                    return;
                }
            }
            OnGenerateCsvClicked(sender, e);
            string jsonString = JsonSerializer.Serialize(projectData);
            File.WriteAllText(projectData.projectDataPath, jsonString);
        }
    }
}
