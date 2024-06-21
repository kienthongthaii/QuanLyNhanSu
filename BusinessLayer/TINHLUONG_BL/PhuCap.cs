using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TINHLUONG_BL
{
    public class PhuCap
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_NhanVien_PhuCap getItem(int id)
        {
            return db.tb_NhanVien_PhuCap.FirstOrDefault(x => x.ID == id);

        }
        public tb_PhuCap getItemPC(string id)
        {
            return db.tb_PhuCap.FirstOrDefault(x => x.ID_PC == id);

        }
        public List<NhanVien_PhuCap_DTO> getlistFull()
        {
            var lst_NVPC = db.tb_NhanVien_PhuCap.ToList();
            List<NhanVien_PhuCap_DTO> lst_DTO = new List<NhanVien_PhuCap_DTO>();
            NhanVien_PhuCap_DTO nvpc;
            NhanVien _nhanVien = new NhanVien();
            foreach (var item in lst_NVPC)
            {
                nvpc = new NhanVien_PhuCap_DTO();
                nvpc.ID = item.ID;
                nvpc.ID_NV = item.ID_NV;
                
                var nv = _nhanVien.getItemFull(item.ID_NV.ToString());
                nvpc.TenNV = nv.TenNV;
                nvpc.TenCV = nv.TenCV;
                nvpc.ID_PC = item.ID_PC;
                var pc = db.tb_PhuCap.FirstOrDefault(x => x.ID_PC == item.ID_PC);
                nvpc.TenPC = pc.TenPC;
                nvpc.NoiDung = item.NoiDung;
                nvpc.NgayKi = item.NgayKi;
                nvpc.Create_By = item.Create_By;
                nvpc.Create_Time = item.Create_Time;
                nvpc.Update_By = item.Update_By;
                nvpc.Update_Time = item.Update_Time;
                nvpc.Delete_By = item.Delete_By;
                nvpc.Delete_Time = item.Delete_Time;
                lst_DTO.Add(nvpc);
            }
            return lst_DTO;
        }
        public List<tb_PhuCap> getlistPC()
        {
            return db.tb_PhuCap.ToList();
        }
        public tb_NhanVien_PhuCap Add(tb_NhanVien_PhuCap nv_pc)
        {
            try
            {
                db.tb_NhanVien_PhuCap.Add(nv_pc);
                db.SaveChanges();
                return nv_pc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_NhanVien_PhuCap Update(tb_NhanVien_PhuCap nv_pc)
        {
            try
            {
                var upd_nv_pc = db.tb_NhanVien_PhuCap.FirstOrDefault(x => x.ID == nv_pc.ID);
                upd_nv_pc.ID_PC = nv_pc.ID_PC;
                upd_nv_pc.ID_NV = nv_pc.ID_NV;
                upd_nv_pc.NgayKi = nv_pc.NgayKi;
                upd_nv_pc.NoiDung = nv_pc.NoiDung;

                upd_nv_pc.Update_By = nv_pc.Update_By;
                upd_nv_pc.Update_Time = DateTime.Now;
                db.SaveChanges();
                return nv_pc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(int id, string user_id)
        {
            try
            {
                var del_nv_pc = db.tb_NhanVien_PhuCap.FirstOrDefault(x => x.ID == id);
                del_nv_pc.Delete_By = user_id;
                del_nv_pc.Delete_Time = DateTime.Now;
                //db.tb_NhanVien_PhuCap.Remove(del_nv_pc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
