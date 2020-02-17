namespace ExploreFile
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileexplorerview = new System.Windows.Forms.ListView();
            this.viewscreencontmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewscreencontmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileexplorerview
            // 
            this.fileexplorerview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileexplorerview.ContextMenuStrip = this.viewscreencontmenu;
            this.fileexplorerview.HideSelection = false;
            this.fileexplorerview.LargeImageList = this.iconList;
            this.fileexplorerview.Location = new System.Drawing.Point(3, 12);
            this.fileexplorerview.Name = "fileexplorerview";
            this.fileexplorerview.Size = new System.Drawing.Size(697, 369);
            this.fileexplorerview.SmallImageList = this.iconList;
            this.fileexplorerview.TabIndex = 2;
            this.fileexplorerview.UseCompatibleStateImageBehavior = false;
            this.fileexplorerview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fileexplorerview_ItemSelectionChanged);
            this.fileexplorerview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileexplorerview_MouseDoubleClick);
            // 
            // viewscreencontmenu
            // 
            this.viewscreencontmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.tilesToolStripMenuItem});
            this.viewscreencontmenu.Name = "viewscreencontmenu";
            this.viewscreencontmenu.Size = new System.Drawing.Size(104, 70);
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            this.tilesToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.tilesToolStripMenuItem.Text = "Tiles";
            this.tilesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "001-xlsx-1.png");
            this.iconList.Images.SetKeyName(1, "002-xlsx.png");
            this.iconList.Images.SetKeyName(2, "003-xls-1.png");
            this.iconList.Images.SetKeyName(3, "004-xls.png");
            this.iconList.Images.SetKeyName(4, "005-xd.png");
            this.iconList.Images.SetKeyName(5, "006-wmv.png");
            this.iconList.Images.SetKeyName(6, "007-wma-1.png");
            this.iconList.Images.SetKeyName(7, "008-wma.png");
            this.iconList.Images.SetKeyName(8, "009-wav-3.png");
            this.iconList.Images.SetKeyName(9, "010-wav-2.png");
            this.iconList.Images.SetKeyName(10, "011-wav-1.png");
            this.iconList.Images.SetKeyName(11, "012-wav.png");
            this.iconList.Images.SetKeyName(12, "013-txt-1.png");
            this.iconList.Images.SetKeyName(13, "014-txt.png");
            this.iconList.Images.SetKeyName(14, "015-tiff-1.png");
            this.iconList.Images.SetKeyName(15, "016-tiff.png");
            this.iconList.Images.SetKeyName(16, "017-swf-1.png");
            this.iconList.Images.SetKeyName(17, "018-swf.png");
            this.iconList.Images.SetKeyName(18, "019-svg-1.png");
            this.iconList.Images.SetKeyName(19, "020-svg.png");
            this.iconList.Images.SetKeyName(20, "021-sesx-1.png");
            this.iconList.Images.SetKeyName(21, "022-sesx.png");
            this.iconList.Images.SetKeyName(22, "023-raw-1.png");
            this.iconList.Images.SetKeyName(23, "024-raw.png");
            this.iconList.Images.SetKeyName(24, "025-psd-1.png");
            this.iconList.Images.SetKeyName(25, "026-psd.png");
            this.iconList.Images.SetKeyName(26, "027-psb-1.png");
            this.iconList.Images.SetKeyName(27, "028-psb.png");
            this.iconList.Images.SetKeyName(28, "029-pptx-1.png");
            this.iconList.Images.SetKeyName(29, "030-pptx.png");
            this.iconList.Images.SetKeyName(30, "031-ppt-1.png");
            this.iconList.Images.SetKeyName(31, "032-ppt.png");
            this.iconList.Images.SetKeyName(32, "033-png-1.png");
            this.iconList.Images.SetKeyName(33, "034-png.png");
            this.iconList.Images.SetKeyName(34, "035-pdf-1.png");
            this.iconList.Images.SetKeyName(35, "036-pdf.png");
            this.iconList.Images.SetKeyName(36, "037-pcx-1.png");
            this.iconList.Images.SetKeyName(37, "038-pcx.png");
            this.iconList.Images.SetKeyName(38, "039-ogg-1.png");
            this.iconList.Images.SetKeyName(39, "040-ogg.png");
            this.iconList.Images.SetKeyName(40, "041-odt-1.png");
            this.iconList.Images.SetKeyName(41, "042-odt.png");
            this.iconList.Images.SetKeyName(42, "043-odp-1.png");
            this.iconList.Images.SetKeyName(43, "044-odp.png");
            this.iconList.Images.SetKeyName(44, "045-muse-1.png");
            this.iconList.Images.SetKeyName(45, "046-muse.png");
            this.iconList.Images.SetKeyName(46, "047-mpg-1.png");
            this.iconList.Images.SetKeyName(47, "048-mpg.png");
            this.iconList.Images.SetKeyName(48, "049-mpeg-1.png");
            this.iconList.Images.SetKeyName(49, "050-mpeg.png");
            this.iconList.Images.SetKeyName(50, "051-m4v-2.png");
            this.iconList.Images.SetKeyName(51, "052-mp4.png");
            this.iconList.Images.SetKeyName(52, "053-mp3-1.png");
            this.iconList.Images.SetKeyName(53, "054-mp3.png");
            this.iconList.Images.SetKeyName(54, "055-mov-1.png");
            this.iconList.Images.SetKeyName(55, "056-mov.png");
            this.iconList.Images.SetKeyName(56, "057-mkv-1.png");
            this.iconList.Images.SetKeyName(57, "058-mkv.png");
            this.iconList.Images.SetKeyName(58, "059-m4v-1.png");
            this.iconList.Images.SetKeyName(59, "060-m4v.png");
            this.iconList.Images.SetKeyName(60, "061-m4a-1.png");
            this.iconList.Images.SetKeyName(61, "062-m4a.png");
            this.iconList.Images.SetKeyName(62, "063-jpg-1.png");
            this.iconList.Images.SetKeyName(63, "064-jpg.png");
            this.iconList.Images.SetKeyName(64, "065-indd-1.png");
            this.iconList.Images.SetKeyName(65, "066-indd.png");
            this.iconList.Images.SetKeyName(66, "067-gif-1.png");
            this.iconList.Images.SetKeyName(67, "068-gif.png");
            this.iconList.Images.SetKeyName(68, "069-flv-1.png");
            this.iconList.Images.SetKeyName(69, "070-flv.png");
            this.iconList.Images.SetKeyName(70, "071-flac-1.png");
            this.iconList.Images.SetKeyName(71, "072-flac.png");
            this.iconList.Images.SetKeyName(72, "073-eps-1.png");
            this.iconList.Images.SetKeyName(73, "074-eps.png");
            this.iconList.Images.SetKeyName(74, "075-edge-1.png");
            this.iconList.Images.SetKeyName(75, "076-edge.png");
            this.iconList.Images.SetKeyName(76, "077-docx-1.png");
            this.iconList.Images.SetKeyName(77, "078-docx.png");
            this.iconList.Images.SetKeyName(78, "079-doc-1.png");
            this.iconList.Images.SetKeyName(79, "080-doc.png");
            this.iconList.Images.SetKeyName(80, "081-bmp-1.png");
            this.iconList.Images.SetKeyName(81, "082-bmp.png");
            this.iconList.Images.SetKeyName(82, "083-avi-1.png");
            this.iconList.Images.SetKeyName(83, "084-avi.png");
            this.iconList.Images.SetKeyName(84, "085-ape-1.png");
            this.iconList.Images.SetKeyName(85, "086-ape.png");
            this.iconList.Images.SetKeyName(86, "087-alac-1.png");
            this.iconList.Images.SetKeyName(87, "088-alac.png");
            this.iconList.Images.SetKeyName(88, "089-aiff-1.png");
            this.iconList.Images.SetKeyName(89, "090-aiff.png");
            this.iconList.Images.SetKeyName(90, "091-ai-1.png");
            this.iconList.Images.SetKeyName(91, "092-ai.png");
            this.iconList.Images.SetKeyName(92, "093-aepx-1.png");
            this.iconList.Images.SetKeyName(93, "094-aepx.png");
            this.iconList.Images.SetKeyName(94, "095-aep-1.png");
            this.iconList.Images.SetKeyName(95, "096-aep.png");
            this.iconList.Images.SetKeyName(96, "097-aac-1.png");
            this.iconList.Images.SetKeyName(97, "098-aac.png");
            this.iconList.Images.SetKeyName(98, "099-3gpp-1.png");
            this.iconList.Images.SetKeyName(99, "100-3gpp.png");
            this.iconList.Images.SetKeyName(100, "unknown.png");
            this.iconList.Images.SetKeyName(101, "folder.png");
            this.iconList.Images.SetKeyName(102, "rarzip.png");
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(72, 419);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(13, 13);
            this.fileTypeLabel.TabIndex = 11;
            this.fileTypeLabel.Text = "--";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File type";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(72, 387);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(13, 13);
            this.fileNameLabel.TabIndex = 9;
            this.fileNameLabel.Text = "--";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileexplorerview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ExploreFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.viewscreencontmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView fileexplorerview;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip viewscreencontmenu;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.ImageList iconList;
    }
}

