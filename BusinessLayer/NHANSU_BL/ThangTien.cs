using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThangTien
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_ThangTien getItem(string soQD)
        {
            return db.tb_ThangTien.FirstOrDefault(x => x.SoQD == soQD);
        }
        public List<tb_ThangTien> getList()
        {
            return db.tb_ThangTien.ToList();
        }
        public List<ThangTien_DTO> getListFull() 
        {
            var lstDCL = db.tb_ThangTien.ToList();
            List<ThangTien_DTO> lstDTO = new List<ThangTien_DTO>();
            ThangTien_DTO dcl_DTO;
            foreach (var item in lstDCL)
            {
                dcl_DTO = new ThangTien_DTO();
                dcl_DTO.SoQD = item.SoQD;
                dcl_DTO.SoHD = item.SoHD;
                dcl_DTO.ID_NV = item.ID_NV;
                dcl_DTO.NgayApDung = item.NgayApDung;
                dcl_DTO.NgayKi = item.NgayKi;
                dcl_DTO.LiDo = item.LiDo;
                dcl_DTO.GhiChu = item.GhiChu;
                dcl_DTO.HeSoLuong_OLD = item.HeSoLuong_OLD;
                dcl_DTO.HeSoLuong_NEW = item.HeSoLuong_NEW;
                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == item.ID_NV);
                dcl_DTO.TenNV = nv.TenNV;
                var cv_c = db.tb_ChucVu.FirstOrDefault(x1 => x1.ID_CV == item.ID_CV_OLD);
                dcl_DTO.TenCV_OLD = cv_c.TenCV;
                var cv_m = db.tb_ChucVu.FirstOrDefault(x2 => x2.ID_CV == item.ID_CV_NEW);
                dcl_DTO.TenCV_NEW = cv_m.TenCV;

                dcl_DTO.Create_By = item.Create_By;
                dcl_DTO.Create_Time = item.Create_Time;
                dcl_DTO.Update_By = item.Update_By;
                dcl_DTO.Update_Time = item.Update_Time;
                dcl_DTO.Delete_By = item.Delete_By;
                dcl_DTO.Delete_Time = item.Delete_Time;

                lstDTO.Add(dcl_DTO);
            }
            return lstDTO;
        }
        public tb_ThangTien Add(tb_ThangTien dcl)
        {
            try
            {
                db.tb_ThangTien.Add(dcl);
                db.SaveChanges();
                return dcl;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_ThangTien Update(tb_ThangTien dcl)
        {
            try
            {
                var upd_dcl = db.tb_ThangTien.FirstOrDefault(x => x.SoQD == dcl.SoQD);
                upd_dcl.SoHD = dcl.SoHD;
                upd_dcl.NgayApDung = dcl.NgayApDung;
                upd_dcl.NgayKi = dcl.NgayKi;
                upd_dcl.LiDo = dcl.LiDo;
                upd_dcl.ID_NV = dcl.ID_NV;
                upd_dcl.GhiChu = dcl.GhiChu;
                upd_dcl.HeSoLuong_NEW = dcl.HeSoLuong_NEW;
                upd_dcl.ID_CV_NEW = dcl.ID_CV_NEW;
                upd_dcl.Update_By = dcl.Update_By;
                upd_dcl.Update_Time = dcl.Update_Time;
                db.SaveChanges();
                return dcl;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string soQD, string id_user)
        {
            try
            {
                var del_dcl = db.tb_ThangTien.FirstOrDefault(x => x.SoQD == soQD);
                del_dcl.Delete_By = id_user;
                del_dcl.Delete_Time = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string soQuyetDinhMAX()
        {
            var _qd = db.tb_ThangTien.OrderByDescending(x => x.Create_Time).FirstOrDefault();
            if (_qd != null)
            {
                return _qd.SoQD;
            }
            else
            {
                return "00000";
            }
        }
    }
}
