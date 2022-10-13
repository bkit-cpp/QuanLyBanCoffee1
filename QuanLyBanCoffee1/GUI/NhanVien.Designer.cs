
namespace QuanLyBanCoffee1
{
    partial class NhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAMENV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GMAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADDRESS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PHONE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vbButton3 = new CustomButton.VBButton();
            this.vbButton2 = new CustomButton.VBButton();
            this.vbButton1 = new CustomButton.VBButton();
            this.cusTomTextBox4 = new CustomControls.RJControls.CusTomTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cusTomTextBox6 = new CustomControls.RJControls.CusTomTextBox();
            this.cusTomTextBox3 = new CustomControls.RJControls.CusTomTextBox();
            this.cusTomTextBox2 = new CustomControls.RJControls.CusTomTextBox();
            this.cusTomTextBox1 = new CustomControls.RJControls.CusTomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.vbButton3);
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.cusTomTextBox4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cusTomTextBox6);
            this.panel1.Controls.Add(this.cusTomTextBox3);
            this.panel1.Controls.Add(this.cusTomTextBox2);
            this.panel1.Controls.Add(this.cusTomTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 452);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanCoffee1.Properties.Resources.NhanVien1;
            this.pictureBox1.Location = new System.Drawing.Point(262, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDNV,
            this.NAMENV,
            this.GMAIL,
            this.SEX,
            this.ADDRESS,
            this.PHONE});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(412, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 355);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IDNV
            // 
            this.IDNV.Text = "IDNV";
            // 
            // NAMENV
            // 
            this.NAMENV.Text = "NAME:";
            // 
            // GMAIL
            // 
            this.GMAIL.Text = "GMAIL:";
            // 
            // SEX
            // 
            this.SEX.Text = "SEX:";
            // 
            // ADDRESS
            // 
            this.ADDRESS.Text = "ADDRESS:";
            // 
            // PHONE
            // 
            this.PHONE.Text = "PHONE:";
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton3.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton3.BorderColor = System.Drawing.Color.Crimson;
            this.vbButton3.BorderRadius = 20;
            this.vbButton3.BorderSize = 3;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(125, 376);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(91, 40);
            this.vbButton3.TabIndex = 21;
            this.vbButton3.Text = "DELETE";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton2.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton2.BorderColor = System.Drawing.Color.Crimson;
            this.vbButton2.BorderRadius = 20;
            this.vbButton2.BorderSize = 3;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(235, 376);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(91, 40);
            this.vbButton2.TabIndex = 20;
            this.vbButton2.Text = "EDIT";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.Crimson;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 3;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(16, 376);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(91, 40);
            this.vbButton1.TabIndex = 19;
            this.vbButton1.Text = "ADD";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // cusTomTextBox4
            // 
            this.cusTomTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.cusTomTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusTomTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cusTomTextBox4.BorderSize = 2;
            this.cusTomTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTomTextBox4.Location = new System.Drawing.Point(88, 289);
            this.cusTomTextBox4.Multiline = false;
            this.cusTomTextBox4.Name = "cusTomTextBox4";
            this.cusTomTextBox4.Padding = new System.Windows.Forms.Padding(6);
            this.cusTomTextBox4.PasswordChar = false;
            this.cusTomTextBox4.Size = new System.Drawing.Size(150, 28);
            this.cusTomTextBox4.TabIndex = 18;
            this.cusTomTextBox4.Texts = "";
            this.cusTomTextBox4.UnderlinedStyle = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "MAN",
            "WOMAN"});
            this.comboBox1.Location = new System.Drawing.Point(88, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "PHONE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "SEX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "GMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "IDNV:";
            // 
            // cusTomTextBox6
            // 
            this.cusTomTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.cusTomTextBox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusTomTextBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cusTomTextBox6.BorderSize = 2;
            this.cusTomTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTomTextBox6.Location = new System.Drawing.Point(88, 333);
            this.cusTomTextBox6.Multiline = false;
            this.cusTomTextBox6.Name = "cusTomTextBox6";
            this.cusTomTextBox6.Padding = new System.Windows.Forms.Padding(6);
            this.cusTomTextBox6.PasswordChar = false;
            this.cusTomTextBox6.Size = new System.Drawing.Size(150, 28);
            this.cusTomTextBox6.TabIndex = 9;
            this.cusTomTextBox6.Texts = "";
            this.cusTomTextBox6.UnderlinedStyle = false;
            // 
            // cusTomTextBox3
            // 
            this.cusTomTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.cusTomTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusTomTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cusTomTextBox3.BorderSize = 2;
            this.cusTomTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTomTextBox3.Location = new System.Drawing.Point(88, 212);
            this.cusTomTextBox3.Multiline = false;
            this.cusTomTextBox3.Name = "cusTomTextBox3";
            this.cusTomTextBox3.Padding = new System.Windows.Forms.Padding(6);
            this.cusTomTextBox3.PasswordChar = false;
            this.cusTomTextBox3.Size = new System.Drawing.Size(150, 28);
            this.cusTomTextBox3.TabIndex = 6;
            this.cusTomTextBox3.Texts = "";
            this.cusTomTextBox3.UnderlinedStyle = false;
            // 
            // cusTomTextBox2
            // 
            this.cusTomTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.cusTomTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusTomTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cusTomTextBox2.BorderSize = 2;
            this.cusTomTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTomTextBox2.Location = new System.Drawing.Point(88, 165);
            this.cusTomTextBox2.Multiline = false;
            this.cusTomTextBox2.Name = "cusTomTextBox2";
            this.cusTomTextBox2.Padding = new System.Windows.Forms.Padding(6);
            this.cusTomTextBox2.PasswordChar = false;
            this.cusTomTextBox2.Size = new System.Drawing.Size(150, 28);
            this.cusTomTextBox2.TabIndex = 5;
            this.cusTomTextBox2.Texts = "";
            this.cusTomTextBox2.UnderlinedStyle = false;
            // 
            // cusTomTextBox1
            // 
            this.cusTomTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.cusTomTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cusTomTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cusTomTextBox1.BorderSize = 2;
            this.cusTomTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTomTextBox1.Location = new System.Drawing.Point(88, 116);
            this.cusTomTextBox1.Multiline = false;
            this.cusTomTextBox1.Name = "cusTomTextBox1";
            this.cusTomTextBox1.Padding = new System.Windows.Forms.Padding(6);
            this.cusTomTextBox1.PasswordChar = false;
            this.cusTomTextBox1.Size = new System.Drawing.Size(150, 28);
            this.cusTomTextBox1.TabIndex = 4;
            this.cusTomTextBox1.Texts = "";
            this.cusTomTextBox1.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.CusTomTextBox cusTomTextBox6;
        private CustomControls.RJControls.CusTomTextBox cusTomTextBox3;
        private CustomControls.RJControls.CusTomTextBox cusTomTextBox2;
        private CustomControls.RJControls.CusTomTextBox cusTomTextBox1;
        private System.Windows.Forms.ListView listView1;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton vbButton1;
        private CustomControls.RJControls.CusTomTextBox cusTomTextBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader IDNV;
        private System.Windows.Forms.ColumnHeader NAMENV;
        private System.Windows.Forms.ColumnHeader GMAIL;
        private System.Windows.Forms.ColumnHeader SEX;
        private System.Windows.Forms.ColumnHeader ADDRESS;
        private System.Windows.Forms.ColumnHeader PHONE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}