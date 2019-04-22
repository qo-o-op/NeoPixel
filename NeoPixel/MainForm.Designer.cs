namespace NeoPixel
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
            this.components = new System.ComponentModel.Container();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.bRed = new System.Windows.Forms.TrackBar();
            this.bGreen = new System.Windows.Forms.TrackBar();
            this.bBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbBlue = new System.Windows.Forms.Label();
            this.cDlg = new System.Windows.Forms.ColorDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.Location = new System.Drawing.Point(12, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(444, 50);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            this.colorBox.DoubleClick += new System.EventHandler(this.colorBox_DoubleClick);
            // 
            // bRed
            // 
            this.bRed.Location = new System.Drawing.Point(61, 68);
            this.bRed.Maximum = 255;
            this.bRed.Name = "bRed";
            this.bRed.Size = new System.Drawing.Size(346, 45);
            this.bRed.TabIndex = 1;
            this.bRed.TickFrequency = 10;
            this.bRed.Scroll += new System.EventHandler(this.b_Scroll);
            // 
            // bGreen
            // 
            this.bGreen.Location = new System.Drawing.Point(61, 126);
            this.bGreen.Maximum = 255;
            this.bGreen.Name = "bGreen";
            this.bGreen.Size = new System.Drawing.Size(346, 45);
            this.bGreen.TabIndex = 2;
            this.bGreen.TickFrequency = 10;
            this.bGreen.Scroll += new System.EventHandler(this.b_Scroll);
            // 
            // bBlue
            // 
            this.bBlue.Location = new System.Drawing.Point(61, 184);
            this.bBlue.Maximum = 255;
            this.bBlue.Name = "bBlue";
            this.bBlue.Size = new System.Drawing.Size(346, 45);
            this.bBlue.TabIndex = 3;
            this.bBlue.TickFrequency = 10;
            this.bBlue.Scroll += new System.EventHandler(this.b_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRed
            // 
            this.lbRed.Location = new System.Drawing.Point(413, 68);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(43, 45);
            this.lbRed.TabIndex = 9;
            this.lbRed.Text = "0";
            this.lbRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGreen
            // 
            this.lbGreen.Location = new System.Drawing.Point(413, 126);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(43, 45);
            this.lbGreen.TabIndex = 10;
            this.lbGreen.Text = "0";
            this.lbGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBlue
            // 
            this.lbBlue.Location = new System.Drawing.Point(413, 184);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(43, 45);
            this.lbBlue.TabIndex = 11;
            this.lbBlue.Text = "0";
            this.lbBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 100;
            this.serialPort1.WriteTimeout = 100;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 234);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBlue);
            this.Controls.Add(this.bGreen);
            this.Controls.Add(this.bRed);
            this.Controls.Add(this.colorBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Color Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.TrackBar bRed;
        private System.Windows.Forms.TrackBar bGreen;
        private System.Windows.Forms.TrackBar bBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.ColorDialog cDlg;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

