using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTUDCSDLN05_4
{
    public partial class FrmQuanLyNhaCungCap : Form
    {
        public FrmQuanLyNhaCungCap()
        {
            InitializeComponent();
            load_dgv_supplier();
        }

        private void load_dgv_supplier()
        {
            string sql =
                "SELECT * FROM NhaCungCap WHERE "
                + "TenNhaCungCap LIKE '%' + @TenNhaCungCap + '%' AND "
                + "DiaChi LIKE '%' + @DiaChi + '%' AND "
                + "DienThoai LIKE '%' + @DienThoai + '%'";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@TenNhaCungCap", txt_supplier_name.Text);
            dictionary.Add("@DiaChi", txt_supplier_address.Text);
            dictionary.Add("@DienThoai", txt_supplier_phone.Text);
            dgv_supplier_load.DataSource = Database.Query(sql, dictionary);
            btn_supplier_update.Enabled = btn_supplier_delete.Enabled =
                dgv_supplier_load.Rows.Count > 0;
        }

        private bool checkForm()
        {
            bool KetQua = true;
            erp_supplier_error.Clear();
            if (txt_supplier_name.Text == "")
            {
                erp_supplier_error.SetError(txt_supplier_name, "Vui lòng nhập tên nhà cung cấp");
                KetQua = false;
            }
            if (txt_supplier_address.Text == "")
            {
                erp_supplier_error.SetError(
                    txt_supplier_address,
                    "Vui lòng nhập địa chỉ nhà cung cấp"
                );
                KetQua = false;
            }
            if (txt_supplier_phone.Text == "")
            {
                erp_supplier_error.SetError(
                    txt_supplier_phone,
                    "Vui lòng nhập điện thoại nhà cung cấp"
                );
                KetQua = false;
            }
            return KetQua;
        }

        private void btn_supplier_add_Click(object sender, EventArgs e)
        {
            if (!checkForm())
            {
                return;
            }

            string sql =
                "INSERT INTO NhaCungCap(TenNhaCungCap, DiaChi, DienThoai) VALUES(@TenNhaCungCap, @DiaChi, @DienThoai)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@TenNhaCungCap", txt_supplier_name.Text);
            dictionary.Add("@DiaChi", txt_supplier_address.Text);
            dictionary.Add("@DienThoai", txt_supplier_phone.Text);
            try
            {
                Database.Execute(sql, dictionary);
                load_dgv_supplier();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show(
                        "Nhà cung cấp đã tồn tại",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btn_supplier_update_Click(object sender, EventArgs e)
        {
            if (!checkForm())
            {
                return;
            }

            string sql =
                "UPDATE NhaCungCap SET TenNhaCungCap = @TenNhaCungCap, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaNhaCungCap = @MaNhaCungCap";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add(
                "@MaNhaCungCap",
                dgv_supplier_load.CurrentRow.Cells["colMaNhaCungCap"].Value
            );
            dictionary.Add("@TenNhaCungCap", txt_supplier_name.Text);
            dictionary.Add("@DiaChi", txt_supplier_address.Text);
            dictionary.Add("@DienThoai", txt_supplier_phone.Text);
            Database.Execute(sql, dictionary);
            load_dgv_supplier();
        }

        private void btn_supplier_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap";
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add(
                    "@MaNhaCungCap",
                    dgv_supplier_load.CurrentRow.Cells["colMaNhaCungCap"].Value
                );
                Database.Execute(sql, dictionary);
                load_dgv_supplier();
            }
        }

        private void dgv_supplier_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_supplier_name.Text = dgv_supplier_load
                .Rows[e.RowIndex]
                .Cells["colTenNhaCungCap"]
                .Value.ToString();
            txt_supplier_address.Text = dgv_supplier_load
                .Rows[e.RowIndex]
                .Cells["colDiaChiNhaCungCap"]
                .Value.ToString();
            txt_supplier_phone.Text = dgv_supplier_load
                .Rows[e.RowIndex]
                .Cells["colDienThoaiNhaCungCap"]
                .Value.ToString();
        }

        private void btn_find_supplier_Click(object sender, EventArgs e)
        {
            load_dgv_supplier();
        }
    }
}
