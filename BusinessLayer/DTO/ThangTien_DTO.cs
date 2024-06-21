using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class ThangTien_DTO
    {
        public string SoQD { get; set; }
        public string SoHD { get; set; }
        public string ID_NV { get; set; }
        public string TenNV { get; set; }
        public double HeSoLuong_OLD { get; set; }
        public double HeSoLuong_NEW { get; set; }
        public string GhiChu { get; set; }
        public string LiDo { get; set; }
        public System.DateTime NgayApDung { get; set; }
        public System.DateTime NgayKi { get; set; }
        public string ID_CV_OLD { get; set; }
        public string TenCV_OLD { get; set; }
        public string ID_CV_NEW { get; set; }
        public string TenCV_NEW { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public string Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public string Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
