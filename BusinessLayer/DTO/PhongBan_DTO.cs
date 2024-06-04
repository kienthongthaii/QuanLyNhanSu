using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class PhongBan_DTO
    {
        public int ID_PB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> ID_TruongPB { get; set; }
        public string TenTruongPB { get; set; }
    }
}
