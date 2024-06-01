namespace Final_Project
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.lblskillsinternational = new System.Windows.Forms.Label();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lplpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.grpboxlogin = new System.Windows.Forms.GroupBox();
            this.checkboxshowpw = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.grpboxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblskillsinternational
            // 
            this.lblskillsinternational.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblskillsinternational.AutoSize = true;
            this.lblskillsinternational.BackColor = System.Drawing.Color.Transparent;
            this.lblskillsinternational.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblskillsinternational.ForeColor = System.Drawing.Color.Navy;
            this.lblskillsinternational.Location = new System.Drawing.Point(12, 188);
            this.lblskillsinternational.Name = "lblskillsinternational";
            this.lblskillsinternational.Size = new System.Drawing.Size(706, 71);
            this.lblskillsinternational.TabIndex = 1;
            this.lblskillsinternational.Text = "Skills International";
            // 
            // picbox1
            // 
            this.picbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox1.BackColor = System.Drawing.Color.Transparent;
            this.picbox1.Image = global::Final_Project.Properties.Resources.images;
            this.picbox1.Location = new System.Drawing.Point(216, 12);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(262, 173);
            this.picbox1.TabIndex = 2;
            this.picbox1.TabStop = false;
            // 
            // lblusername
            // 
            this.lblusername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusername.ForeColor = System.Drawing.Color.Black;
            this.lblusername.Location = new System.Drawing.Point(16, 81);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(143, 32);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // lplpassword
            // 
            this.lplpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lplpassword.AutoSize = true;
            this.lplpassword.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lplpassword.ForeColor = System.Drawing.Color.Black;
            this.lplpassword.Location = new System.Drawing.Point(16, 148);
            this.lplpassword.Name = "lplpassword";
            this.lplpassword.Size = new System.Drawing.Size(136, 32);
            this.lplpassword.TabIndex = 1;
            this.lplpassword.Text = "Password";
            this.lplpassword.Click += new System.EventHandler(this.lplpassword_Click);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtusername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtusername.Location = new System.Drawing.Point(176, 83);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(294, 31);
            this.txtusername.TabIndex = 2;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtpassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtpassword.Location = new System.Drawing.Point(176, 149);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(294, 31);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnclr
            // 
            this.btnclr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnclr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnclr.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclr.ForeColor = System.Drawing.Color.Black;
            this.btnclr.Location = new System.Drawing.Point(58, 252);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(94, 39);
            this.btnclr.TabIndex = 4;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(330, 252);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(94, 39);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // grpboxlogin
            // 
            this.grpboxlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxlogin.BackColor = System.Drawing.Color.Snow;
            this.grpboxlogin.Controls.Add(this.checkboxshowpw);
            this.grpboxlogin.Controls.Add(this.btnlogin);
            this.grpboxlogin.Controls.Add(this.btnclr);
            this.grpboxlogin.Controls.Add(this.txtpassword);
            this.grpboxlogin.Controls.Add(this.txtusername);
            this.grpboxlogin.Controls.Add(this.lplpassword);
            this.grpboxlogin.Controls.Add(this.lblusername);
            this.grpboxlogin.Location = new System.Drawing.Point(116, 262);
            this.grpboxlogin.Name = "grpboxlogin";
            this.grpboxlogin.Size = new System.Drawing.Size(494, 320);
            this.grpboxlogin.TabIndex = 3;
            this.grpboxlogin.TabStop = false;
            this.grpboxlogin.Text = "Login";
            // 
            // checkboxshowpw
            // 
            this.checkboxshowpw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxshowpw.AutoSize = true;
            this.checkboxshowpw.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkboxshowpw.ForeColor = System.Drawing.Color.Black;
            this.checkboxshowpw.Location = new System.Drawing.Point(319, 186);
            this.checkboxshowpw.Name = "checkboxshowpw";
            this.checkboxshowpw.Size = new System.Drawing.Size(151, 27);
            this.checkboxshowpw.TabIndex = 6;
            this.checkboxshowpw.Text = "Show Password";
            this.checkboxshowpw.UseVisualStyleBackColor = true;
            this.checkboxshowpw.CheckedChanged += new System.EventHandler(this.checkboxshowpw_CheckedChanged);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(28, 601);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 39);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 652);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grpboxlogin);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.lblskillsinternational);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-Skills International";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.grpboxlogin.ResumeLayout(false);
            this.grpboxlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblskillsinternational;
        private PictureBox picbox1;
        private Label lblusername;
        private Label lplpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnclr;
        private Button btnlogin;
        private GroupBox grpboxlogin;
        private Button btnexit;
        private CheckBox checkboxshowpw;
        private ColorDialog colorDialog1;
    }
}