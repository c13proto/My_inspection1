namespace 自作傷検出1
{
    partial class 検査対象画像画面
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
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.textBox_CannyTH1 = new System.Windows.Forms.TextBox();
            this.trackBar_CannyTH1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Canny実行ボタン = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_CannyTH2 = new System.Windows.Forms.TrackBar();
            this.textBox_CannyTH2 = new System.Windows.Forms.TextBox();
            this.label_座標 = new System.Windows.Forms.Label();
            this.色 = new System.Windows.Forms.Label();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_CloseNum = new System.Windows.Forms.TrackBar();
            this.textBox_CloseNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_CloseSize = new System.Windows.Forms.TrackBar();
            this.textBox_CloseSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CannyTH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CannyTH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CloseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CloseSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(99, 10);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(295, 293);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            this.pictureBoxIpl1.Click += new System.EventHandler(this.OnClick_pictureBoxIpl1);
            this.pictureBoxIpl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_pictureBoxIpl1);
            // 
            // textBox_CannyTH1
            // 
            this.textBox_CannyTH1.Location = new System.Drawing.Point(59, 29);
            this.textBox_CannyTH1.Name = "textBox_CannyTH1";
            this.textBox_CannyTH1.Size = new System.Drawing.Size(25, 19);
            this.textBox_CannyTH1.TabIndex = 2;
            this.textBox_CannyTH1.Text = "0";
            this.textBox_CannyTH1.TextChanged += new System.EventHandler(this.TextChanged_CannyTH1);
            // 
            // trackBar_CannyTH1
            // 
            this.trackBar_CannyTH1.AutoSize = false;
            this.trackBar_CannyTH1.Location = new System.Drawing.Point(7, 49);
            this.trackBar_CannyTH1.Maximum = 255;
            this.trackBar_CannyTH1.Name = "trackBar_CannyTH1";
            this.trackBar_CannyTH1.Size = new System.Drawing.Size(79, 22);
            this.trackBar_CannyTH1.TabIndex = 3;
            this.trackBar_CannyTH1.Scroll += new System.EventHandler(this.Scroll_CannyTH1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "<Canny>";
            // 
            // Canny実行ボタン
            // 
            this.Canny実行ボタン.Location = new System.Drawing.Point(9, 119);
            this.Canny実行ボタン.Name = "Canny実行ボタン";
            this.Canny実行ボタン.Size = new System.Drawing.Size(75, 23);
            this.Canny実行ボタン.TabIndex = 7;
            this.Canny実行ボタン.Text = "Canny実行";
            this.Canny実行ボタン.UseVisualStyleBackColor = true;
            this.Canny実行ボタン.Click += new System.EventHandler(this.OnClickCanny実行ボタン);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "TH1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "TH2";
            // 
            // trackBar_CannyTH2
            // 
            this.trackBar_CannyTH2.AutoSize = false;
            this.trackBar_CannyTH2.Location = new System.Drawing.Point(7, 91);
            this.trackBar_CannyTH2.Maximum = 255;
            this.trackBar_CannyTH2.Name = "trackBar_CannyTH2";
            this.trackBar_CannyTH2.Size = new System.Drawing.Size(79, 22);
            this.trackBar_CannyTH2.TabIndex = 14;
            this.trackBar_CannyTH2.Value = 180;
            this.trackBar_CannyTH2.Scroll += new System.EventHandler(this.Scroll_CannyTH2);
            // 
            // textBox_CannyTH2
            // 
            this.textBox_CannyTH2.Location = new System.Drawing.Point(59, 71);
            this.textBox_CannyTH2.Name = "textBox_CannyTH2";
            this.textBox_CannyTH2.Size = new System.Drawing.Size(25, 19);
            this.textBox_CannyTH2.TabIndex = 13;
            this.textBox_CannyTH2.Text = "180";
            this.textBox_CannyTH2.TextChanged += new System.EventHandler(this.TextChanged_CannyTH2);
            // 
            // label_座標
            // 
            this.label_座標.AutoSize = true;
            this.label_座標.Location = new System.Drawing.Point(12, 291);
            this.label_座標.Name = "label_座標";
            this.label_座標.Size = new System.Drawing.Size(27, 12);
            this.label_座標.TabIndex = 16;
            this.label_座標.Text = "(x,y)";
            // 
            // 色
            // 
            this.色.AutoSize = true;
            this.色.Location = new System.Drawing.Point(77, 312);
            this.色.Name = "色";
            this.色.Size = new System.Drawing.Size(10, 12);
            this.色.TabIndex = 17;
            this.色.Text = "?";
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(45, 309);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(26, 19);
            this.textBox_y.TabIndex = 19;
            this.textBox_y.Text = "y";
            this.textBox_y.TextChanged += new System.EventHandler(this.TextChanged_y);
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(12, 309);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(27, 19);
            this.textBox_x.TabIndex = 18;
            this.textBox_x.Text = "x";
            this.textBox_x.TextChanged += new System.EventHandler(this.TextChanged_x);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "回数";
            // 
            // trackBar_CloseNum
            // 
            this.trackBar_CloseNum.AutoSize = false;
            this.trackBar_CloseNum.Location = new System.Drawing.Point(7, 226);
            this.trackBar_CloseNum.Maximum = 20;
            this.trackBar_CloseNum.Minimum = 1;
            this.trackBar_CloseNum.Name = "trackBar_CloseNum";
            this.trackBar_CloseNum.Size = new System.Drawing.Size(79, 22);
            this.trackBar_CloseNum.TabIndex = 25;
            this.trackBar_CloseNum.Value = 2;
            this.trackBar_CloseNum.Scroll += new System.EventHandler(this.Scroll_CloseNum);
            // 
            // textBox_CloseNum
            // 
            this.textBox_CloseNum.Location = new System.Drawing.Point(59, 206);
            this.textBox_CloseNum.Name = "textBox_CloseNum";
            this.textBox_CloseNum.Size = new System.Drawing.Size(25, 19);
            this.textBox_CloseNum.TabIndex = 24;
            this.textBox_CloseNum.Text = "2";
            this.textBox_CloseNum.TextChanged += new System.EventHandler(this.TextChanged_CloseNum);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "<Close>";
            // 
            // trackBar_CloseSize
            // 
            this.trackBar_CloseSize.AutoSize = false;
            this.trackBar_CloseSize.Location = new System.Drawing.Point(7, 184);
            this.trackBar_CloseSize.Maximum = 20;
            this.trackBar_CloseSize.Minimum = 2;
            this.trackBar_CloseSize.Name = "trackBar_CloseSize";
            this.trackBar_CloseSize.Size = new System.Drawing.Size(79, 22);
            this.trackBar_CloseSize.TabIndex = 21;
            this.trackBar_CloseSize.Value = 3;
            this.trackBar_CloseSize.Scroll += new System.EventHandler(this.Scroll_CloseSize);
            // 
            // textBox_CloseSize
            // 
            this.textBox_CloseSize.Location = new System.Drawing.Point(59, 164);
            this.textBox_CloseSize.Name = "textBox_CloseSize";
            this.textBox_CloseSize.Size = new System.Drawing.Size(25, 19);
            this.textBox_CloseSize.TabIndex = 20;
            this.textBox_CloseSize.Text = "3";
            this.textBox_CloseSize.TextChanged += new System.EventHandler(this.TextChanged_CloseSize);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "全て実行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClick全て実行ボタン);
            // 
            // 検査対象画像画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(415, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_CloseNum);
            this.Controls.Add(this.textBox_CloseNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_CloseSize);
            this.Controls.Add(this.textBox_CloseSize);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.色);
            this.Controls.Add(this.label_座標);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar_CannyTH2);
            this.Controls.Add(this.textBox_CannyTH2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Canny実行ボタン);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_CannyTH1);
            this.Controls.Add(this.textBox_CannyTH1);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "検査対象画像画面";
            this.Text = "検査画像画面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CannyTH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CannyTH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CloseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CloseSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.TextBox textBox_CannyTH1;
        private System.Windows.Forms.TrackBar trackBar_CannyTH1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Canny実行ボタン;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_CannyTH2;
        private System.Windows.Forms.TextBox textBox_CannyTH2;
        private System.Windows.Forms.Label label_座標;
        private System.Windows.Forms.Label 色;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_CloseNum;
        private System.Windows.Forms.TextBox textBox_CloseNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_CloseSize;
        private System.Windows.Forms.TextBox textBox_CloseSize;
        private System.Windows.Forms.Button button1;
    }
}