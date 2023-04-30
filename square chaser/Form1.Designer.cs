namespace square_chaser
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
            this.p1scorelabel = new System.Windows.Forms.Label();
            this.p2scorelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.winlabel = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1scorelabel
            // 
            this.p1scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.p1scorelabel.ForeColor = System.Drawing.Color.White;
            this.p1scorelabel.Location = new System.Drawing.Point(264, 11);
            this.p1scorelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1scorelabel.Name = "p1scorelabel";
            this.p1scorelabel.Size = new System.Drawing.Size(81, 30);
            this.p1scorelabel.TabIndex = 0;
            this.p1scorelabel.Text = "0";
            this.p1scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2scorelabel
            // 
            this.p2scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.p2scorelabel.ForeColor = System.Drawing.Color.White;
            this.p2scorelabel.Location = new System.Drawing.Point(706, 11);
            this.p2scorelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p2scorelabel.Name = "p2scorelabel";
            this.p2scorelabel.Size = new System.Drawing.Size(81, 30);
            this.p2scorelabel.TabIndex = 1;
            this.p2scorelabel.Text = "0";
            this.p2scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(621, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Blue score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.GameTimer);
            // 
            // winlabel
            // 
            this.winlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winlabel.ForeColor = System.Drawing.Color.Red;
            this.winlabel.Location = new System.Drawing.Point(222, 180);
            this.winlabel.Name = "winlabel";
            this.winlabel.Size = new System.Drawing.Size(605, 217);
            this.winlabel.TabIndex = 4;
            this.winlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputlabel
            // 
            this.outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.ForeColor = System.Drawing.Color.Red;
            this.outputlabel.Location = new System.Drawing.Point(274, 415);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(450, 94);
            this.outputlabel.TabIndex = 5;
            this.outputlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.winlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2scorelabel);
            this.Controls.Add(this.p1scorelabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label p1scorelabel;
        private System.Windows.Forms.Label p2scorelabel;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label winlabel;
        private System.Windows.Forms.Label outputlabel;
    }
}

