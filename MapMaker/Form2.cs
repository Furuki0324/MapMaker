using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMaker
{
    public partial class SettingForm : Form
    {
        private Form1 _form1;

        public SettingForm(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void OnOkButtonClicked(object sender, MouseEventArgs e)
        {
            if(MapWidth.Value <= 0
                || MapHeight.Value <= 0
                || ChipWidth.Value <= 0
                || ChipHeight.Value <= 0)
            {
                return;
            }

            _form1.MapWidthBox.Text = MapWidth.Value.ToString();
            _form1.MapHeightBox.Text = MapHeight.Value.ToString();
            _form1.ChipWidthBox.Text = ChipWidth.Value.ToString();
            _form1.ChipHeightBox.Text = ChipHeight.Value.ToString();

            //_form1.MapGrid.Width = (int)MapWidth.Value;
            //_form1.MapGrid.Height = (int)MapHeight.Value;
            _form1.MapGrid.ColumnCount = (int)MapHeight.Value / (int)ChipHeight.Value;
            _form1.MapGrid.RowCount = (int)MapWidth.Value / (int)ChipWidth.Value; ;
            for(int i = 0; i < _form1.MapGrid.RowCount; ++i)
            {
                _form1.MapGrid.Rows[i].Height = (int)ChipHeight.Value;
                for(int j = 0; j < _form1.MapGrid.ColumnCount; ++j)
                {
                    if(i == 0)
                    {
                        _form1.MapGrid.Columns[j].Width = (int)ChipWidth.Value;
                    }
                    _form1.MapGrid.Rows[i].Cells[j].Value = 0;
                }
            }
            Close();
        }
    }
}
