using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiangVien
    {
        public DataTable DanhSachGiangVien()
        {
            string cmd = "SELECT * FROM GiangVien";
            return Connection.selectQuery(cmd);
        }
    }
}
