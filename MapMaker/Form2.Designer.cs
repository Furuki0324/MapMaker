
namespace MapMaker
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChipWidth = new System.Windows.Forms.NumericUpDown();
            this.OkButton = new System.Windows.Forms.Button();
            this.MapSizeGroup = new System.Windows.Forms.GroupBox();
            this.ChipSizeGroup = new System.Windows.Forms.GroupBox();
            this.ChipWidthLabel = new System.Windows.Forms.Label();
            this.ChipHeightLabel = new System.Windows.Forms.Label();
            this.ChipHeight = new System.Windows.Forms.NumericUpDown();
            this.MapHeightLabel = new System.Windows.Forms.Label();
            this.MapHeight = new System.Windows.Forms.NumericUpDown();
            this.MapWidthLabel = new System.Windows.Forms.Label();
            this.MapWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ChipWidth)).BeginInit();
            this.MapSizeGroup.SuspendLayout();
            this.ChipSizeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChipHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // ChipWidth
            // 
            this.ChipWidth.Location = new System.Drawing.Point(85, 30);
            this.ChipWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ChipWidth.Name = "ChipWidth";
            this.ChipWidth.Size = new System.Drawing.Size(100, 19);
            this.ChipWidth.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(197, 226);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "決定";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnOkButtonClicked);
            // 
            // MapSizeGroup
            // 
            this.MapSizeGroup.Controls.Add(this.MapHeightLabel);
            this.MapSizeGroup.Controls.Add(this.MapWidthLabel);
            this.MapSizeGroup.Controls.Add(this.MapHeight);
            this.MapSizeGroup.Controls.Add(this.MapWidth);
            this.MapSizeGroup.Location = new System.Drawing.Point(25, 12);
            this.MapSizeGroup.Name = "MapSizeGroup";
            this.MapSizeGroup.Size = new System.Drawing.Size(200, 100);
            this.MapSizeGroup.TabIndex = 2;
            this.MapSizeGroup.TabStop = false;
            this.MapSizeGroup.Text = "マップサイズ";
            // 
            // ChipSizeGroup
            // 
            this.ChipSizeGroup.Controls.Add(this.ChipHeightLabel);
            this.ChipSizeGroup.Controls.Add(this.ChipHeight);
            this.ChipSizeGroup.Controls.Add(this.ChipWidthLabel);
            this.ChipSizeGroup.Controls.Add(this.ChipWidth);
            this.ChipSizeGroup.Location = new System.Drawing.Point(25, 120);
            this.ChipSizeGroup.Name = "ChipSizeGroup";
            this.ChipSizeGroup.Size = new System.Drawing.Size(200, 100);
            this.ChipSizeGroup.TabIndex = 3;
            this.ChipSizeGroup.TabStop = false;
            this.ChipSizeGroup.Text = "チップサイズ";
            // 
            // ChipWidthLabel
            // 
            this.ChipWidthLabel.AutoSize = true;
            this.ChipWidthLabel.Location = new System.Drawing.Point(18, 32);
            this.ChipWidthLabel.Name = "ChipWidthLabel";
            this.ChipWidthLabel.Size = new System.Drawing.Size(37, 12);
            this.ChipWidthLabel.TabIndex = 1;
            this.ChipWidthLabel.Text = "幅(px)";
            // 
            // ChipHeightLabel
            // 
            this.ChipHeightLabel.AutoSize = true;
            this.ChipHeightLabel.Location = new System.Drawing.Point(18, 66);
            this.ChipHeightLabel.Name = "ChipHeightLabel";
            this.ChipHeightLabel.Size = new System.Drawing.Size(45, 12);
            this.ChipHeightLabel.TabIndex = 3;
            this.ChipHeightLabel.Text = "高さ(px)";
            // 
            // ChipHeight
            // 
            this.ChipHeight.Location = new System.Drawing.Point(85, 64);
            this.ChipHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ChipHeight.Name = "ChipHeight";
            this.ChipHeight.Size = new System.Drawing.Size(100, 19);
            this.ChipHeight.TabIndex = 2;
            // 
            // MapHeightLabel
            // 
            this.MapHeightLabel.AutoSize = true;
            this.MapHeightLabel.Location = new System.Drawing.Point(18, 61);
            this.MapHeightLabel.Name = "MapHeightLabel";
            this.MapHeightLabel.Size = new System.Drawing.Size(45, 12);
            this.MapHeightLabel.TabIndex = 7;
            this.MapHeightLabel.Text = "高さ(px)";
            // 
            // MapHeight
            // 
            this.MapHeight.Location = new System.Drawing.Point(85, 59);
            this.MapHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MapHeight.Name = "MapHeight";
            this.MapHeight.Size = new System.Drawing.Size(100, 19);
            this.MapHeight.TabIndex = 6;
            // 
            // MapWidthLabel
            // 
            this.MapWidthLabel.AutoSize = true;
            this.MapWidthLabel.Location = new System.Drawing.Point(18, 27);
            this.MapWidthLabel.Name = "MapWidthLabel";
            this.MapWidthLabel.Size = new System.Drawing.Size(37, 12);
            this.MapWidthLabel.TabIndex = 5;
            this.MapWidthLabel.Text = "幅(px)";
            // 
            // MapWidth
            // 
            this.MapWidth.Location = new System.Drawing.Point(85, 25);
            this.MapWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MapWidth.Name = "MapWidth";
            this.MapWidth.Size = new System.Drawing.Size(100, 19);
            this.MapWidth.TabIndex = 4;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ChipSizeGroup);
            this.Controls.Add(this.MapSizeGroup);
            this.Controls.Add(this.OkButton);
            this.Name = "SettingForm";
            this.Text = "マップサイズの変更";
            ((System.ComponentModel.ISupportInitialize)(this.ChipWidth)).EndInit();
            this.MapSizeGroup.ResumeLayout(false);
            this.MapSizeGroup.PerformLayout();
            this.ChipSizeGroup.ResumeLayout(false);
            this.ChipSizeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChipHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ChipWidth;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox MapSizeGroup;
        private System.Windows.Forms.Label MapHeightLabel;
        private System.Windows.Forms.Label MapWidthLabel;
        private System.Windows.Forms.NumericUpDown MapHeight;
        private System.Windows.Forms.NumericUpDown MapWidth;
        private System.Windows.Forms.GroupBox ChipSizeGroup;
        private System.Windows.Forms.Label ChipHeightLabel;
        private System.Windows.Forms.NumericUpDown ChipHeight;
        private System.Windows.Forms.Label ChipWidthLabel;
    }
}