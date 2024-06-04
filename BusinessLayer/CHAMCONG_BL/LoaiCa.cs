using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CHAMCONG_BL
{
    public class LoaiCa
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_LoaiCa getItem(int id)
        {
            return db.tb_LoaiCa.FirstOrDefault(x => x.ID_LCa == id);

        }
        public List<tb_LoaiCa> getlist()
        {
            return db.tb_LoaiCa.ToList();
        }
        
        public tb_LoaiCa Add(tb_LoaiCa lc)
        {
            try
            {
                db.tb_LoaiCa.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_LoaiCa Update(tb_LoaiCa lca)
        {
            try
            {
                var upd_lca = db.tb_LoaiCa.FirstOrDefault(x => x.ID_LCa == lca.ID_LCa);
                upd_lca.TenLoaiCa = lca.TenLoaiCa;
                upd_lca.HeSo = lca.HeSo;
                upd_lca.Update_By = lca.Update_By;
                upd_lca.Update_Time = DateTime.Now;
                db.SaveChanges();
                return lca;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(int id, int user_id)
        {
            try
            {
                var del_lca = db.tb_LoaiCa.FirstOrDefault(x => x.ID_LCa == id);
                del_lca.Delete_By = user_id;
                del_lca.Delete_Time = DateTime.Now;
                //db.tb_LoaiCa.Remove(del_lca);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
