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
        public Nullable<System.DateTime> NgayNopDon { get; set; }
        public Nullable<System.DateTime> NgayThoiViec { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
        public int ID_NV { get; set; }
        public string Ten {  get; set; }
    }
}
