using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class HopDong_DTO
    {
        public string SoHD { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public System.DateTime NgayKetThuc { get; set; }
        public System.DateTime NgayKi { get; set; }
        public int LanKi { get; set; }
        public string NoiDung { get; set; }
        public string ThoiHan { get; set; }
        public double HeSoLuong { get; set; }
        public decimal LuongCoBan { get; set; }
        public string ID_NV { get; set; }
        public string TenNV { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string ID_NV_Duyet { get; set; }
        public string TenNV_Duyet { get; set; }
        public string ID_CV { get; set; }
        public string TenCV { get; set; }
        public string ID_PB { get; set; }
        public string TenPB { get; set; }
        public string ID_BP { get; set; }
        public string TenBP { get; set; }
        public string ID_DT { get; set; }
        public string TenDT { get; set; }
        public string ID_TG { get; set; }
        public string TenTG { get; set; }
        public string ID_TD { get; set; }
        public string TenTD { get; set; }
        public string Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
        public string Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
    }
}
