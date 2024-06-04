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
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string NgayKy { get; set; }
        public int LanKy { get; set; }
        public string NoiDung { get; set; }
        public string ThoiHan { get; set; }
        public double LuongThoaThuan { get; set; }
        public Nullable<int> ID_NV { get; set; }
        public string TenNV { get; set; }
        public string DienThoai { get; set; }
        public string NgaySinh { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public Nullable<int> ID_PB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> ID_CV { get; set; }
        public string TenCV { get; set; }
        public Nullable<int> ID_BP { get; set; }
        public string TenBP { get; set; }
        public Nullable<int> ID_CT { get; set; }
        public Nullable<int> Delete_By { get; set; }
        public Nullable<System.DateTime> Delete_Time { get; set; }
        public Nullable<int> Update_By { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
        public Nullable<int> Create_By { get; set; }
        public Nullable<System.DateTime> Create_Time { get; set; }
    }
}
