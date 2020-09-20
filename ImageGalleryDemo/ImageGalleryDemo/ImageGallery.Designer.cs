using C1.C1Pdf;


namespace ImageGalleryDemo
{
    partial class ImageGallery
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
        private void Display()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this._exportImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).BeginInit();
            this.SuspendLayout();


            // splitContainer1 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.SplitterDistance = 40;


            // splitContainer1.Panel1 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);


            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this._exportImage);
            this.splitContainer1.Panel2.Controls.Add(this._imageTileControl);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);


            // tableLayoutPanel1
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 45);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);


            // panel1
            this.panel1.Controls.Add(this._searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(477, 0);
            this.panel1.Size = new System.Drawing.Size(287, 40);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);


            // _searchBox 
            this._searchBox.Location = new System.Drawing.Point(16, 9);
            this._searchBox.Height = 16;
            this._searchBox.Width = 270;
            this._searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._searchBox.Text = "Search Image";


            // panel2
            this.panel2.Location = new System.Drawing.Point(479, 12);
            this.panel2.Size = new System.Drawing.Size(40, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 15, 45, 12);
            this.panel2.TabIndex = 1;
            this.panel2.Controls.Add(this._search);


            // _search
            string s = System.IO.Directory.GetCurrentDirectory();
            this._search.Image = System.Drawing.Image.FromFile(s + @"\Data\search.png");
            this._search.Dock = System.Windows.Forms.DockStyle.Left;
            this._search.Location = new System.Drawing.Point(0, 0);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(40, 16);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.Click += new System.EventHandler(this._search_Click);


            // _exportImage
            this._exportImage.Image = System.Drawing.Image.FromFile(s + @"\Data\exportImage.PNG");
            this._exportImage.Location = new System.Drawing.Point(29, 3);
            this._exportImage.Size = new System.Drawing.Size(135, 28);
            this._exportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._exportImage.TabIndex = 0;
            this._exportImage.Visible = false;
            this._exportImage.Click += new System.EventHandler(this._exportImage_Click);
            this._exportImage.Paint += new System.Windows.Forms.PaintEventHandler(this._exportImage_Paint);


            // _imageTileControl
            this._imageTileControl.TabIndex = 2;
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            this._imageTileControl.CellWidth = 78;

            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            this._imageTileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageTileControl.Orientation = C1.Win.C1Tile.LayoutOrientation.Vertical;
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.Size = new System.Drawing.Size(764, 718);
            this._imageTileControl.SurfacePadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 20;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileChecked_1);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileUnchecked_1);
            this._imageTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this._imageTileControl_Paint);


            // statusStrip1
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Size = new System.Drawing.Size(762, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;


            // toolStripProgressBar1
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;


            // ImageGallery
            this.Size = new System.Drawing.Size(780, 800);
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.MaximizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery";
            this.Controls.Add(this.splitContainer1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _searchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox _search;
        private System.Windows.Forms.PictureBox _exportImage;
        private C1.Win.C1Tile.C1TileControl _imageTileControl;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private C1.Win.C1Tile.Tile tile2;
        private C1.Win.C1Tile.Tile tile3;
        private C1PdfDocument c1PdfDocument1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

