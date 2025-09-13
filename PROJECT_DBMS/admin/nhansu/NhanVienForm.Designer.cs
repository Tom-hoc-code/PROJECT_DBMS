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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Font = new Font("Tahoma", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 184, 147);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVienForm";
            Text = "Form1";
            Load += Thongtin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}