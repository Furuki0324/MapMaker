using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public class ProjectData
    {
        public string projectDataPath { get; set; }
        public string mapChipFilePath { get; set; }
        public string mapCsvFilePath { get; set; }
        public int mapWidth { get; set; }
        public int mapHeight { get; set; }
        public int chipWidth { get; set; }
        public int chipHeight { get; set; }
        public int chipsInRow { get; set; }
    }
}
