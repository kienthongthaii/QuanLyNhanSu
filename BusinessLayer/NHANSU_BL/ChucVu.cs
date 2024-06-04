using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ChucVu
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_ChucVu getItem(int id)
        {
            return db.tb_ChucVu.FirstOrDefault(x => x.ID_CV == id);

        }
        public List<tb_ChucVu> getlist()
        {
            return db.tb_ChucVu.ToList();
        }

        public tb_ChucVu Add(tb_ChucVu cv)
        {
            try
            {
                db.tb_ChucVu.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_ChucVu Update(tb_ChucVu cv)
        {
            try
            {
                var upd_cv = db.tb_ChucVu.FirstOrDefault(x => x.ID_CV == cv.ID_CV);
                upd_cv.TenCV = cv.TenCV;
                db.SaveChanges();
                return cv;
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
                var del_cv = db.tb_ChucVu.FirstOrDefault(x => x.ID_CV == id);
                db.tb_ChucVu.Remove(del_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
