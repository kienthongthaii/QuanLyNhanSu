using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class UngLuong_DTO
    {
        public string ID_UL { get; set; }
        public string ID_NV { get; set; }
        public string TenNV { get; set; }
        public string ID_NV_Duyet { get; set; }
        public string TenNV_Duyet { get; set; }
        public System.DateTime NgayUL { get; set; }
        public System.DateTime NgayKi { get; set; }
        public decimal SoTien { get; set; }
        public string LiDo { get; set; }
        public string GhiChu { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public string Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public string Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
