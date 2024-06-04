using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class BoPhan_DTO
    {
        public int ID_BP { get; set; }
        public string TenBP { get; set; }
        public Nullable<int> ID_PB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> ID_TruongBP { get; set; }
        public string TenTruongBP { get; set; }
        public Nullable<int> SoThanhVien { get; set; }
    }
}
