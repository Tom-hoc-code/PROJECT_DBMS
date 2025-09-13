namespace PROJECT_DBMS.admin.nhansu
{
    partial class NhanVienForm
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
            contentpanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonThongtin = new Button();
            buttonHieusuat = new Button();
            buttonChamcong = new Button();
            buttonLuongthuong = new Button();
            contentpanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // contentpanel
            // 
            contentpanel.Controls.Add(tableLayoutPanel1);
            contentpanel.Dock = DockStyle.Fill;
            contentpanel.Location = new Point(0, 0);
            contentpanel.Name = "contentpanel";
            contentpanel.Size = new Size(800, 450);
            contentpanel.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(buttonLuongthuong, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonChamcong, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonHieusuat, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonThongtin, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 52);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonThongtin
            // 
            buttonThongtin.Dock = DockStyle.Fill;
            buttonThongtin.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThongtin.Location = new Point(3, 3);
            buttonThongtin.Name = "buttonThongtin";
            buttonThongtin.Size = new Size(194, 46);
            buttonThongtin.TabIndex = 1;
            buttonThongtin.Text = "Thông tin";
            buttonThongtin.UseVisualStyleBackColor = true;
            // 
            // buttonHieusuat
            // 
            buttonHieusuat.Dock = DockStyle.Fill;
            buttonHieusuat.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHieusuat.Location = new Point(203, 3);
            buttonHieusuat.Name = "buttonHieusuat";
            buttonHieusuat.Size = new Size(194, 46);
            buttonHieusuat.TabIndex = 2;
            buttonHieusuat.Text = "Hiệu suất";
            buttonHieusuat.UseVisualStyleBackColor = true;
            // 
            // buttonChamcong
            // 
            buttonChamcong.Dock = DockStyle.Fill;
            buttonChamcong.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChamcong.Location = new Point(403, 3);
            buttonChamcong.Name = "buttonChamcong";
            buttonChamcong.Size = new Size(194, 46);
            buttonChamcong.TabIndex = 3;
            buttonChamcong.Text = "Chấm công";
            buttonChamcong.UseVisualStyleBackColor = true;
            // 
            // buttonLuongthuong
            // 
            buttonLuongthuong.Dock = DockStyle.Fill;
            buttonLuongthuong.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLuongthuong.Location = new Point(603, 3);
            buttonLuongthuong.Name = "buttonLuongthuong";
            buttonLuongthuong.Size = new Size(194, 46);
            buttonLuongthuong.TabIndex = 4;
            buttonLuongthuong.Text = "Lương thưởng";
            buttonLuongthuong.UseVisualStyleBackColor = true;
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(contentpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVienForm";
            Text = "Form1";
            Load += Thongtin_Load;
            contentpanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel contentpanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonThongtin;
        private Button buttonLuongthuong;
        private Button buttonChamcong;
        private Button buttonHieusuat;
        private Button button1;
    }
}