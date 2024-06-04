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
        public Nullable<int> ID_NV { get; set; }
        public string Ten {  get; set; }
        public Nullable<double> LuongThoaThuan_OLD { get; set; }
        public Nullable<double> LuongThoaThuan_NEW { get; set; }
        public Nullable<System.DateTime> NgayApDung { get; set; }
        public Nullable<System.DateTime> NgayKy { get; set; }
        public string GhiChu { get; set; }
        public string LyDo { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
        public Nullable<int> ID_CV_Old { get; set; }
        public string TenCV_Old { get; set; }
        public Nullable<int> ID_CV_New { get; set; }
        public string TenCV_New { get; set; }
    }
}
