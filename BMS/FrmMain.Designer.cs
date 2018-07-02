namespace BMS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ToolShow = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolShow
            // 
            this.ToolShow.Arrow = System.Drawing.Color.Black;
            this.ToolShow.AutoSize = false;
            this.ToolShow.Back = System.Drawing.Color.White;
            this.ToolShow.BackRadius = 4;
            this.ToolShow.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.ToolShow.Base = System.Drawing.Color.Transparent;
            this.ToolShow.BaseFore = System.Drawing.Color.Black;
            this.ToolShow.BaseForeAnamorphosis = false;
            this.ToolShow.BaseForeAnamorphosisBorder = 4;
            this.ToolShow.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.ToolShow.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.ToolShow.BaseHoverFore = System.Drawing.Color.White;
            this.ToolShow.BaseItemAnamorphosis = true;
            this.ToolShow.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemBorderShow = true;
            this.ToolShow.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("ToolShow.BaseItemDown")));
            this.ToolShow.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("ToolShow.BaseItemMouse")));
            this.ToolShow.BaseItemNorml = null;
            this.ToolShow.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemRadius = 4;
            this.ToolShow.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.ToolShow.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BindTabControl = null;
            this.ToolShow.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolShow.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ToolShow.Fore = System.Drawing.Color.Black;
            this.ToolShow.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.ToolShow.HoverFore = System.Drawing.Color.White;
            this.ToolShow.ItemAnamorphosis = true;
            this.ToolShow.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemBorderShow = true;
            this.ToolShow.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemRadius = 4;
            this.ToolShow.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.ToolShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.ToolShow.Location = new System.Drawing.Point(7, 28);
            this.ToolShow.Name = "ToolShow";
            this.ToolShow.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.ToolShow.Size = new System.Drawing.Size(541, 52);
            this.ToolShow.SkinAllColor = true;
            this.ToolShow.TabIndex = 1;
            this.ToolShow.Text = "skinToolStrip1";
            this.ToolShow.TitleAnamorphosis = true;
            this.ToolShow.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ToolShow.TitleRadius = 4;
            this.ToolShow.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 49);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 49);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 342);
            this.Controls.Add(this.ToolShow);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ToolShow.ResumeLayout(false);
            this.ToolShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinToolStrip ToolShow;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}