using QuanLyCuTru.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm.BindingSources
{
    class NguoiDungBindingSource
    {
        public static void Bind(ICollection<NguoiDungDTO> list, DataGridView dataGridView)
        {
            BindingSource source = new BindingSource(list, null);

            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã số", DataPropertyName = "Id" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ tên", DataPropertyName = "HoTen" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giới tính", DataPropertyName = "StringGioiTinh" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sinh nhật", DataPropertyName = "SinhNhat" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nơi sinh", DataPropertyName = "NoiSinh" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quê quán", DataPropertyName = "QueQuan" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quốc tịch", DataPropertyName = "QuocTich", });
            dataGridView.DataSource = source;
        }
    }
}
