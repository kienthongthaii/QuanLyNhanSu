using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class KhenThuongKyLuat_DTO
    {
        public string SoQuyetDinh { get; set; }
        public string LyDo { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> Loai { get; set; }
        public Nullable<int> ID_NV { get; set; }
        public string Ten {  get; set; }

        public Nullable<System.DateTime> TuNgay { get; set; }
        public Nullable<System.DateTime> DenNgay { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
    }
}
