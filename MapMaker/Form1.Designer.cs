
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
            this.MapPreviewBox = new System.Windows.Forms.PictureBox();
            this.MapGrid = new System.Windows.Forms.DataGridView();
            this.CurrentChipLabel = new System.Windows.Forms.Label();
            this.DoesShowPreview = new System.Windows.Forms.CheckBox();
            this.CurrentChip = new System.Windows.Forms.TextBox();
            this.ChipHeightLabel = new System.Windows.Forms.Label();
            this.ChipHeightBox = new System.Windows.Forms.TextBox();
            this.ChipWidthLabel = new System.Windows.Forms.Label();
            this.ChipWidthBox = new System.Windows.Forms.TextBox();
            this.MapHeightLabel = new System.Windows.Forms.Label();
            this.MapWidthLabel = new System.Windows.Forms.Label();
            this.MapHeightBox = new System.Windows.Forms.TextBox();
            this.MapWidthBox = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeNew = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateCSV = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BottomContainer)).BeginInit();
            this.BottomContainer.Panel1.SuspendLayout();
            this.BottomContainer.Panel2.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopContainer)).BeginInit();
            this.TopContainer.Panel1.SuspendLayout();
            this.TopContainer.Panel2.SuspendLayout();
            this.TopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChipSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapGrid)).BeginInit();
            this.MenuStrip.SuspendLayout();
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
            this.BottomContainer.Panel2.Controls.Add(this.CurrentChipLabel);
            this.BottomContainer.Panel2.Controls.Add(this.DoesShowPreview);
            this.BottomContainer.Panel2.Controls.Add(this.CurrentChip);
            this.BottomContainer.Panel2.Controls.Add(this.ChipHeightLabel);
            this.BottomContainer.Panel2.Controls.Add(this.ChipHeightBox);
            this.BottomContainer.Panel2.Controls.Add(this.ChipWidthLabel);
            this.BottomContainer.Panel2.Controls.Add(this.ChipWidthBox);
            this.BottomContainer.Panel2.Controls.Add(this.MapHeightLabel);
            this.BottomContainer.Panel2.Controls.Add(this.MapWidthLabel);
            this.BottomContainer.Panel2.Controls.Add(this.MapHeightBox);
            this.BottomContainer.Panel2.Controls.Add(this.MapWidthBox);
            this.BottomContainer.Panel2.Controls.Add(this.MenuStrip);
            this.BottomContainer.Size = new System.Drawing.Size(1149, 660);
            this.BottomContainer.SplitterDistance = 597;
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
            this.TopContainer.Panel1.AutoScroll = true;
            this.TopContainer.Panel1.Controls.Add(this.ChipSet);
            // 
            // TopContainer.Panel2
            // 
            this.TopContainer.Panel2.AutoScroll = true;
            this.TopContainer.Panel2.Controls.Add(this.MapPreviewBox);
            this.TopContainer.Panel2.Controls.Add(this.MapGrid);
            this.TopContainer.Size = new System.Drawing.Size(1149, 597);
            this.TopContainer.SplitterDistance = 261;
            this.TopContainer.SplitterWidth = 5;
            this.TopContainer.TabIndex = 0;
            // 
            // ChipSet
            // 
            this.ChipSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChipSet.Location = new System.Drawing.Point(13, 16);
            this.ChipSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChipSet.Name = "ChipSet";
            this.ChipSet.Size = new System.Drawing.Size(241, 550);
            this.ChipSet.TabIndex = 0;
            this.ChipSet.TabStop = false;
            this.ChipSet.Click += new System.EventHandler(this.OnChipSetClick);
            // 
            // MapPreviewBox
            // 
            this.MapPreviewBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MapPreviewBox.Enabled = false;
            this.MapPreviewBox.Location = new System.Drawing.Point(42, 16);
            this.MapPreviewBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MapPreviewBox.Name = "MapPreviewBox";
            this.MapPreviewBox.Size = new System.Drawing.Size(794, 550);
            this.MapPreviewBox.TabIndex = 4;
            this.MapPreviewBox.TabStop = false;
            this.MapPreviewBox.Visible = false;
            // 
            // MapGrid
            // 
            this.MapGrid.AllowUserToAddRows = false;
            this.MapGrid.AllowUserToDeleteRows = false;
            this.MapGrid.AllowUserToResizeColumns = false;
            this.MapGrid.AllowUserToResizeRows = false;
            this.MapGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapGrid.ColumnHeadersVisible = false;
            this.MapGrid.Location = new System.Drawing.Point(42, 16);
            this.MapGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MapGrid.Name = "MapGrid";
            this.MapGrid.ReadOnly = true;
            this.MapGrid.RowHeadersVisible = false;
            this.MapGrid.RowHeadersWidth = 51;
            this.MapGrid.RowTemplate.Height = 21;
            this.MapGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MapGrid.Size = new System.Drawing.Size(794, 550);
            this.MapGrid.TabIndex = 2;
            this.MapGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpOverGrid);
            // 
            // CurrentChipLabel
            // 
            this.CurrentChipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentChipLabel.AutoSize = true;
            this.CurrentChipLabel.Location = new System.Drawing.Point(976, 26);
            this.CurrentChipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentChipLabel.Name = "CurrentChipLabel";
            this.CurrentChipLabel.Size = new System.Drawing.Size(79, 15);
            this.CurrentChipLabel.TabIndex = 10;
            this.CurrentChipLabel.Text = "選択中のチップ";
            // 
            // DoesShowPreview
            // 
            this.DoesShowPreview.AutoSize = true;
            this.DoesShowPreview.Location = new System.Drawing.Point(74, 21);
            this.DoesShowPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoesShowPreview.Name = "DoesShowPreview";
            this.DoesShowPreview.Size = new System.Drawing.Size(101, 19);
            this.DoesShowPreview.TabIndex = 3;
            this.DoesShowPreview.Text = "プレビューを表示";
            this.DoesShowPreview.UseVisualStyleBackColor = true;
            this.DoesShowPreview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnShowPreviewButtonClicked);
            // 
            // CurrentChip
            // 
            this.CurrentChip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentChip.Location = new System.Drawing.Point(1072, 22);
            this.CurrentChip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CurrentChip.Name = "CurrentChip";
            this.CurrentChip.ReadOnly = true;
            this.CurrentChip.Size = new System.Drawing.Size(70, 23);
            this.CurrentChip.TabIndex = 9;
            // 
            // ChipHeightLabel
            // 
            this.ChipHeightLabel.AutoSize = true;
            this.ChipHeightLabel.Location = new System.Drawing.Point(788, 24);
            this.ChipHeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChipHeightLabel.Name = "ChipHeightLabel";
            this.ChipHeightLabel.Size = new System.Drawing.Size(84, 15);
            this.ChipHeightLabel.TabIndex = 8;
            this.ChipHeightLabel.Text = "チップの高さ(px)";
            // 
            // ChipHeightBox
            // 
            this.ChipHeightBox.Location = new System.Drawing.Point(886, 20);
            this.ChipHeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChipHeightBox.Name = "ChipHeightBox";
            this.ChipHeightBox.ReadOnly = true;
            this.ChipHeightBox.Size = new System.Drawing.Size(88, 23);
            this.ChipHeightBox.TabIndex = 7;
            // 
            // ChipWidthLabel
            // 
            this.ChipWidthLabel.AutoSize = true;
            this.ChipWidthLabel.Location = new System.Drawing.Point(600, 24);
            this.ChipWidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChipWidthLabel.Name = "ChipWidthLabel";
            this.ChipWidthLabel.Size = new System.Drawing.Size(76, 15);
            this.ChipWidthLabel.TabIndex = 6;
            this.ChipWidthLabel.Text = "チップの幅(px)";
            // 
            // ChipWidthBox
            // 
            this.ChipWidthBox.Location = new System.Drawing.Point(688, 20);
            this.ChipWidthBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChipWidthBox.Name = "ChipWidthBox";
            this.ChipWidthBox.ReadOnly = true;
            this.ChipWidthBox.Size = new System.Drawing.Size(88, 23);
            this.ChipWidthBox.TabIndex = 5;
            // 
            // MapHeightLabel
            // 
            this.MapHeightLabel.AutoSize = true;
            this.MapHeightLabel.Location = new System.Drawing.Point(399, 24);
            this.MapHeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MapHeightLabel.Name = "MapHeightLabel";
            this.MapHeightLabel.Size = new System.Drawing.Size(84, 15);
            this.MapHeightLabel.TabIndex = 4;
            this.MapHeightLabel.Text = "マップの高さ(px)";
            // 
            // MapWidthLabel
            // 
            this.MapWidthLabel.AutoSize = true;
            this.MapWidthLabel.Location = new System.Drawing.Point(209, 24);
            this.MapWidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MapWidthLabel.Name = "MapWidthLabel";
            this.MapWidthLabel.Size = new System.Drawing.Size(76, 15);
            this.MapWidthLabel.TabIndex = 3;
            this.MapWidthLabel.Text = "マップの幅(px)";
            // 
            // MapHeightBox
            // 
            this.MapHeightBox.Location = new System.Drawing.Point(497, 20);
            this.MapHeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.MapHeightBox.Name = "MapHeightBox";
            this.MapHeightBox.ReadOnly = true;
            this.MapHeightBox.Size = new System.Drawing.Size(88, 23);
            this.MapHeightBox.TabIndex = 2;
            // 
            // MapWidthBox
            // 
            this.MapWidthBox.Location = new System.Drawing.Point(298, 20);
            this.MapWidthBox.Margin = new System.Windows.Forms.Padding(2);
            this.MapWidthBox.Name = "MapWidthBox";
            this.MapWidthBox.ReadOnly = true;
            this.MapWidthBox.Size = new System.Drawing.Size(88, 23);
            this.MapWidthBox.TabIndex = 1;
            // 
            // MenuStrip
            // 
            this.MenuStrip.AllowMerge = false;
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPanel});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 15);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(153, 29);
            this.MenuStrip.Stretch = false;
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // MenuPanel
            // 
            this.MenuPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeNew,
            this.SaveData,
            this.LoadData,
            this.GenerateCSV});
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(53, 19);
            this.MenuPanel.Text = "ファイル";
            // 
            // MakeNew
            // 
            this.MakeNew.Name = "MakeNew";
            this.MakeNew.Size = new System.Drawing.Size(161, 22);
            this.MakeNew.Text = "新規";
            this.MakeNew.Click += new System.EventHandler(this.OnMakeNewButtonClicked);
            // 
            // SaveData
            // 
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(161, 22);
            this.SaveData.Text = "保存";
            this.SaveData.Click += new System.EventHandler(this.OnSaveFileClicked);
            // 
            // LoadData
            // 
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(161, 22);
            this.LoadData.Text = "読み込み";
            this.LoadData.Click += new System.EventHandler(this.OnLoadFileClicked);
            // 
            // GenerateCSV
            // 
            this.GenerateCSV.Name = "GenerateCSV";
            this.GenerateCSV.Size = new System.Drawing.Size(161, 22);
            this.GenerateCSV.Text = "CSVファイルを出力";
            this.GenerateCSV.Click += new System.EventHandler(this.OnGenerateCsvClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1149, 660);
            this.Controls.Add(this.BottomContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MapMaker";
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
            ((System.ComponentModel.ISupportInitialize)(this.MapPreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapGrid)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer BottomContainer;
        private System.Windows.Forms.SplitContainer TopContainer;
        private System.Windows.Forms.PictureBox ChipSet;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuPanel;
        private System.Windows.Forms.ToolStripMenuItem SaveData;
        private System.Windows.Forms.ToolStripMenuItem LoadData;
        private System.Windows.Forms.ToolStripMenuItem MakeNew;
        private System.Windows.Forms.ToolStripMenuItem GenerateCSV;
        private System.Windows.Forms.Label ChipHeightLabel;
        private System.Windows.Forms.Label ChipWidthLabel;
        private System.Windows.Forms.Label MapHeightLabel;
        private System.Windows.Forms.Label MapWidthLabel;
        public System.Windows.Forms.TextBox ChipHeightBox;
        public System.Windows.Forms.TextBox ChipWidthBox;
        public System.Windows.Forms.TextBox MapHeightBox;
        public System.Windows.Forms.TextBox MapWidthBox;
        public System.Windows.Forms.DataGridView MapGrid;
        private System.Windows.Forms.Label CurrentChipLabel;
        private System.Windows.Forms.TextBox CurrentChip;
        private System.Windows.Forms.CheckBox DoesShowPreview;
        public System.Windows.Forms.PictureBox MapPreviewBox;
    }
}

