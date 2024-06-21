using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThoiViec
    {
            QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_ThoiViec getItem(string soQD)
        {
            return db.tb_ThoiViec.FirstOrDefault(x=>x.SoQD==soQD);
        }
        public List<tb_ThoiViec> getList() 
        {
            return db.tb_ThoiViec.ToList();        
        }
        public List<ThoiViec_DTO> getListFull()
        {
            var lstTV = db.tb_ThoiViec.ToList();
            List<ThoiViec_DTO> lstDTO = new List<ThoiViec_DTO>();
            ThoiViec_DTO tv_DTO;
            foreach (var item in lstTV)
            {
                tv_DTO = new ThoiViec_DTO();
                tv_DTO.SoQD = item.SoQD;
                tv_DTO.ID_NV = item.ID_NV;
                tv_DTO.NgayNopDon = item.NgayNopDon;
                tv_DTO.NgayThoiViec = item.NgayThoiViec;
                tv_DTO.LyDo = item.LyDo;
                tv_DTO.GhiChu = item.GhiChu;
                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == item.ID_NV);
                tv_DTO.TenNV = nv.TenNV;

                tv_DTO.Create_By = item.Create_By;
                tv_DTO.Create_Time = item.Create_Time;
                tv_DTO.Update_By = item.Update_By;
                tv_DTO.Update_Time = item.Update_Time;
                tv_DTO.Delete_By = item.Delete_By;
                tv_DTO.Delete_Time = item.Delete_Time;

                lstDTO.Add(tv_DTO);
            }
            return lstDTO;
        }
        public tb_ThoiViec Add(tb_ThoiViec tv)
        {
            try
            {
                db.tb_ThoiViec.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: "+ex.Message) ;
            }
        }
        public  tb_ThoiViec Update(tb_ThoiViec tv)
        {
            try
            {
                var upd_tv = db.tb_ThoiViec.FirstOrDefault(x=>x.SoQD==tv.SoQD);
                upd_tv.NgayNopDon = tv.NgayNopDon;
                upd_tv.NgayThoiViec = tv.NgayThoiViec;
                upd_tv.LyDo = tv.LyDo;
                upd_tv.ID_NV = tv.ID_NV;
                upd_tv.GhiChu = tv.GhiChu;
                upd_tv.Update_By = tv.Update_By;
                upd_tv.Update_Time = tv.Update_Time;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string soQD, int id_user)
        {
            try
            {
                var del_tv = db.tb_ThoiViec.FirstOrDefault(x => x.SoQD == soQD);
                del_tv.Delete_By = id_user;
                del_tv.Delete_Time = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string soQuyetDinhMAX()
        {
            var _qd = db.tb_ThoiViec.OrderByDescending(x => x.Create_Time).FirstOrDefault();
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
