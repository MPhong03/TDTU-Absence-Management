using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MonHoc
    {
        public DataTable DanhSachMonHoc()
        {
            string cmd = "SELECT * FROM MonHoc";
            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                return result;
            }
            else
            {
                return new DataTable();
            }
        }
        public DTO_MonHoc ChiTietMonHoc(string id)
        {
            string cmd = "SELECT * FROM MonHoc WHERE MaSoMonHoc = '" + id + "'";
            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count <= 0)
            {
                return null;
            }

            DataRow row = result.Rows[0];

            return new DTO_MonHoc(row["MaSoMonHoc"].ToString(), row["TenMonHoc"].ToString(), int.Parse(row["SotinChi"].ToString()));
        }
        public string LayMaMonHocGanNhat()
        {
            string cmd = "SELECT TOP 1 MaSoMonHoc FROM MonHoc ORDER BY MaSoMonHoc DESC";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return row["MaSoMonHoc"].ToString();
            }
            else
            {
                return null;
            }
        }
        public bool ThemMonHoc(DTO_MonHoc monHoc)
        {
            string cmd = "INSERT INTO MonHoc" +
                "(MaSoMonHoc, TenMonHoc, SoTinChi) " +
                "VALUES (" +
                "'" + monHoc.MaSoMonHoc + "', " +
                "N'" + monHoc.TenMonHoc + "', " +
                "'" + monHoc.SoTinChi + "'" + ")";

            return Connection.actionQuery(cmd);
        }
        public bool XoaMonHoc(string id)
        {
            string checkQuery = "SELECT * FROM LopDay WHERE MaSoMonHoc = '" + id + "'";
            DataTable result = Connection.selectQuery(checkQuery);

            int count = result.Rows.Count;

            if (count > 0)
            {
                return false;
            }

            string deleteQuery = "DELETE FROM MonHoc WHERE MaSoMonHoc = '" + id + "'";
            return Connection.actionQuery(deleteQuery);
        }
        public bool ChinhSuaMonHoc(DTO_MonHoc monHoc)
        {
            string cmd = "UPDATE MonHoc SET " +
                "TenMonHoc = N'" + monHoc.TenMonHoc + "', " +
                "SoTinChi = '" + monHoc.SoTinChi.ToString() + "' " +
                "WHERE MaSoMonHoc = '" + monHoc.MaSoMonHoc + "'";

            return Connection.actionQuery(cmd);
        }
    }
}
