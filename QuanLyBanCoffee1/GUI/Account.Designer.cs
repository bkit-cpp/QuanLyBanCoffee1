
namespace QuanLyBanCoffee1
{
    partial class Account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cusTomTxtpass = new CustomControls.RJControls.CusTomTextBox();
            this.cusTomTxtusername = new CustomControls.RJControls.CusTomTextBox();
            this.Loginexit = new CustomButton.VBButton();
            this.btnLogin = new CustomButton.VBButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.cusTomTxtpass);
            this.panel1.Controls.Add(this.cusTomTxtusername);
            this.panel1.Controls.Add(this.Loginexit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-117, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 499);
            this.panel1.TabIndex = 3;
            // 
            // cusTomTxtpass
            // 
            this.cusTomTxtpass.BackColor = System.Drawing.SystemColors.Window;
            this.cusTomTxtpass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusTomTxtpass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cusTomTxtpass.BorderSize = 2;
            this.cusTomTxtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTomTxtpass.Location = new System.Drawing.Point(562, 271);
            this.cusTomTxtpass.Multiline = false;
            this.cusTomTxtpass.Name = "cusTomTxtpass";
            this.cusTomTxtpass.Padding = new System.Windows.Forms.Padding(6);
            this.cusTomTxtpass.PasswordChar = false;
            this.cusTomTxtpass.Size = new System.Drawing.Size(204, 28);
            this.cusTomTxtpass.TabIndex = 10;
            this.cusTomTxtpass.Texts = "";
            this.cusTomTxtpass.UnderlinedStyle = false;
            // 
            // cusTomTxtusername
            // 
            this.cusTomTxtusername.BackColor = System.Drawing.SystemColors.Window;
            this.cusTomTxtusername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusTomTxtusername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cusTomTxtusername.BorderSize = 2;
            this.cusTomTxtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTomTxtusername.Location = new System.Drawing.Point(562, 234);
            this.cusTomTxtusername.Multiline = false;
            this.cusTomTxtusername.Name = "cusTomTxtusername";
            this.cusTomTxtusername.Padding = new System.Windows.Forms.Padding(6);
            this.cusTomTxtusername.PasswordChar = false;
            this.cusTomTxtusername.Size = new System.Drawing.Size(204, 28);
            this.cusTomTxtusername.TabIndex = 9;
            this.cusTomTxtusername.Texts = "";
            this.cusTomTxtusername.UnderlinedStyle = false;
            this.cusTomTxtusername._TextChanged += new System.EventHandler(this.cusTomTextBox1__TextChanged);
            // 
            // Loginexit
            // 
            this.Loginexit.BackColor = System.Drawing.Color.Red;
            this.Loginexit.BackgroundColor = System.Drawing.Color.Red;
            this.Loginexit.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Loginexit.BorderRadius = 20;
            this.Loginexit.BorderSize = 0;
            this.Loginexit.FlatAppearance.BorderSize = 0;
            this.Loginexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginexit.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginexit.ForeColor = System.Drawing.Color.White;
            this.Loginexit.Location = new System.Drawing.Point(665, 317);
            this.Loginexit.Name = "Loginexit";
            this.Loginexit.Size = new System.Drawing.Size(150, 40);
            this.Loginexit.TabIndex = 8;
            this.Loginexit.Text = "Exit";
            this.Loginexit.TextColor = System.Drawing.Color.White;
            this.Loginexit.UseVisualStyleBackColor = false;
            this.Loginexit.Click += new System.EventHandler(this.Loginexit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(493, 317);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuanLyBanCoffee1.Properties.Resources.DNDK2;
            this.pictureBox1.Location = new System.Drawing.Point(578, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 197);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyBanCoffee1.Properties.Resources.Coffee3;
            this.pictureBox2.Location = new System.Drawing.Point(112, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 461);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton.VBButton btnLogin;
        private System.Windows.Forms.Panel panel1;
        private CustomButton.VBButton Loginexit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.CusTomTextBox cusTomTxtusername;
        private CustomControls.RJControls.CusTomTextBox cusTomTxtpass;
    }
}