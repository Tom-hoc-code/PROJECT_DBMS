using PROJECT_DBMS.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace PROJECT_DBMS.admin.nhansu
{
    public partial class NhanVienForm : Form
    {
        private ToolStripDropDown dropDown;
        public NhanVienForm()
        {
            this.Load += NhanVienForm_Load;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Thongtin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLuongthuong_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua header hoặc cell không phải button
            if (e.RowIndex < 0 || !(dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                return;

            // Lấy ID hoặc tên nhân viên từ row
            var nhanvienId = dataGridView1.Rows[e.RowIndex].Cells["NhanVienID"].Value.ToString();
            var nhanvienTen = dataGridView1.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();

            // Mở form chi tiết hoặc hiển thị MessageBox
            MessageBox.Show($"Chi tiết nhân viên:\nID: {nhanvienId}\nTên: {nhanvienTen}",
                "Thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("NhanVienForm_Load được gọi!");
            LoadNhanVienData();
            CreateMultiSelectComboBox();
            AddDetailButtonColumn();
        }

        private void LoadNhanVienData()
        {
            try
            {
                DataTable dt = NhanvienQuery.GetAllNhanVien();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDetailButtonColumn()
        {
            if (dataGridView1.Columns["DetailButton"] == null)
            {
                DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
                detailButton.Name = "DetailButton";
                detailButton.HeaderText = "Chi tiết";
                detailButton.Text = "Xem";
                detailButton.UseColumnTextForButtonValue = true;
                detailButton.Width = 80;

                detailButton.DefaultCellStyle.BackColor = Color.SkyBlue;
                detailButton.DefaultCellStyle.ForeColor = Color.DarkBlue;
                detailButton.DefaultCellStyle.Font = new Font("Tahoma", 9F, FontStyle.Bold);
                detailButton.FlatStyle = FlatStyle.Standard;
                detailButton.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

                dataGridView1.Columns.Add(detailButton);
            }
        }

        private void CreateMultiSelectComboBox()
        {
            Button btnDropdown = new Button();
            btnDropdown.Text = "Chọn sắp xếp";
            btnDropdown.Dock = DockStyle.Bottom;
            btnDropdown.Height = 35;
            btnDropdown.Font = new Font("Tahoma", 10, FontStyle.Bold);
            btnDropdown.BackColor = Color.LightSlateGray;
            btnDropdown.ForeColor = Color.White;
            btnDropdown.FlatStyle = FlatStyle.Flat;

            // Tạo CheckedListBox
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Items.Add("MANV ASC");
            checkedListBox.Items.Add("MANV DESC");
            checkedListBox.Items.Add("TENNV DESC");
            checkedListBox.Items.Add("TENNV ASC");
            checkedListBox.Items.Add("LUONG ASC");
            checkedListBox.Items.Add("LUONG DESC");
            checkedListBox.CheckOnClick = true;
            checkedListBox.Font = new Font("Tahoma", 10, FontStyle.Bold);
            checkedListBox.BackColor = Color.White;
            checkedListBox.ForeColor = Color.Black;
            checkedListBox.BorderStyle = BorderStyle.FixedSingle;

            // Tạo DropDown chứa CheckedListBox
            ToolStripDropDown dropDown = new ToolStripDropDown { AutoClose = false };
            ToolStripControlHost host = new ToolStripControlHost(checkedListBox)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                AutoSize = false,
                Size = new Size(200, 120)
            };
            dropDown.Items.Add(host);

            btnDropdown.Click += (s, e) =>
            {
                if (dropDown.Visible)
                    dropDown.Close();
                else
                    dropDown.Show(btnDropdown, 0, -host.Size.Height);
            };

            // Xử lý khi tick vào lựa chọn
            checkedListBox.ItemCheck += (s, e) =>
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    var selectedOrders = checkedListBox.CheckedItems.Cast<string>().ToList();

                    if (selectedOrders.Count > 0)
                    {
                        string orderBy = string.Join(", ", selectedOrders);

                        try
                        {

                            DataTable dt = NhanvienQuery.ApplySort(orderBy);
                            dataGridView1.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi sort: " + ex.Message);
                        }
                    }
                });
            };

            // Thêm vào panel2
            panel2.Controls.Add(btnDropdown);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();


            try
            {
                DataTable dt = NhanvienQuery.SearchNhanVien(keyword);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            ADD addForm = new ADD();
            addForm.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
