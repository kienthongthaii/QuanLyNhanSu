using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class ChucVu_DTO
    {
        public string ID_CV { get; set; }
        public string TenCV { get; set; }
        public string MoTa { get; set; }
        public int SoThanhVien { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public string Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public string Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
