using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_DBMS.SQL;

namespace PROJECT_DBMS.admin.nhansu
{
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
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

        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("NhanVienForm_Load được gọi!");
            LoadNhanVienData();
        }

        private void LoadNhanVienData()
        {
            try
            {
                DataTable dt = NhanvienQuery.GetAllNhanVien(); // Lấy DataTable từ Repository
                dataGridView1.DataSource = dt;             // Bind DataTable vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
