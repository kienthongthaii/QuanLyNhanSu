using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class PhongBan_DTO
    {
        public string ID_PB { get; set; }
        public string TenPB { get; set; }
        public string ID_TruongPB { get; set; }
        public string TenTruongPB { get; set; }
        public string MoTa { get; set; }
        public string Create_By { get; set; }
        public int SoThanhVien { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public string Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public string Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
