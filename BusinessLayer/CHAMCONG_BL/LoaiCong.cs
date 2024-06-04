using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CHAMCONG_BL
{
    public class LoaiCong
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_LoaiCong getItem(int id)
        {
            return db.tb_LoaiCong.FirstOrDefault(x => x.ID_LCo == id);

        }
        public List<tb_LoaiCong> getlist()
        {
            return db.tb_LoaiCong.ToList();
        }

        public tb_LoaiCong Add(tb_LoaiCong lco)
        {
            try
            {
                db.tb_LoaiCong.Add(lco);
                db.SaveChanges();
                return lco;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_LoaiCong Update(tb_LoaiCong lco)
        {
            try
            {
                var upd_lco = db.tb_LoaiCong.FirstOrDefault(x => x.ID_LCo == lco.ID_LCo);
                upd_lco.TenLoaiCong = lco.TenLoaiCong;
                upd_lco.HeSo = lco.HeSo;
                upd_lco.Update_By = lco.Update_By;
                upd_lco.Update_Time = DateTime.Now;
                db.SaveChanges();
                return lco;
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
                var del_lco = db.tb_LoaiCong.FirstOrDefault(x => x.ID_LCo == id);
                del_lco.Delete_By = user_id;
                del_lco.Delete_Time = DateTime.Now;
                //db.tb_LoaiCong.Remove(del_lco);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
