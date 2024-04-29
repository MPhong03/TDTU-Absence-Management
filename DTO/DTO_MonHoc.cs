using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        public string MaSoMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTinChi { get; set; }
        public DTO_MonHoc(string MaSoMonHoc, string TenMonHoc, int SoTinChi)
        {
            this.MaSoMonHoc = MaSoMonHoc;
            this.TenMonHoc = TenMonHoc;
            this.SoTinChi = SoTinChi;
        }
    }
}
