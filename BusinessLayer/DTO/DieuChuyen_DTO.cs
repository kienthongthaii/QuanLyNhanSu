using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class DieuChuyen_DTO
    {
        public string SoQD { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> ID_NV { get; set; }
        public string Ten { get; set; }
        public Nullable<int> ID_PB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> ID_BP { get; set; }
        public string TenBP { get; set; }
        public Nullable<int> ID_PBNew { get; set; }
        public string TenPBNEW { get; set; }
        public Nullable<int> ID_BPNew { get; set; }
        public string TenBPNEW { get; set; }
        public string LiDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
