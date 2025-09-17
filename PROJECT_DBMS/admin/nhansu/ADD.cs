using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_DBMS.admin.nhansu
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DriverBox_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = DriverBox.Checked;
        }

        private void nhanvienBox_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = nhanvienBox.Checked;
        }

        private void txtXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateVisibleControls(this))
                return;

            // TODO: lưu dữ liệu
            MessageBox.Show("Đã lưu thành công!");
        }

        private bool ValidateVisibleControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (!c.Visible) continue;

                // Kiểm tra TextBox
                if (c is TextBox tb)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        MessageBox.Show($"Bạn chưa nhập {tb.Name}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb.Focus();
                        return false;
                    }
                }

                // Kiểm tra nhóm CheckBox: nếu Tag = "groupname" => cùng nhóm
                else if (c is Panel pnl)
                {
                    if (!ValidateVisibleControls(pnl)) return false;
                }
                else if (c is CheckBox cb)
                {
                    if (cb.Tag != null)
                    {
                        string group = cb.Tag.ToString();
                        // Lấy tất cả CheckBox cùng nhóm
                        var groupCheckboxes = parent.Controls.OfType<CheckBox>()
                            .Where(x => x.Tag != null && x.Tag.ToString() == group && x.Visible)
                            .ToList();

                        // Nếu không có cái nào được chọn
                        if (!groupCheckboxes.Any(x => x.Checked))
                        {
                            MessageBox.Show($"Bạn chưa chọn {group}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            groupCheckboxes[0].Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
