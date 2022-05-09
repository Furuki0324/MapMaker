
namespace MapMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BottomContainer = new System.Windows.Forms.SplitContainer();
            this.TopContainer = new System.Windows.Forms.SplitContainer();
            this.ChipSet = new System.Windows.Forms.PictureBox();
            this.MapGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeNew = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.MapWidthBox = new System.Windows.Forms.TextBox();
            this.MapHeightBox = new System.Windows.Forms.TextBox();
            this.MapWidthLabel = new System.Windows.Forms.Label();
            this.MapHeightLabel = new System.Windows.Forms.Label();
            this.ChipWidthLabel = new System.Windows.Forms.Label();
            this.ChipWidthBox = new System.Windows.Forms.TextBox();
            this.ChipHeightLabel = new System.Windows.Forms.Label();
            this.ChipHeightBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BottomContainer)).BeginInit();
            this.BottomContainer.Panel1.SuspendLayout();
            this.BottomContainer.Panel2.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopContainer)).BeginInit();
            this.TopContainer.Panel1.SuspendLayout();
            this.TopContainer.Panel2.SuspendLayout();
            this.TopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChipSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomContainer
            // 
            this.BottomContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomContainer.IsSplitterFixed = true;
            this.BottomContainer.Location = new System.Drawing.Point(0, 0);
            this.BottomContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BottomContainer.Panel1
            // 
            this.BottomContainer.Panel1.Controls.Add(this.TopContainer);
            // 
            // BottomContainer.Panel2
            // 
            this.BottomContainer.Panel2.Controls.Add(this.ChipHeightLabel);
            this.BottomContainer.Panel2.Controls.Add(this.ChipHeightBox);
            this.BottomContainer.Panel2.Controls.Add(this.ChipWidthLabel);
            this.BottomContainer.Panel2.Controls.Add(this.ChipWidthBox);
            this.BottomContainer.Panel2.Controls.Add(this.MapHeightLabel);
            this.BottomContainer.Panel2.Controls.Add(this.MapWidthLabel);
            this.BottomContainer.Panel2.Controls.Add(this.MapHeightBox);
            this.BottomContainer.Panel2.Controls.Add(this.MapWidthBox);
            this.BottomContainer.Panel2.Controls.Add(this.menuStrip1);
            this.BottomContainer.Size = new System.Drawing.Size(1313, 660);
            this.BottomContainer.SplitterDistance = 600;
            this.BottomContainer.SplitterWidth = 5;
            this.BottomContainer.TabIndex = 0;
            // 
            // TopContainer
            // 
            this.TopContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopContainer.Name = "TopContainer";
            // 
            // TopContainer.Panel1
            // 
            this.TopContainer.Panel1.Controls.Add(this.ChipSet);
            // 
            // TopContainer.Panel2
            // 
            this.TopContainer.Panel2.AutoScroll = true;
            this.TopContainer.Panel2.Controls.Add(this.MapGrid);
            this.TopContainer.Panel2.Controls.Add(this.groupBox1);
            this.TopContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.TopContainer.Size = new System.Drawing.Size(1313, 600);
            this.TopContainer.SplitterDistance = 300;
            this.TopContainer.SplitterWidth = 5;
            this.TopContainer.TabIndex = 0;
            // 
            // ChipSet
            // 
            this.ChipSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChipSet.Location = new System.Drawing.Point(17, 16);
            this.ChipSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChipSet.Name = "ChipSet";
            this.ChipSet.Size = new System.Drawing.Size(361, 550);
            this.ChipSet.TabIndex = 0;
            this.ChipSet.TabStop = false;
            // 
            // MapGrid
            // 
            this.MapGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapGrid.Location = new System.Drawing.Point(69, 292);
            this.MapGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MapGrid.Name = "MapGrid";
            this.MapGrid.RowHeadersWidth = 51;
            this.MapGrid.RowTemplate.Height = 21;
            this.MapGrid.Size = new System.Drawing.Size(320, 188);
            this.MapGrid.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(419, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(440, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 30;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPanel});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(17, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(73, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuPanel
            // 
            this.MenuPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeNew,
            this.SaveData,
            this.LoadData,
            this.GenerateCSV});
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(65, 24);
            this.MenuPanel.Text = "ファイル";
            // 
            // MakeNew
            // 
            this.MakeNew.Name = "MakeNew";
            this.MakeNew.Size = new System.Drawing.Size(224, 26);
            this.MakeNew.Text = "新規";
            this.MakeNew.Click += new System.EventHandler(this.OnMakeNewButtonClicked);
            // 
            // SaveData
            // 
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(224, 26);
            this.SaveData.Text = "保存";
            // 
            // LoadData
            // 
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(224, 26);
            this.LoadData.Text = "読み込み";
            // 
            // GenerateCSV
            // 
            this.GenerateCSV.Name = "GenerateCSV";
            this.GenerateCSV.Size = new System.Drawing.Size(224, 26);
            this.GenerateCSV.Text = "CSVファイルを出力";
            // 
            // MapWidthBox
            // 
            this.MapWidthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MapWidthBox.Location = new System.Drawing.Point(241, 20);
            this.MapWidthBox.Name = "MapWidthBox";
            this.MapWidthBox.Size = new System.Drawing.Size(100, 22);
            this.MapWidthBox.TabIndex = 1;
            // 
            // MapHeightBox
            // 
            this.MapHeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MapHeightBox.Location = new System.Drawing.Point(456, 20);
            this.MapHeightBox.Name = "MapHeightBox";
            this.MapHeightBox.Size = new System.Drawing.Size(100, 22);
            this.MapHeightBox.TabIndex = 2;
            // 
            // MapWidthLabel
            // 
            this.MapWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MapWidthLabel.AutoSize = true;
            this.MapWidthLabel.Location = new System.Drawing.Point(146, 23);
            this.MapWidthLabel.Name = "MapWidthLabel";
            this.MapWidthLabel.Size = new System.Drawing.Size(89, 15);
            this.MapWidthLabel.TabIndex = 3;
            this.MapWidthLabel.Text = "マップの幅(px)";
            // 
            // MapHeightLabel
            // 
            this.MapHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MapHeightLabel.AutoSize = true;
            this.MapHeightLabel.Location = new System.Drawing.Point(351, 23);
            this.MapHeightLabel.Name = "MapHeightLabel";
            this.MapHeightLabel.Size = new System.Drawing.Size(99, 15);
            this.MapHeightLabel.TabIndex = 4;
            this.MapHeightLabel.Text = "マップの高さ(px)";
            // 
            // ChipWidthLabel
            // 
            this.ChipWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChipWidthLabel.AutoSize = true;
            this.ChipWidthLabel.Location = new System.Drawing.Point(634, 23);
            this.ChipWidthLabel.Name = "ChipWidthLabel";
            this.ChipWidthLabel.Size = new System.Drawing.Size(90, 15);
            this.ChipWidthLabel.TabIndex = 6;
            this.ChipWidthLabel.Text = "チップの幅(px)";
            // 
            // ChipWidthBox
            // 
            this.ChipWidthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChipWidthBox.Location = new System.Drawing.Point(729, 20);
            this.ChipWidthBox.Name = "ChipWidthBox";
            this.ChipWidthBox.Size = new System.Drawing.Size(100, 22);
            this.ChipWidthBox.TabIndex = 5;
            // 
            // ChipHeightLabel
            // 
            this.ChipHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChipHeightLabel.AutoSize = true;
            this.ChipHeightLabel.Location = new System.Drawing.Point(835, 23);
            this.ChipHeightLabel.Name = "ChipHeightLabel";
            this.ChipHeightLabel.Size = new System.Drawing.Size(100, 15);
            this.ChipHeightLabel.TabIndex = 8;
            this.ChipHeightLabel.Text = "チップの高さ(px)";
            // 
            // ChipHeightBox
            // 
            this.ChipHeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChipHeightBox.Location = new System.Drawing.Point(941, 20);
            this.ChipHeightBox.Name = "ChipHeightBox";
            this.ChipHeightBox.Size = new System.Drawing.Size(100, 22);
            this.ChipHeightBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1313, 660);
            this.Controls.Add(this.BottomContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MapMaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResizeEnd += new System.EventHandler(this.OnFormResize);
            this.BottomContainer.Panel1.ResumeLayout(false);
            this.BottomContainer.Panel2.ResumeLayout(false);
            this.BottomContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomContainer)).EndInit();
            this.BottomContainer.ResumeLayout(false);
            this.TopContainer.Panel1.ResumeLayout(false);
            this.TopContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopContainer)).EndInit();
            this.TopContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChipSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer BottomContainer;
        private System.Windows.Forms.SplitContainer TopContainer;
        private System.Windows.Forms.PictureBox ChipSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuPanel;
        private System.Windows.Forms.ToolStripMenuItem SaveData;
        private System.Windows.Forms.ToolStripMenuItem LoadData;
        private System.Windows.Forms.ToolStripMenuItem MakeNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem GenerateCSV;
        private System.Windows.Forms.DataGridView MapGrid;
        private System.Windows.Forms.Label ChipHeightLabel;
        private System.Windows.Forms.TextBox ChipHeightBox;
        private System.Windows.Forms.Label ChipWidthLabel;
        private System.Windows.Forms.TextBox ChipWidthBox;
        private System.Windows.Forms.Label MapHeightLabel;
        private System.Windows.Forms.Label MapWidthLabel;
        private System.Windows.Forms.TextBox MapHeightBox;
        private System.Windows.Forms.TextBox MapWidthBox;
    }
}

