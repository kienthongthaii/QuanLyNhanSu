using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CongTy
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_CongTy getItem(int id)
        {
            return db.tb_CongTy.FirstOrDefault(x => x.ID_CT == id);

        }
        public List<tb_CongTy> getlist()
        {
            return db.tb_CongTy.ToList();
        }

        public tb_CongTy Add(tb_CongTy ct)
        {
            try
            {
                db.tb_CongTy.Add(ct);
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_CongTy Update(tb_CongTy ct)
        {
            try
            {
                var upd_ct = db.tb_CongTy.FirstOrDefault(x => x.ID_CT == ct.ID_CT);
                upd_ct.TenCT = ct.TenCT;
                upd_ct.DienThoai = ct.DienThoai;
                upd_ct.Email = ct.Email;
                upd_ct.DiaChi = ct.DiaChi;
                db.SaveChanges();
                return ct;
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
                var del_ct = db.tb_CongTy.FirstOrDefault(x => x.ID_CT == id);
                db.tb_CongTy.Remove(del_ct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
