namespace PROJECT_DBMS.admin.nhansu
{
    partial class ADD
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
            panel1 = new Panel();
            mainLabel = new Label();
            mainpanel = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            txtChuyen = new TextBox();
            txtBienSo = new TextBox();
            txtXe = new TextBox();
            labelChuyen = new Label();
            labelBienso = new Label();
            Xe = new Label();
            label7 = new Label();
            panel2 = new Panel();
            ButtonSave = new Button();
            nhanvienBox = new CheckBox();
            DriverBox = new CheckBox();
            checkBox1 = new CheckBox();
            checkBoxMale = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameLabel = new Label();
            txtSalary = new TextBox();
            txtEmail = new TextBox();
            txtDchi = new TextBox();
            txtSDT = new TextBox();
            txtNgsinh = new TextBox();
            txtTenNV = new TextBox();
            panel1.SuspendLayout();
            mainpanel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(mainLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 0;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Dock = DockStyle.Left;
            mainLabel.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainLabel.Location = new Point(0, 0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(240, 34);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Thêm nhân viên";
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(panel4);
            mainpanel.Controls.Add(panel3);
            mainpanel.Controls.Add(panel2);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 41);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(800, 409);
            mainpanel.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(436, 166);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 243);
            panel4.TabIndex = 2;
            panel4.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(161, 11);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 21;
            label9.Text = "Kho";
            label9.Click += label9_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtChuyen);
            panel3.Controls.Add(txtBienSo);
            panel3.Controls.Add(txtXe);
            panel3.Controls.Add(labelChuyen);
            panel3.Controls.Add(labelBienso);
            panel3.Controls.Add(Xe);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(436, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 163);
            panel3.TabIndex = 1;
            panel3.Visible = false;
            // 
            // txtChuyen
            // 
            txtChuyen.BackColor = Color.WhiteSmoke;
            txtChuyen.BorderStyle = BorderStyle.FixedSingle;
            txtChuyen.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtChuyen.ForeColor = Color.DarkBlue;
            txtChuyen.Location = new Point(98, 97);
            txtChuyen.Margin = new Padding(5);
            txtChuyen.Name = "txtChuyen";
            txtChuyen.PlaceholderText = "Chuyến...";
            txtChuyen.Size = new Size(180, 30);
            txtChuyen.TabIndex = 20;
            // 
            // txtBienSo
            // 
            txtBienSo.BackColor = Color.WhiteSmoke;
            txtBienSo.BorderStyle = BorderStyle.FixedSingle;
            txtBienSo.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtBienSo.ForeColor = Color.DarkBlue;
            txtBienSo.Location = new Point(98, 66);
            txtBienSo.Margin = new Padding(5);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.PlaceholderText = "Biển...";
            txtBienSo.Size = new Size(180, 30);
            txtBienSo.TabIndex = 19;
            // 
            // txtXe
            // 
            txtXe.BackColor = Color.WhiteSmoke;
            txtXe.BorderStyle = BorderStyle.FixedSingle;
            txtXe.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtXe.ForeColor = Color.DarkBlue;
            txtXe.Location = new Point(98, 33);
            txtXe.Margin = new Padding(5);
            txtXe.Name = "txtXe";
            txtXe.PlaceholderText = "Hãng xe...";
            txtXe.Size = new Size(180, 30);
            txtXe.TabIndex = 16;
            txtXe.TextChanged += txtXe_TextChanged;
            // 
            // labelChuyen
            // 
            labelChuyen.AutoSize = true;
            labelChuyen.BackColor = Color.Transparent;
            labelChuyen.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChuyen.ForeColor = Color.DarkSlateBlue;
            labelChuyen.Location = new Point(6, 100);
            labelChuyen.Name = "labelChuyen";
            labelChuyen.Size = new Size(80, 21);
            labelChuyen.TabIndex = 18;
            labelChuyen.Text = "Chuyến:";
            // 
            // labelBienso
            // 
            labelBienso.AutoSize = true;
            labelBienso.BackColor = Color.Transparent;
            labelBienso.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienso.ForeColor = Color.DarkSlateBlue;
            labelBienso.Location = new Point(6, 69);
            labelBienso.Name = "labelBienso";
            labelBienso.Size = new Size(79, 21);
            labelBienso.TabIndex = 17;
            labelBienso.Text = "Biển số:";
            // 
            // Xe
            // 
            Xe.AutoSize = true;
            Xe.BackColor = Color.Transparent;
            Xe.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xe.ForeColor = Color.DarkSlateBlue;
            Xe.Location = new Point(6, 36);
            Xe.Name = "Xe";
            Xe.Size = new Size(86, 21);
            Xe.TabIndex = 16;
            Xe.Text = "Hãng xe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(148, 1);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 14;
            label7.Text = "Giao xe";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(ButtonSave);
            panel2.Controls.Add(nhanvienBox);
            panel2.Controls.Add(DriverBox);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(checkBoxMale);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(txtSalary);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtDchi);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtNgsinh);
            panel2.Controls.Add(txtTenNV);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 409);
            panel2.TabIndex = 0;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.DeepSkyBlue;
            ButtonSave.Cursor = Cursors.Hand;
            ButtonSave.FlatAppearance.BorderSize = 0;
            ButtonSave.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            ButtonSave.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Font = new Font("Tahoma", 10.5F, FontStyle.Bold);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(22, 360);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(110, 35);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "Lưu";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // nhanvienBox
            // 
            nhanvienBox.AutoSize = true;
            nhanvienBox.BackColor = Color.Transparent;
            nhanvienBox.FlatStyle = FlatStyle.System;
            nhanvienBox.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            nhanvienBox.ForeColor = Color.DarkSlateBlue;
            nhanvienBox.Location = new Point(304, 215);
            nhanvienBox.Name = "nhanvienBox";
            nhanvienBox.Size = new Size(73, 26);
            nhanvienBox.TabIndex = 15;
            nhanvienBox.Tag = "Position";
            nhanvienBox.Text = "kho";
            nhanvienBox.UseVisualStyleBackColor = false;
            nhanvienBox.CheckedChanged += nhanvienBox_CheckedChanged;
            // 
            // DriverBox
            // 
            DriverBox.AutoSize = true;
            DriverBox.BackColor = Color.Transparent;
            DriverBox.FlatStyle = FlatStyle.System;
            DriverBox.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            DriverBox.ForeColor = Color.DarkSlateBlue;
            DriverBox.Location = new Point(178, 215);
            DriverBox.Name = "DriverBox";
            DriverBox.Size = new Size(88, 26);
            DriverBox.TabIndex = 14;
            DriverBox.Tag = "Position";
            DriverBox.Text = "tài xế";
            DriverBox.UseVisualStyleBackColor = false;
            DriverBox.CheckedChanged += DriverBox_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            checkBox1.ForeColor = Color.DarkSlateBlue;
            checkBox1.Location = new Point(304, 312);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 26);
            checkBox1.TabIndex = 13;
            checkBox1.Tag = "Gender";
            checkBox1.Text = "Nữ";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.BackColor = Color.Transparent;
            checkBoxMale.FlatStyle = FlatStyle.System;
            checkBoxMale.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            checkBoxMale.ForeColor = Color.DarkSlateBlue;
            checkBoxMale.Location = new Point(178, 312);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(80, 26);
            checkBoxMale.TabIndex = 0;
            checkBoxMale.Tag = "Gender";
            checkBoxMale.Text = "Nam";
            checkBoxMale.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateBlue;
            label6.Location = new Point(22, 260);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 12;
            label6.Text = "Lương:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(22, 220);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 11;
            label5.Text = "Chức vụ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(22, 180);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(22, 140);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(22, 100);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 8;
            label2.Text = "SDT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(22, 60);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 7;
            label1.Text = "Ngày sinh:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.DarkSlateBlue;
            nameLabel.Location = new Point(22, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(136, 21);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Tên nhân viên:";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.WhiteSmoke;
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtSalary.ForeColor = Color.DarkBlue;
            txtSalary.Location = new Point(178, 257);
            txtSalary.Margin = new Padding(5);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "Lương...";
            txtSalary.Size = new Size(250, 30);
            txtSalary.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtEmail.ForeColor = Color.DarkBlue;
            txtEmail.Location = new Point(178, 177);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email nhân viên...";
            txtEmail.Size = new Size(250, 30);
            txtEmail.TabIndex = 4;
            // 
            // txtDchi
            // 
            txtDchi.BackColor = Color.WhiteSmoke;
            txtDchi.BorderStyle = BorderStyle.FixedSingle;
            txtDchi.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtDchi.ForeColor = Color.DarkBlue;
            txtDchi.Location = new Point(178, 137);
            txtDchi.Margin = new Padding(5);
            txtDchi.Name = "txtDchi";
            txtDchi.PlaceholderText = "Nhập địa chỉ nhân viên...";
            txtDchi.Size = new Size(250, 30);
            txtDchi.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.WhiteSmoke;
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtSDT.ForeColor = Color.DarkBlue;
            txtSDT.Location = new Point(178, 97);
            txtSDT.Margin = new Padding(5);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Nhập SDT nhân viên...";
            txtSDT.Size = new Size(250, 30);
            txtSDT.TabIndex = 2;
            // 
            // txtNgsinh
            // 
            txtNgsinh.BackColor = Color.WhiteSmoke;
            txtNgsinh.BorderStyle = BorderStyle.FixedSingle;
            txtNgsinh.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtNgsinh.ForeColor = Color.DarkBlue;
            txtNgsinh.Location = new Point(178, 57);
            txtNgsinh.Margin = new Padding(5);
            txtNgsinh.Name = "txtNgsinh";
            txtNgsinh.PlaceholderText = "Nhập ngày sinh...";
            txtNgsinh.Size = new Size(250, 30);
            txtNgsinh.TabIndex = 1;
            // 
            // txtTenNV
            // 
            txtTenNV.BackColor = Color.WhiteSmoke;
            txtTenNV.BorderStyle = BorderStyle.FixedSingle;
            txtTenNV.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtTenNV.ForeColor = Color.DarkBlue;
            txtTenNV.Location = new Point(178, 17);
            txtTenNV.Margin = new Padding(5);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.PlaceholderText = "Nhập tên nhân viên...";
            txtTenNV.Size = new Size(250, 30);
            txtTenNV.TabIndex = 0;
            // 
            // ADD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ADD";
            Text = "ADD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainpanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label mainLabel;
        private Panel mainpanel;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtTenNV;
        private TextBox txtSalary;
        private TextBox txtEmail;
        private TextBox txtDchi;
        private TextBox txtSDT;
        private TextBox txtNgsinh;
        private Label nameLabel;
        private CheckBox checkBoxMale;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label7;
        private CheckBox nhanvienBox;
        private CheckBox DriverBox;
        private Panel panel4;
        private TextBox txtXe;
        private Label labelChuyen;
        private Label labelBienso;
        private Label Xe;
        private TextBox txtChuyen;
        private TextBox txtBienSo;
        private Label label9;
        private Button ButtonSave;
    }
}