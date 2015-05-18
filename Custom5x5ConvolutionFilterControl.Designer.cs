namespace WindowsFormsApplication1
{
    partial class Custom5x5ConvolutionFilterControl
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
            this.close_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Factor_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._2x2_textBox = new System.Windows.Forms.TextBox();
            this._2x1_textBox = new System.Windows.Forms.TextBox();
            this._2x0_textBox = new System.Windows.Forms.TextBox();
            this._1x2_textBox = new System.Windows.Forms.TextBox();
            this._1x1_textBox = new System.Windows.Forms.TextBox();
            this._1x0_textBox = new System.Windows.Forms.TextBox();
            this._0x2_textBox = new System.Windows.Forms.TextBox();
            this._0x1_textBox = new System.Windows.Forms.TextBox();
            this._0x0_textBox = new System.Windows.Forms.TextBox();
            this._0x3_textBox = new System.Windows.Forms.TextBox();
            this._1x3_textBox = new System.Windows.Forms.TextBox();
            this._2x3_textBox = new System.Windows.Forms.TextBox();
            this._0x4_textBox = new System.Windows.Forms.TextBox();
            this._1x4_textBox = new System.Windows.Forms.TextBox();
            this._2x4_textBox = new System.Windows.Forms.TextBox();
            this._4x4_textBox = new System.Windows.Forms.TextBox();
            this._3x4_textBox = new System.Windows.Forms.TextBox();
            this._4x3_textBox = new System.Windows.Forms.TextBox();
            this._3x3_textBox = new System.Windows.Forms.TextBox();
            this._4x2_textBox = new System.Windows.Forms.TextBox();
            this._4x1_textBox = new System.Windows.Forms.TextBox();
            this._4x0_textBox = new System.Windows.Forms.TextBox();
            this._3x2_textBox = new System.Windows.Forms.TextBox();
            this._3x1_textBox = new System.Windows.Forms.TextBox();
            this._3x0_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(136, 194);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(101, 25);
            this.close_button.TabIndex = 27;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_action);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter factor value";
            // 
            // Factor_textBox
            // 
            this.Factor_textBox.Location = new System.Drawing.Point(8, 168);
            this.Factor_textBox.Name = "Factor_textBox";
            this.Factor_textBox.Size = new System.Drawing.Size(89, 20);
            this.Factor_textBox.TabIndex = 25;
            this.Factor_textBox.Text = "1";
            this.Factor_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 24;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.set_action);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter Convolution matrix values";
            // 
            // _2x2_textBox
            // 
            this._2x2_textBox.Location = new System.Drawing.Point(104, 74);
            this._2x2_textBox.Name = "_2x2_textBox";
            this._2x2_textBox.Size = new System.Drawing.Size(42, 20);
            this._2x2_textBox.TabIndex = 22;
            this._2x2_textBox.Text = "0";
            this._2x2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _2x1_textBox
            // 
            this._2x1_textBox.Location = new System.Drawing.Point(56, 74);
            this._2x1_textBox.Name = "_2x1_textBox";
            this._2x1_textBox.Size = new System.Drawing.Size(42, 20);
            this._2x1_textBox.TabIndex = 21;
            this._2x1_textBox.Text = "0";
            this._2x1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _2x0_textBox
            // 
            this._2x0_textBox.Location = new System.Drawing.Point(8, 74);
            this._2x0_textBox.Name = "_2x0_textBox";
            this._2x0_textBox.Size = new System.Drawing.Size(42, 20);
            this._2x0_textBox.TabIndex = 20;
            this._2x0_textBox.Text = "0";
            this._2x0_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _1x2_textBox
            // 
            this._1x2_textBox.Location = new System.Drawing.Point(104, 48);
            this._1x2_textBox.Name = "_1x2_textBox";
            this._1x2_textBox.Size = new System.Drawing.Size(42, 20);
            this._1x2_textBox.TabIndex = 19;
            this._1x2_textBox.Text = "0";
            this._1x2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _1x1_textBox
            // 
            this._1x1_textBox.Location = new System.Drawing.Point(56, 48);
            this._1x1_textBox.Name = "_1x1_textBox";
            this._1x1_textBox.Size = new System.Drawing.Size(42, 20);
            this._1x1_textBox.TabIndex = 18;
            this._1x1_textBox.Text = "0";
            this._1x1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _1x0_textBox
            // 
            this._1x0_textBox.Location = new System.Drawing.Point(8, 48);
            this._1x0_textBox.Name = "_1x0_textBox";
            this._1x0_textBox.Size = new System.Drawing.Size(42, 20);
            this._1x0_textBox.TabIndex = 17;
            this._1x0_textBox.Text = "0";
            this._1x0_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _0x2_textBox
            // 
            this._0x2_textBox.Location = new System.Drawing.Point(104, 22);
            this._0x2_textBox.Name = "_0x2_textBox";
            this._0x2_textBox.Size = new System.Drawing.Size(42, 20);
            this._0x2_textBox.TabIndex = 16;
            this._0x2_textBox.Text = "0";
            this._0x2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _0x1_textBox
            // 
            this._0x1_textBox.Location = new System.Drawing.Point(56, 22);
            this._0x1_textBox.Name = "_0x1_textBox";
            this._0x1_textBox.Size = new System.Drawing.Size(42, 20);
            this._0x1_textBox.TabIndex = 15;
            this._0x1_textBox.Text = "0";
            this._0x1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _0x0_textBox
            // 
            this._0x0_textBox.Location = new System.Drawing.Point(8, 22);
            this._0x0_textBox.Name = "_0x0_textBox";
            this._0x0_textBox.Size = new System.Drawing.Size(42, 20);
            this._0x0_textBox.TabIndex = 14;
            this._0x0_textBox.Text = "0";
            this._0x0_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _0x3_textBox
            // 
            this._0x3_textBox.Location = new System.Drawing.Point(152, 22);
            this._0x3_textBox.Name = "_0x3_textBox";
            this._0x3_textBox.Size = new System.Drawing.Size(42, 20);
            this._0x3_textBox.TabIndex = 28;
            this._0x3_textBox.Text = "0";
            this._0x3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _1x3_textBox
            // 
            this._1x3_textBox.Location = new System.Drawing.Point(152, 48);
            this._1x3_textBox.Name = "_1x3_textBox";
            this._1x3_textBox.Size = new System.Drawing.Size(42, 20);
            this._1x3_textBox.TabIndex = 29;
            this._1x3_textBox.Text = "0";
            this._1x3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _2x3_textBox
            // 
            this._2x3_textBox.Location = new System.Drawing.Point(152, 74);
            this._2x3_textBox.Name = "_2x3_textBox";
            this._2x3_textBox.Size = new System.Drawing.Size(42, 20);
            this._2x3_textBox.TabIndex = 30;
            this._2x3_textBox.Text = "0";
            this._2x3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _0x4_textBox
            // 
            this._0x4_textBox.Location = new System.Drawing.Point(200, 22);
            this._0x4_textBox.Name = "_0x4_textBox";
            this._0x4_textBox.Size = new System.Drawing.Size(42, 20);
            this._0x4_textBox.TabIndex = 31;
            this._0x4_textBox.Text = "0";
            this._0x4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _1x4_textBox
            // 
            this._1x4_textBox.Location = new System.Drawing.Point(200, 48);
            this._1x4_textBox.Name = "_1x4_textBox";
            this._1x4_textBox.Size = new System.Drawing.Size(42, 20);
            this._1x4_textBox.TabIndex = 32;
            this._1x4_textBox.Text = "0";
            this._1x4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _2x4_textBox
            // 
            this._2x4_textBox.Location = new System.Drawing.Point(200, 74);
            this._2x4_textBox.Name = "_2x4_textBox";
            this._2x4_textBox.Size = new System.Drawing.Size(42, 20);
            this._2x4_textBox.TabIndex = 33;
            this._2x4_textBox.Text = "0";
            this._2x4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _4x4_textBox
            // 
            this._4x4_textBox.Location = new System.Drawing.Point(200, 126);
            this._4x4_textBox.Name = "_4x4_textBox";
            this._4x4_textBox.Size = new System.Drawing.Size(42, 20);
            this._4x4_textBox.TabIndex = 43;
            this._4x4_textBox.Text = "0";
            this._4x4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _3x4_textBox
            // 
            this._3x4_textBox.Location = new System.Drawing.Point(200, 100);
            this._3x4_textBox.Name = "_3x4_textBox";
            this._3x4_textBox.Size = new System.Drawing.Size(42, 20);
            this._3x4_textBox.TabIndex = 42;
            this._3x4_textBox.Text = "0";
            this._3x4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _4x3_textBox
            // 
            this._4x3_textBox.Location = new System.Drawing.Point(152, 126);
            this._4x3_textBox.Name = "_4x3_textBox";
            this._4x3_textBox.Size = new System.Drawing.Size(42, 20);
            this._4x3_textBox.TabIndex = 41;
            this._4x3_textBox.Text = "0";
            this._4x3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _3x3_textBox
            // 
            this._3x3_textBox.Location = new System.Drawing.Point(152, 100);
            this._3x3_textBox.Name = "_3x3_textBox";
            this._3x3_textBox.Size = new System.Drawing.Size(42, 20);
            this._3x3_textBox.TabIndex = 40;
            this._3x3_textBox.Text = "0";
            this._3x3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _4x2_textBox
            // 
            this._4x2_textBox.Location = new System.Drawing.Point(104, 126);
            this._4x2_textBox.Name = "_4x2_textBox";
            this._4x2_textBox.Size = new System.Drawing.Size(42, 20);
            this._4x2_textBox.TabIndex = 39;
            this._4x2_textBox.Text = "0";
            this._4x2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _4x1_textBox
            // 
            this._4x1_textBox.Location = new System.Drawing.Point(56, 126);
            this._4x1_textBox.Name = "_4x1_textBox";
            this._4x1_textBox.Size = new System.Drawing.Size(42, 20);
            this._4x1_textBox.TabIndex = 38;
            this._4x1_textBox.Text = "0";
            this._4x1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _4x0_textBox
            // 
            this._4x0_textBox.Location = new System.Drawing.Point(8, 126);
            this._4x0_textBox.Name = "_4x0_textBox";
            this._4x0_textBox.Size = new System.Drawing.Size(42, 20);
            this._4x0_textBox.TabIndex = 37;
            this._4x0_textBox.Text = "0";
            this._4x0_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _3x2_textBox
            // 
            this._3x2_textBox.Location = new System.Drawing.Point(104, 100);
            this._3x2_textBox.Name = "_3x2_textBox";
            this._3x2_textBox.Size = new System.Drawing.Size(42, 20);
            this._3x2_textBox.TabIndex = 36;
            this._3x2_textBox.Text = "0";
            this._3x2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _3x1_textBox
            // 
            this._3x1_textBox.Location = new System.Drawing.Point(56, 100);
            this._3x1_textBox.Name = "_3x1_textBox";
            this._3x1_textBox.Size = new System.Drawing.Size(42, 20);
            this._3x1_textBox.TabIndex = 35;
            this._3x1_textBox.Text = "0";
            this._3x1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _3x0_textBox
            // 
            this._3x0_textBox.Location = new System.Drawing.Point(8, 100);
            this._3x0_textBox.Name = "_3x0_textBox";
            this._3x0_textBox.Size = new System.Drawing.Size(42, 20);
            this._3x0_textBox.TabIndex = 34;
            this._3x0_textBox.Text = "0";
            this._3x0_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Custom5x5ConvolutionFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 229);
            this.Controls.Add(this._4x4_textBox);
            this.Controls.Add(this._3x4_textBox);
            this.Controls.Add(this._4x3_textBox);
            this.Controls.Add(this._3x3_textBox);
            this.Controls.Add(this._4x2_textBox);
            this.Controls.Add(this._4x1_textBox);
            this.Controls.Add(this._4x0_textBox);
            this.Controls.Add(this._3x2_textBox);
            this.Controls.Add(this._3x1_textBox);
            this.Controls.Add(this._3x0_textBox);
            this.Controls.Add(this._2x4_textBox);
            this.Controls.Add(this._1x4_textBox);
            this.Controls.Add(this._0x4_textBox);
            this.Controls.Add(this._2x3_textBox);
            this.Controls.Add(this._1x3_textBox);
            this.Controls.Add(this._0x3_textBox);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Factor_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._2x2_textBox);
            this.Controls.Add(this._2x1_textBox);
            this.Controls.Add(this._2x0_textBox);
            this.Controls.Add(this._1x2_textBox);
            this.Controls.Add(this._1x1_textBox);
            this.Controls.Add(this._1x0_textBox);
            this.Controls.Add(this._0x2_textBox);
            this.Controls.Add(this._0x1_textBox);
            this.Controls.Add(this._0x0_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Custom5x5ConvolutionFilterControl";
            this.Text = "Custom5x5ConvolutionFilterControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Factor_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _2x2_textBox;
        private System.Windows.Forms.TextBox _2x1_textBox;
        private System.Windows.Forms.TextBox _2x0_textBox;
        private System.Windows.Forms.TextBox _1x2_textBox;
        private System.Windows.Forms.TextBox _1x1_textBox;
        private System.Windows.Forms.TextBox _1x0_textBox;
        private System.Windows.Forms.TextBox _0x2_textBox;
        private System.Windows.Forms.TextBox _0x1_textBox;
        private System.Windows.Forms.TextBox _0x0_textBox;
        private System.Windows.Forms.TextBox _0x3_textBox;
        private System.Windows.Forms.TextBox _1x3_textBox;
        private System.Windows.Forms.TextBox _2x3_textBox;
        private System.Windows.Forms.TextBox _0x4_textBox;
        private System.Windows.Forms.TextBox _1x4_textBox;
        private System.Windows.Forms.TextBox _2x4_textBox;
        private System.Windows.Forms.TextBox _4x4_textBox;
        private System.Windows.Forms.TextBox _3x4_textBox;
        private System.Windows.Forms.TextBox _4x3_textBox;
        private System.Windows.Forms.TextBox _3x3_textBox;
        private System.Windows.Forms.TextBox _4x2_textBox;
        private System.Windows.Forms.TextBox _4x1_textBox;
        private System.Windows.Forms.TextBox _4x0_textBox;
        private System.Windows.Forms.TextBox _3x2_textBox;
        private System.Windows.Forms.TextBox _3x1_textBox;
        private System.Windows.Forms.TextBox _3x0_textBox;
    }
}