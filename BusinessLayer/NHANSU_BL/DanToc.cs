using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DanToc
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_DanToc getItem(string id)
        {
            return db.tb_DanToc.FirstOrDefault(x=>x.ID_DT==id);
            
        }
        public List<tb_DanToc> getlist()
        {
            return db.tb_DanToc.ToList();
        }

        public tb_DanToc Add(tb_DanToc dt)
        {
            try
            {
                db.tb_DanToc.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_DanToc Update(tb_DanToc dt) 
        {
            try
            {
               var upd_dt =db.tb_DanToc.FirstOrDefault(x=>x.ID_DT==dt.ID_DT);
                upd_dt.TenDT =dt.TenDT;
                db.SaveChanges();
                return dt;
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
                var del_dt = db.tb_DanToc.FirstOrDefault(x => x.ID_DT == id);
                db.tb_DanToc.Remove(del_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
