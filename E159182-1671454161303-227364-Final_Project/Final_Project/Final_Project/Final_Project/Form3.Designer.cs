namespace Final_Project
{
    partial class frmsplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsplash));
            this.lblloading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblloading
            // 
            this.lblloading.AutoSize = true;
            this.lblloading.BackColor = System.Drawing.Color.Transparent;
            this.lblloading.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblloading.ForeColor = System.Drawing.Color.Black;
            this.lblloading.Location = new System.Drawing.Point(499, 384);
            this.lblloading.Name = "lblloading";
            this.lblloading.Size = new System.Drawing.Size(155, 32);
            this.lblloading.TabIndex = 0;
            this.lblloading.Text = "Loading......";
            this.lblloading.Click += new System.EventHandler(this.lblloading_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(360, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 19);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 19);
            this.panel2.TabIndex = 2;
            // 
            // lblsi
            // 
            this.lblsi.AutoSize = true;
            this.lblsi.BackColor = System.Drawing.Color.Transparent;
            this.lblsi.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsi.ForeColor = System.Drawing.Color.Navy;
            this.lblsi.Location = new System.Drawing.Point(418, 135);
            this.lblsi.Name = "lblsi";
            this.lblsi.Size = new System.Drawing.Size(289, 27);
            this.lblsi.TabIndex = 3;
            this.lblsi.Text = "Skills International";
            // 
            // frmsplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(815, 489);
            this.Controls.Add(this.lblsi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblloading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblloading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Panel panel1;
        private Panel panel2;
        private Label lblsi;
    }
}