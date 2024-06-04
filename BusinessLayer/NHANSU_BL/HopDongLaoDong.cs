using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class HopDongLaoDong
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_HopDong getItem( String soHD)
        {
            return db.tb_HopDong.FirstOrDefault(x=>x.SoHD==soHD);
        }
        public List<tb_HopDong> getList() 
        {
            return db.tb_HopDong.ToList();
        }
        public List<HopDong_DTO> getItemFull(string _soHD)
        {
            List<tb_HopDong> lstHD = db.tb_HopDong.Where(x=>x.SoHD==_soHD).ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hopDong_DTO;
            foreach (var item in lstHD)
            {
                hopDong_DTO = new HopDong_DTO();
                hopDong_DTO.SoHD = item.SoHD;
                hopDong_DTO.NgayBatDau = item.NgayBatDau.ToString("dd/mm/yyyy");//"Từ ngày "+item.NgayBatDau.ToString("dd/mm/yyyy").Substring(0,2)+" tháng "+ item.NgayBatDau.ToString("dd/mm/yyyy").Substring(3, 2) + " năm " + item.NgayBatDau.ToString("dd/mm/yyyy").Substring(6);
                hopDong_DTO.NgayKetThuc = item.NgayKetThuc.ToString("dd/mm/yyyy");
                hopDong_DTO.NgayKy = item.NgayKy.ToString("dd/mm/yyyy");
                hopDong_DTO.LanKy = item.LanKy;
                hopDong_DTO.LuongThoaThuan = item.LuongThoaThuan;
                hopDong_DTO.NoiDung = item.NoiDung;
                hopDong_DTO.ID_NV = item.ID_NV;
                hopDong_DTO.ThoiHan = item.ThoiHan;
                var nv = db.tb_NhanVien.FirstOrDefault(n => n.ID_NV == item.ID_NV);
                hopDong_DTO.TenNV = nv.Ten;
                var cv = db.tb_ChucVu.FirstOrDefault(c => c.ID_CV == nv.ID_CV);    
                hopDong_DTO.TenCV = cv.TenCV;
                hopDong_DTO.DienThoai = nv.DienThoai;
                hopDong_DTO.DiaChi = nv.DiaChi;
                hopDong_DTO.CCCD = nv.CCCD;
                hopDong_DTO.Email = nv.Email;
                hopDong_DTO.NgaySinh = nv.NgaySinh.ToString("dd/mm/yyyy");
                hopDong_DTO.Create_By = item.Create_By;
                hopDong_DTO.Create_Time = item.Create_Time;
                hopDong_DTO.Update_By = item.Update_By;
                hopDong_DTO.Update_Time = item.Update_Time;
                hopDong_DTO.Delete_By = item.Delete_By;
                hopDong_DTO.Delete_Time = item.Delete_Time;
                hopDong_DTO.ID_CT = item.ID_CT;
                lstDTO.Add(hopDong_DTO);
            }
            return lstDTO;
        }

        public List<HopDong_DTO> getListFull()
        {
            List<tb_HopDong> lstHD = db.tb_HopDong.ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hopDong_DTO;
            foreach (var item in lstHD)
            {
                hopDong_DTO = new HopDong_DTO();
                hopDong_DTO.SoHD = item.SoHD;
                hopDong_DTO.NgayBatDau = item.NgayBatDau.ToString("dd/mm/yyyy");
                hopDong_DTO.NgayKetThuc = item.NgayKetThuc.ToString("dd/mm/yyyy");
                hopDong_DTO.NgayKy = item.NgayKy.ToString("dd/mm/yyyy");
                hopDong_DTO.LanKy = item.LanKy;
                hopDong_DTO.LuongThoaThuan = item.LuongThoaThuan;
                hopDong_DTO.NoiDung = item.NoiDung;
                hopDong_DTO.ID_NV = item.ID_NV;
                hopDong_DTO.ThoiHan = item.ThoiHan;
                var nv = db.tb_NhanVien.FirstOrDefault(n=>n.ID_NV == item.ID_NV);
                hopDong_DTO.TenNV = nv.Ten;
                hopDong_DTO.DienThoai = nv.DienThoai;
                hopDong_DTO.DiaChi = nv.DiaChi;
                hopDong_DTO.CCCD = nv.CCCD;
                hopDong_DTO.Email = nv.Email;
                hopDong_DTO.NgaySinh = nv.NgaySinh.ToString("dd/mm/yyyy");
                hopDong_DTO.Create_By = item.Create_By;
                hopDong_DTO.Create_Time = item.Create_Time;
                hopDong_DTO.Update_By = item.Update_By;
                hopDong_DTO.Update_Time = item.Update_Time;
                hopDong_DTO.Delete_By = item.Delete_By;
                hopDong_DTO.Delete_Time = item.Delete_Time;
                hopDong_DTO.ID_CT = item.ID_CT;
                lstDTO.Add(hopDong_DTO);
            }
            return lstDTO;
        }
        public List<HopDong_DTO> getAutoLenLuong()
        {

            DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);
            List<tb_HopDong> lstHD = db.tb_HopDong.Where(x => x.NgayBatDau <= sixMonthsAgo).ToList();
            List<HopDong_DTO> lstDTO = new List<HopDong_DTO>();
            HopDong_DTO hopDong_DTO;
            foreach (var item in lstHD)
            {
                hopDong_DTO = new HopDong_DTO();
                hopDong_DTO.SoHD = item.SoHD;
                hopDong_DTO.NgayBatDau = item.NgayBatDau.ToString("dd/mm/yyyy");
                hopDong_DTO.NgayKetThuc = item.NgayKetThuc.ToString("dd/mm/yyyy");
                hopDong_DTO.NgayKy = item.NgayKy.ToString("dd/mm/yyyy");
                hopDong_DTO.LanKy = item.LanKy;
                hopDong_DTO.LuongThoaThuan = item.LuongThoaThuan;
                hopDong_DTO.NoiDung = item.NoiDung;
                hopDong_DTO.ID_NV = item.ID_NV;
                hopDong_DTO.ThoiHan = item.ThoiHan;
                var nv = db.tb_NhanVien.FirstOrDefault(n => n.ID_NV == item.ID_NV);
                hopDong_DTO.TenNV = nv.Ten;
                hopDong_DTO.DienThoai = nv.DienThoai;
                hopDong_DTO.DiaChi = nv.DiaChi;
                hopDong_DTO.CCCD = nv.CCCD;
                hopDong_DTO.Email = nv.Email;
                hopDong_DTO.NgaySinh = nv.NgaySinh.ToString("dd/mm/yyyy");
                hopDong_DTO.Create_By = item.Create_By;
                hopDong_DTO.Create_Time = item.Create_Time;
                hopDong_DTO.Update_By = item.Update_By;
                hopDong_DTO.Update_Time = item.Update_Time;
                hopDong_DTO.Delete_By = item.Delete_By;
                hopDong_DTO.Delete_Time = item.Delete_Time;
                hopDong_DTO.ID_CT = item.ID_CT;
                lstDTO.Add(hopDong_DTO);
            }
            return lstDTO;
        }
        public tb_HopDong Add(tb_HopDong hd)
        {
            try
            {
                db.tb_HopDong.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public tb_HopDong Update(tb_HopDong hd)
        {
            try
            {
                var upd_hd = db.tb_HopDong.FirstOrDefault(x=>x.SoHD ==hd.SoHD);
                upd_hd.NgayBatDau = hd.NgayBatDau;
                upd_hd.NgayKetThuc = hd.NgayKetThuc;
                upd_hd.NgayKy=hd.NgayKy;
                upd_hd.LanKy=hd.LanKy;
                upd_hd.LuongThoaThuan = hd.LuongThoaThuan;
                upd_hd.ID_NV=hd.ID_NV;
                upd_hd.LuongThoaThuan = hd.LuongThoaThuan;
                upd_hd.NoiDung = hd.NoiDung;
                upd_hd.ThoiHan = hd.ThoiHan;
                upd_hd.SoHD = hd.SoHD;
                upd_hd.ID_CT = hd.ID_CT;
                upd_hd.Update_By = hd.Update_By;
                upd_hd.Update_Time = hd.Update_Time;
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(String soHD, int ID_NV)
        {
            var del_hd = db.tb_HopDong.FirstOrDefault(x => x.SoHD == soHD);
            del_hd.Delete_By = ID_NV;
            del_hd.Delete_Time = DateTime.Now;
            db.SaveChanges();
        }

        public string soHopDongMAX()
        {
            var _hd = db.tb_HopDong.OrderByDescending(x=>x.Create_Time).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SoHD;
            }
            else
            {
                return "00000";
            }
        }
    }
}
