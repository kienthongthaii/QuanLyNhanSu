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
        public int ID_NV { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public System.DateTime NgayLam { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public byte[] Anh { get; set; }
        public  bool? DaThoiViec { get; set; }
        public int ID_PB { get; set; }
        public string TenPB { get; set; }
        public int ID_CV { get; set; }
        public string TenCV { get; set; }
        public int ID_BP { get; set; }
        public string TenBP { get; set; }
        public int ID_TD { get; set; }
        public string TenTD { get; set; }
        public int ID_DT { get; set; }
        public string TenDT { get; set; }
        public int ID_TG { get; set; }
        public string TenTG { get; set; }
        public int ID_CT { get; set; }

    }
}
