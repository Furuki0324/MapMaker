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
    public partial class PreviewForm : Form
    {
        private Form1 _form1;
        public PreviewForm(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void OnPreviewFormClosing(object sender, FormClosingEventArgs e)
        {
            _form1.ClosePreviewForm();
        }

        public void Reflesh()
        {

        }
    }
}
