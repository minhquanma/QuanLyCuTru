using QuanLyCuTru.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm.BindingSources
{
    class CuTruBindingSource
    {
        public static void Bind(List<CuTruDTO> list, DataGridView dataGridView)
        {
            BindingSource source = new BindingSource(list, null);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã số", DataPropertyName = "Id" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại cư trú", DataPropertyName = "LoaiCuTru" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày đăng ký", DataPropertyName = "NgayDangKy" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày hết hạn", DataPropertyName = "NgayHetHan" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Địa chỉ", DataPropertyName = "DiaChi" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đã duyệt?", DataPropertyName = "DaDuyet" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời hạn", DataPropertyName = "ThoiHan" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điện thoại", DataPropertyName = "DienThoai" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            dataGridView.DataSource = source;
        }
    }
}
