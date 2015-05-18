namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CloseButton = new System.Windows.Forms.Button();
            this.channels = new System.Windows.Forms.Label();
            this.YUV_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmy_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imagefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMYKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.custom5x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSLFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RGB_box = new System.Windows.Forms.ComboBox();
            this.effects_box = new System.Windows.Forms.ComboBox();
            this.YUV_box = new System.Windows.Forms.ComboBox();
            this.CMYK_box = new System.Windows.Forms.ComboBox();
            this.undoButton = new System.Windows.Forms.Button();
            this.convolution_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(671, 477);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(101, 33);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.closeButton_action);
            // 
            // channels
            // 
            this.channels.AutoSize = true;
            this.channels.Location = new System.Drawing.Point(669, 81);
            this.channels.Name = "channels";
            this.channels.Size = new System.Drawing.Size(33, 13);
            this.channels.TabIndex = 11;
            this.channels.Text = "RGB:";
            // 
            // YUV_label
            // 
            this.YUV_label.AutoSize = true;
            this.YUV_label.Location = new System.Drawing.Point(668, 130);
            this.YUV_label.Name = "YUV_label";
            this.YUV_label.Size = new System.Drawing.Size(32, 13);
            this.YUV_label.TabIndex = 14;
            this.YUV_label.Text = "YUV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Effects:";
            // 
            // cmy_label
            // 
            this.cmy_label.AutoSize = true;
            this.cmy_label.Location = new System.Drawing.Point(668, 180);
            this.cmy_label.Name = "cmy_label";
            this.cmy_label.Size = new System.Drawing.Size(40, 13);
            this.cmy_label.TabIndex = 20;
            this.cmy_label.Text = "CMYK:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagefileToolStripMenuItem,
            this.effectsToolStripMenuItem,
            this.rGBToolStripMenuItem,
            this.yUVToolStripMenuItem,
            this.cMYKToolStripMenuItem,
            this.convolutionToolStripMenuItem,
            this.hSLFilterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imagefileToolStripMenuItem
            // 
            this.imagefileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeImageToolStripMenuItem,
            this.undoAllChangesToolStripMenuItem});
            this.imagefileToolStripMenuItem.Name = "imagefileToolStripMenuItem";
            this.imagefileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imagefileToolStripMenuItem.Text = "Image";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFile_action);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveFile_action);
            // 
            // closeImageToolStripMenuItem
            // 
            this.closeImageToolStripMenuItem.Name = "closeImageToolStripMenuItem";
            this.closeImageToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.closeImageToolStripMenuItem.Text = "Close image";
            this.closeImageToolStripMenuItem.Click += new System.EventHandler(this.closeImage_action);
            // 
            // undoAllChangesToolStripMenuItem
            // 
            this.undoAllChangesToolStripMenuItem.Name = "undoAllChangesToolStripMenuItem";
            this.undoAllChangesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.undoAllChangesToolStripMenuItem.Text = "Undo all changes";
            this.undoAllChangesToolStripMenuItem.Click += new System.EventHandler(this.undo_action);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.undoAllChangesToolStripMenuItem4});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invert_action);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscale_action);
            // 
            // undoAllChangesToolStripMenuItem4
            // 
            this.undoAllChangesToolStripMenuItem4.Name = "undoAllChangesToolStripMenuItem4";
            this.undoAllChangesToolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
            this.undoAllChangesToolStripMenuItem4.Text = "Undo all changes";
            this.undoAllChangesToolStripMenuItem4.Click += new System.EventHandler(this.undo_action);
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRToolStripMenuItem,
            this.showGToolStripMenuItem,
            this.showBToolStripMenuItem,
            this.undoAllChangesToolStripMenuItem1});
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.rGBToolStripMenuItem.Text = "RGB";
            // 
            // showRToolStripMenuItem
            // 
            this.showRToolStripMenuItem.Name = "showRToolStripMenuItem";
            this.showRToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showRToolStripMenuItem.Text = "Show R";
            this.showRToolStripMenuItem.Click += new System.EventHandler(this.showR_action);
            // 
            // showGToolStripMenuItem
            // 
            this.showGToolStripMenuItem.Name = "showGToolStripMenuItem";
            this.showGToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showGToolStripMenuItem.Text = "Show G";
            this.showGToolStripMenuItem.Click += new System.EventHandler(this.showG_action);
            // 
            // showBToolStripMenuItem
            // 
            this.showBToolStripMenuItem.Name = "showBToolStripMenuItem";
            this.showBToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showBToolStripMenuItem.Text = "Show B";
            this.showBToolStripMenuItem.Click += new System.EventHandler(this.showB_action);
            // 
            // undoAllChangesToolStripMenuItem1
            // 
            this.undoAllChangesToolStripMenuItem1.Name = "undoAllChangesToolStripMenuItem1";
            this.undoAllChangesToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.undoAllChangesToolStripMenuItem1.Text = "Undo all changes";
            this.undoAllChangesToolStripMenuItem1.Click += new System.EventHandler(this.undo_action);
            // 
            // yUVToolStripMenuItem
            // 
            this.yUVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showYToolStripMenuItem,
            this.showUToolStripMenuItem,
            this.showVToolStripMenuItem,
            this.undoAllChangesToolStripMenuItem2});
            this.yUVToolStripMenuItem.Name = "yUVToolStripMenuItem";
            this.yUVToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.yUVToolStripMenuItem.Text = "YUV";
            // 
            // showYToolStripMenuItem
            // 
            this.showYToolStripMenuItem.Name = "showYToolStripMenuItem";
            this.showYToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showYToolStripMenuItem.Text = "Show Y";
            this.showYToolStripMenuItem.Click += new System.EventHandler(this.showY_action);
            // 
            // showUToolStripMenuItem
            // 
            this.showUToolStripMenuItem.Name = "showUToolStripMenuItem";
            this.showUToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showUToolStripMenuItem.Text = "Show U";
            this.showUToolStripMenuItem.Click += new System.EventHandler(this.showU_action);
            // 
            // showVToolStripMenuItem
            // 
            this.showVToolStripMenuItem.Name = "showVToolStripMenuItem";
            this.showVToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showVToolStripMenuItem.Text = "Show V";
            this.showVToolStripMenuItem.Click += new System.EventHandler(this.showV_action);
            // 
            // undoAllChangesToolStripMenuItem2
            // 
            this.undoAllChangesToolStripMenuItem2.Name = "undoAllChangesToolStripMenuItem2";
            this.undoAllChangesToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.undoAllChangesToolStripMenuItem2.Text = "Undo all changes";
            this.undoAllChangesToolStripMenuItem2.Click += new System.EventHandler(this.undo_action);
            // 
            // cMYKToolStripMenuItem
            // 
            this.cMYKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCToolStripMenuItem,
            this.showMToolStripMenuItem,
            this.showYToolStripMenuItem1,
            this.showKToolStripMenuItem,
            this.undoAllChangesToolStripMenuItem3});
            this.cMYKToolStripMenuItem.Name = "cMYKToolStripMenuItem";
            this.cMYKToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.cMYKToolStripMenuItem.Text = "CMYK";
            // 
            // showCToolStripMenuItem
            // 
            this.showCToolStripMenuItem.Name = "showCToolStripMenuItem";
            this.showCToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showCToolStripMenuItem.Text = "Show C";
            this.showCToolStripMenuItem.Click += new System.EventHandler(this.showC_action);
            // 
            // showMToolStripMenuItem
            // 
            this.showMToolStripMenuItem.Name = "showMToolStripMenuItem";
            this.showMToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showMToolStripMenuItem.Text = "Show M";
            this.showMToolStripMenuItem.Click += new System.EventHandler(this.showM_action);
            // 
            // showYToolStripMenuItem1
            // 
            this.showYToolStripMenuItem1.Name = "showYToolStripMenuItem1";
            this.showYToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.showYToolStripMenuItem1.Text = "Show Y";
            this.showYToolStripMenuItem1.Click += new System.EventHandler(this.showYellow_action);
            // 
            // showKToolStripMenuItem
            // 
            this.showKToolStripMenuItem.Name = "showKToolStripMenuItem";
            this.showKToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showKToolStripMenuItem.Text = "Show K";
            this.showKToolStripMenuItem.Click += new System.EventHandler(this.showK_action);
            // 
            // undoAllChangesToolStripMenuItem3
            // 
            this.undoAllChangesToolStripMenuItem3.Name = "undoAllChangesToolStripMenuItem3";
            this.undoAllChangesToolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.undoAllChangesToolStripMenuItem3.Text = "Undo all changes";
            this.undoAllChangesToolStripMenuItem3.Click += new System.EventHandler(this.undo_action);
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.customToolStripMenuItem1,
            this.custom5x5ToolStripMenuItem,
            this.undoChangesToolStripMenuItem});
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.convolutionToolStripMenuItem.Text = "Convolution filters";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blur_action);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gausianBlur_action);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpen_action);
            // 
            // customToolStripMenuItem1
            // 
            this.customToolStripMenuItem1.Name = "customToolStripMenuItem1";
            this.customToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.customToolStripMenuItem1.Text = "Custom 3x3";
            this.customToolStripMenuItem1.Click += new System.EventHandler(this.customConvolutionFilter3x3_action);
            // 
            // custom5x5ToolStripMenuItem
            // 
            this.custom5x5ToolStripMenuItem.Name = "custom5x5ToolStripMenuItem";
            this.custom5x5ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.custom5x5ToolStripMenuItem.Text = "Custom 5x5";
            this.custom5x5ToolStripMenuItem.Click += new System.EventHandler(this.customConvolutionFilter5x5_action);
            // 
            // undoChangesToolStripMenuItem
            // 
            this.undoChangesToolStripMenuItem.Name = "undoChangesToolStripMenuItem";
            this.undoChangesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.undoChangesToolStripMenuItem.Text = "Undo changes";
            this.undoChangesToolStripMenuItem.Click += new System.EventHandler(this.undo_action);
            // 
            // hSLFilterToolStripMenuItem
            // 
            this.hSLFilterToolStripMenuItem.Name = "hSLFilterToolStripMenuItem";
            this.hSLFilterToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.hSLFilterToolStripMenuItem.Text = "HSL filter";
            this.hSLFilterToolStripMenuItem.Click += new System.EventHandler(this.HSLfilter_action);
            // 
            // RGB_box
            // 
            this.RGB_box.FormattingEnabled = true;
            this.RGB_box.Items.AddRange(new object[] {
            "Show R",
            "Show G",
            "Show B"});
            this.RGB_box.Location = new System.Drawing.Point(672, 97);
            this.RGB_box.Name = "RGB_box";
            this.RGB_box.Size = new System.Drawing.Size(100, 21);
            this.RGB_box.TabIndex = 26;
            this.RGB_box.Text = "Choose";
            this.RGB_box.SelectedIndexChanged += new System.EventHandler(this.RGB_box_SelectedIndexChanged);
            // 
            // effects_box
            // 
            this.effects_box.FormattingEnabled = true;
            this.effects_box.Items.AddRange(new object[] {
            "Invert",
            "Grayscale"});
            this.effects_box.Location = new System.Drawing.Point(672, 47);
            this.effects_box.Name = "effects_box";
            this.effects_box.Size = new System.Drawing.Size(100, 21);
            this.effects_box.TabIndex = 27;
            this.effects_box.Text = "Choose";
            this.effects_box.SelectedIndexChanged += new System.EventHandler(this.effects_box_SelectedIndexChanged);
            // 
            // YUV_box
            // 
            this.YUV_box.FormattingEnabled = true;
            this.YUV_box.Items.AddRange(new object[] {
            "Show Y",
            "Show U",
            "Show V"});
            this.YUV_box.Location = new System.Drawing.Point(672, 146);
            this.YUV_box.Name = "YUV_box";
            this.YUV_box.Size = new System.Drawing.Size(100, 21);
            this.YUV_box.TabIndex = 28;
            this.YUV_box.Text = "Choose";
            this.YUV_box.SelectedIndexChanged += new System.EventHandler(this.YUV_box_SelectedIndexChanged);
            // 
            // CMYK_box
            // 
            this.CMYK_box.FormattingEnabled = true;
            this.CMYK_box.Items.AddRange(new object[] {
            "Show C",
            "Show M",
            "Show Y",
            "Show K"});
            this.CMYK_box.Location = new System.Drawing.Point(672, 196);
            this.CMYK_box.Name = "CMYK_box";
            this.CMYK_box.Size = new System.Drawing.Size(100, 21);
            this.CMYK_box.TabIndex = 29;
            this.CMYK_box.Text = "Choose";
            this.CMYK_box.SelectedIndexChanged += new System.EventHandler(this.CMYK_box_SelectedIndexChanged);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(672, 428);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(101, 33);
            this.undoButton.TabIndex = 30;
            this.undoButton.Text = "Undo changes";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undo_action);
            // 
            // convolution_box
            // 
            this.convolution_box.FormattingEnabled = true;
            this.convolution_box.Items.AddRange(new object[] {
            "Blur",
            "Gaussian Blur",
            "Sharpen",
            "Custom 3x3",
            "Custom 5x5"});
            this.convolution_box.Location = new System.Drawing.Point(672, 247);
            this.convolution_box.Name = "convolution_box";
            this.convolution_box.Size = new System.Drawing.Size(100, 21);
            this.convolution_box.TabIndex = 32;
            this.convolution_box.Text = "Choose";
            this.convolution_box.SelectedIndexChanged += new System.EventHandler(this.Convolution_box_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Convolution:";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(12, 27);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(644, 485);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.openFile_action);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "HSL filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HSLfilter_action);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 34;
            this.button2.Text = "Brightness histogram";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.brightnessHistogram);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.convolution_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.CMYK_box);
            this.Controls.Add(this.YUV_box);
            this.Controls.Add(this.effects_box);
            this.Controls.Add(this.RGB_box);
            this.Controls.Add(this.cmy_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YUV_label);
            this.Controls.Add(this.channels);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Simple Image Processing - author: Dawid Samołyk";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label channels;
        private System.Windows.Forms.Label YUV_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmy_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yUVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMYKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem4;
        private System.Windows.Forms.ComboBox RGB_box;
        private System.Windows.Forms.ComboBox effects_box;
        private System.Windows.Forms.ComboBox YUV_box;
        private System.Windows.Forms.ComboBox CMYK_box;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.ToolStripMenuItem closeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ComboBox convolution_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custom5x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSLFilterToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

