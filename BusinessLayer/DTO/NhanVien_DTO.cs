using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class NhanVien_DTO
    {
        public string ID_NV { get; set; }
        public string TenNV { get; set; }
        public bool GioiTinh { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public System.DateTime NgayLam { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public byte[] Anh { get; set; }
        public string ID_PB { get; set; }
        public string TenPB { get; set; }
        public string ID_CV { get; set; }
        public string TenCV { get; set; }
        public string ID_BP { get; set; }
        public string TenBP { get; set; }
        public string ID_TD { get; set; }
        public string TenTD { get; set; }
        public string ID_DT { get; set; }
        public string TenDT { get; set; }
        public string ID_TG { get; set; }
        public string TenTG { get; set; }
        public Nullable<bool> DaThoiViec { get; set; }

    }
}
