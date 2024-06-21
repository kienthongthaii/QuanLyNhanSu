using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TINHLUONG_BL
{
    public class UngLuong
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_UngLuong getItem(string id)
        {
            return db.tb_UngLuong.FirstOrDefault(x => x.ID_UL == id);

        }
        public List<tb_UngLuong> getlist()
        {
            return db.tb_UngLuong.ToList();
        }
        public List<UngLuong_DTO> getlistFull()
        {
            var lstUngLuong = db.tb_UngLuong.ToList();
            List<UngLuong_DTO> lstDTO = new List<UngLuong_DTO>();
            UngLuong_DTO ul;
            foreach (var item in lstUngLuong)
            {
                ul = new UngLuong_DTO();
                ul.ID_UL = item.ID_UL;
                ul.NgayUL = item.NgayUL;
                ul.NgayKi = item.NgayKi;
                ul.SoTien = item.SoTien;
                ul.ID_NV = item.ID_NV;
                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == item.ID_NV);
                ul.TenNV = nv.TenNV;
                ul.GhiChu = item.GhiChu;
                ul.Create_By = item.Create_By;
                ul.Create_Time = item.Create_Time;
                ul.Update_By = item.Update_By;
                ul.Update_Time = item.Update_Time;
                ul.Delete_By = item.Delete_By;
                ul.Delete_Time = item.Delete_Time;
                lstDTO.Add(ul);


            }
            return lstDTO;
        }

        public tb_UngLuong Add(tb_UngLuong ul)
        {
            try
            {
                db.tb_UngLuong.Add(ul);
                db.SaveChanges();
                return ul;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_UngLuong Update(tb_UngLuong ul)
        {
            try
            {
                var upd_ul = db.tb_UngLuong.FirstOrDefault(x => x.ID_UL == ul.ID_UL);
                upd_ul.NgayUL = ul.NgayUL;
                upd_ul.NgayKi = ul.NgayKi;
                upd_ul.SoTien = ul.SoTien;
                upd_ul.ID_NV = ul.ID_NV;
                upd_ul.GhiChu = ul.GhiChu;
                upd_ul.Update_By = ul.Update_By;
                upd_ul.Update_Time = DateTime.Now;
                db.SaveChanges();
                return ul;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(string id, string user_id)
        {
            try
            {
                var del_ul = db.tb_UngLuong.FirstOrDefault(x => x.ID_UL == id);
                del_ul.Delete_By = user_id;
                del_ul.Delete_Time = DateTime.Now;
                //db.tb_UngLuong.Remove(del_ul);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
