using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class TangCa_DTO
    {
        public string ID_TC { get; set; }
        public System.DateTime NgayTC { get; set; }
        public double SoGio { get; set; }
        public string ID_NV { get; set; }
        public string TenNV { get; set; }  
        public double HeSo { get; set; }
        public decimal SoTien { get; set; }
        public string GhiChu { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public string Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public string Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
