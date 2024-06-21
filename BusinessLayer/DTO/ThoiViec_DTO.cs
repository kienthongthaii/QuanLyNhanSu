using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class ThoiViec_DTO
    {
        public string SoQD { get; set; }
        public string ID_NV { get; set; }
        public string TenNV { get; set; }
        public string ID_NV_Duyet { get; set; }
        public string TenNV_Duyet { get; set; }
        public System.DateTime NgayKi { get; set; }
        public System.DateTime NgayNopDon { get; set; }
        public System.DateTime NgayThoiViec { get; set; }
        public string TrangThai { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
