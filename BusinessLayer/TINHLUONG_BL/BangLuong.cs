using DataLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TINHLUONG_BL
{
    public class BangLuong
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();

        public tb_BangLuong getItem(string maKyCong, string ID_NV )
        {
            return db.tb_BangLuong.FirstOrDefault(x => x.MaKyCong == maKyCong && x.ID_NV == ID_NV );
        }
        public List<tb_BangLuong> getList(string maKyCong)
        {
            return db.tb_BangLuong.Where(x => x.MaKyCong == maKyCong).ToList();
        }
        public void tinhLuongNhanVien(string maKyCong)
        {
            decimal luongNgayThuong, luongNgayPhep, luongTangCa, luongChuNhat, luongNgayLe,luongKhongPhep, phuCap, ungLuong, thucLanh, heSoLuong;
            var lstNV = db.tb_NhanVien.Where(x=>x.DaThoiViec==null).ToList();

            foreach (var item in lstNV)
            {
                //Nhân viên chưa thôi việc
                var hd = db.tb_HopDong.FirstOrDefault(x => x.ID_NV == item.ID_NV && x.Delete_By == null);
                if (hd!=null)
                {
                    
                    var kcct = db.tb_KyCongChiTiet.FirstOrDefault(x => x.MaKyCong == maKyCong && x.ID_NV == item.ID_NV);
                    var nangLuong = db.tb_ThangTien.OrderByDescending(x => x.NgayKi).FirstOrDefault(x => x.SoHD == hd.SoHD&& x.Delete_By ==null);
                    //Kiểm tra khi đã nâng lương
                    if (nangLuong != null)
                    {
                        heSoLuong = Convert.ToDecimal(nangLuong.HeSoLuong_NEW);
                    }
                    else
                    {
                        heSoLuong = Convert.ToDecimal(hd.HeSoLuong);
                    }
                    var luong1NgayCong = hd.LuongCoBan * heSoLuong / kcct.CongChuan;
                    //Lương ngày thường
                    luongNgayThuong = Convert.ToDecimal((decimal)kcct.SoNgayThuong * luong1NgayCong);
                    luongNgayPhep = Convert.ToDecimal((decimal)kcct.SoNgayPhep * luong1NgayCong*(3/10));
                    luongChuNhat = Convert.ToDecimal((decimal)kcct.SoNgayChuNhat * luong1NgayCong * 2);
                    luongKhongPhep = Convert.ToDecimal((decimal)kcct.SoNgayKhongPhep*luong1NgayCong*(15/10));
                    luongNgayLe = Convert.ToDecimal((decimal)kcct.SoNgayLe * luong1NgayCong * 3);
                    luongTangCa = Convert.ToDecimal(db.tb_TangCa.Where(x =>x.NgayTC.ToString().Substring(0,6) == maKyCong && x.ID_NV == item.ID_NV).Sum(x => x.SoTien));
                    phuCap = 0;/*Convert.ToDecimal(db.tb_NhanVien_PhuCap.Where(x => x.ID_NV == item.ID_NV).Sum(db.tb_PhuCap.Where(t=>t.ID_PC==x.ID_PC));*/
                    ungLuong = Convert.ToDecimal(db.tb_UngLuong.Where(x => x.NgayUL.ToString().Substring(0, 6) == maKyCong && x.ID_NV == item.ID_NV).Sum(x => x.SoTien));

                    thucLanh = luongNgayThuong + luongNgayPhep + luongTangCa + luongNgayLe + luongChuNhat + phuCap - ungLuong - luongKhongPhep;

                    tb_BangLuong bl = new tb_BangLuong();
                    bl.MaKyCong = maKyCong;
                    bl.ID_NV = item.ID_NV;
                    bl.LuongNgayThuong = luongNgayThuong;
                    bl.LuongNgayLe = luongNgayPhep;
                    bl.LuongNgayKhongPhep = luongKhongPhep;
                    bl.LuongNgayChuNhat = luongChuNhat;
                    bl.LuongNgayLe = luongNgayLe;
                    bl.PhuCap = phuCap;
                    bl.TangCa = luongTangCa;
                    bl.UngLuong = ungLuong;
                    bl.ThucLanh = thucLanh;
                    bl.Create_By = "1";
                    bl.Create_Time = DateTime.Now;
                    Add(bl);
                }
            }
        }
        public tb_BangLuong Add(tb_BangLuong blct)
        {
            try
            {
                db.tb_BangLuong.Add(blct);
                db.SaveChanges();
                return blct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_BangLuong Update(tb_BangLuong bl)
        {
            try
            {
                tb_BangLuong upd_bl = db.tb_BangLuong.FirstOrDefault(x => x.MaKyCong == bl.MaKyCong && x.ID_NV == bl.ID_NV);
                upd_bl.ID_NV = bl.ID_NV;
                upd_bl.MaKyCong = bl.MaKyCong;
                upd_bl.LuongNgayThuong = bl.LuongNgayThuong;
                upd_bl.LuongNgayPhep = bl.LuongNgayPhep;
                upd_bl.LuongNgayKhongPhep = bl.LuongNgayKhongPhep;
                upd_bl.LuongNgayLe = bl.LuongNgayLe;
                upd_bl.LuongNgayChuNhat = bl.LuongNgayChuNhat;
                upd_bl.TangCa = bl.TangCa;
                upd_bl.PhuCap = bl.PhuCap;
                upd_bl.UngLuong = bl.UngLuong;
                upd_bl.ThucLanh = bl.ThucLanh;
                upd_bl.Update_By = "1";
                upd_bl.Update_Time = DateTime.Now;
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
