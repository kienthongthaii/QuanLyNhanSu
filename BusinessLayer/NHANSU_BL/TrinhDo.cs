using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TrinhDo
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_TrinhDo getItem(int id)
        {
            return db.tb_TrinhDo.FirstOrDefault(x => x.ID_TD == id);

        }
        public List<tb_TrinhDo> getlist()
        {
            return db.tb_TrinhDo.ToList();
        }

        public tb_TrinhDo Add(tb_TrinhDo td)
        {
            try
            {
                db.tb_TrinhDo.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_TrinhDo Update(tb_TrinhDo td)
        {
            try
            {
                var upd_td = db.tb_TrinhDo.FirstOrDefault(x => x.ID_TD == td.ID_TD);
                upd_td.TenTD = td.TenTD;
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var del_td = db.tb_TrinhDo.FirstOrDefault(x => x.ID_TD == id);
                db.tb_TrinhDo.Remove(del_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
