using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TINHLUONG_BL
{
    public class TangCa
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_TangCa getItem(string id)
        {
            return db.tb_TangCa.FirstOrDefault(x => x.ID_TC == id);

        }
        public List<tb_TangCa> getlist()
        {
            return db.tb_TangCa.ToList();
        }
        public List<TangCa_DTO> getlistFull()
        {
            var lstTangCa = db.tb_TangCa.ToList();
            List<TangCa_DTO> lstDTO = new List<TangCa_DTO>();
            TangCa_DTO tc;
            foreach (var item in lstTangCa)
            {
                tc = new TangCa_DTO();
                tc.ID_TC = item.ID_TC;
                tc.NgayTC = item.NgayTC;
                tc.SoGio = item.SoGio;
                
                tc.ID_NV = item.ID_NV;
                var nv = db.tb_NhanVien.FirstOrDefault(x=>x.ID_NV == item.ID_NV);
                tc.TenNV = nv.TenNV;
                tc.HeSo = item.HeSo;
                tc.SoTien = tc.SoTien;
                tc.GhiChu = item.GhiChu;
                tc.Create_By = item.Create_By;
                tc.Create_Time = item.Create_Time;
                tc.Update_By = item.Update_By;
                tc.Update_Time = item.Update_Time;
                tc.Delete_By = item.Delete_By;
                tc.Delete_Time = item.Delete_Time;  
                lstDTO.Add(tc);


            }
            return lstDTO;
        }

        public tb_TangCa Add(tb_TangCa tc)
        {
            try
            {
                db.tb_TangCa.Add(tc);
                db.SaveChanges();
                return tc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_TangCa Update(tb_TangCa tc)
        {
            try
            {
                var upd_tc = db.tb_TangCa.FirstOrDefault(x => x.ID_TC == tc.ID_TC);
                upd_tc.NgayTC = tc.NgayTC;
                upd_tc.SoGio = tc.SoGio;
                upd_tc.ID_NV = tc.ID_NV;
                upd_tc.SoTien = tc.SoTien;
                upd_tc.GhiChu = tc.GhiChu;
                upd_tc.Update_By = tc.Update_By;
                upd_tc.Update_Time = DateTime.Now;
                db.SaveChanges();
                return tc;
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
                var del_tc = db.tb_TangCa.FirstOrDefault(x => x.ID_TC == id);
                del_tc.Delete_By = user_id;
                del_tc.Delete_Time = DateTime.Now;
                //db.tb_TangCa.Remove(del_tc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
