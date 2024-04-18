using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SinhVien
    {
        public DataTable DanhSachSinhVien()
        {
            string cmd = "SELECT * FROM SinhVien";
            return Connection.selectQuery(cmd);
        }
    }
}
