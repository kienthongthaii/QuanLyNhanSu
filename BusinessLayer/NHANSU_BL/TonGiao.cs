using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TonGiao
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_TonGiao getItem(string id)
        {
            return db.tb_TonGiao.FirstOrDefault(x => x.ID_TG == id);

        }
        public List<tb_TonGiao> getlist()
        {
            return db.tb_TonGiao.ToList();
        }

        public tb_TonGiao Add(tb_TonGiao tg)
        {
            try
            {
                db.tb_TonGiao.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_TonGiao Update(tb_TonGiao tg)
        {
            try
            {
                var upd_tg = db.tb_TonGiao.FirstOrDefault(x => x.ID_TG == tg.ID_TG);
                upd_tg.TenTG = tg.TenTG;
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(string id)
        {
            try
            {
                var del_tg = db.tb_TonGiao.FirstOrDefault(x => x.ID_TG == id);
                db.tb_TonGiao.Remove(del_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
