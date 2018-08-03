using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Models
{
    class NguoiDungRepository : Repository
    {
        protected override void DefineHost()
        {
            host = Server.CongDan;
        }
    }
}
