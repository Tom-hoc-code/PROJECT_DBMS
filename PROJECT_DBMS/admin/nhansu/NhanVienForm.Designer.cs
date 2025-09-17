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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            CoCau = new Label();
            panel3 = new Panel();
            buttonSearch = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            update = new Button();
            delete = new Button();
            ADD = new Button();
            Total = new Label();
            dataGridView1 = new DataGridView();
            nhanvienQueryBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienQueryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(CoCau);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(211, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(109, 397);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // CoCau
            // 
            CoCau.AutoSize = true;
            CoCau.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CoCau.Location = new Point(0, 0);
            CoCau.Name = "CoCau";
            CoCau.Size = new Size(183, 24);
            CoCau.TabIndex = 6;
            CoCau.Text = "Cơ cấu nhân viên";
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonSearch);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 400);
            panel3.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.MediumTurquoise;
            buttonSearch.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            buttonSearch.FlatAppearance.MouseDownBackColor = Color.Cyan;
            buttonSearch.FlatAppearance.MouseOverBackColor = Color.Black;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("FZ Rodia Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(0, 368);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(205, 29);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 336);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm nhân viên...";
            textBox1.Size = new Size(205, 26);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(update);
            panel2.Controls.Add(delete);
            panel2.Controls.Add(ADD);
            panel2.Controls.Add(Total);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(320, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 400);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // update
            // 
            update.BackColor = Color.MediumTurquoise;
            update.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            update.FlatAppearance.MouseDownBackColor = Color.Cyan;
            update.FlatStyle = FlatStyle.Popup;
            update.Font = new Font("FZ Rodia Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(216, 55);
            update.Name = "update";
            update.Size = new Size(102, 29);
            update.TabIndex = 4;
            update.Text = "update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.MediumTurquoise;
            delete.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            delete.FlatAppearance.MouseDownBackColor = Color.Cyan;
            delete.FlatStyle = FlatStyle.Popup;
            delete.Font = new Font("FZ Rodia Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.Location = new Point(108, 55);
            delete.Name = "delete";
            delete.Size = new Size(102, 29);
            delete.TabIndex = 3;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = false;
            // 
            // ADD
            // 
            ADD.BackColor = Color.MediumTurquoise;
            ADD.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            ADD.FlatAppearance.MouseDownBackColor = Color.Cyan;
            ADD.FlatStyle = FlatStyle.Popup;
            ADD.Font = new Font("FZ Rodia Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADD.Location = new Point(0, 55);
            ADD.Name = "ADD";
            ADD.Size = new Size(102, 29);
            ADD.TabIndex = 2;
            ADD.Text = "add";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total.Location = new Point(3, 9);
            Total.Name = "Total";
            Total.Size = new Size(99, 24);
            Total.TabIndex = 1;
            Total.Text = "Số lượng";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.LightGreen;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 50);
            dataGridView1.TabIndex = 0;
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
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienQueryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button delete;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource nhanvienQueryBindingSource;
        private Label Total;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Button buttonSearch;
        private Button ADD;
        private Button update;
        private Panel panel4;
        private Label CoCau;
    }
}