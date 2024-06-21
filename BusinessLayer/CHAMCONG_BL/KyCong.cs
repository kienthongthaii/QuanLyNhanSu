using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KyCong
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_KyCong getItem(string maKyCong)
        {
            return db.tb_KyCong.FirstOrDefault(x => x.MaKyCong == maKyCong);

        }
        public List<tb_KyCong> getlist()
        {
            return db.tb_KyCong.ToList();
        }

        public tb_KyCong Add(tb_KyCong kc)
        {
            try
            {
                db.tb_KyCong.Add(kc);
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_KyCong Update(tb_KyCong kc)
        {
            try
            {
                var upd_kc = db.tb_KyCong.FirstOrDefault(x => x.MaKyCong == kc.MaKyCong);
                upd_kc.MaKyCong = kc.MaKyCong;
                upd_kc.Nam = kc.Nam;
                upd_kc.Thang = kc.Thang;
                upd_kc.Khoa = kc.Khoa;
                upd_kc.CongChuan = kc.CongChuan;
                upd_kc.TrangThai = kc.TrangThai;
                upd_kc.Update_By = kc.Update_By;
                upd_kc.Update_Time = DateTime.Now;
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(string maKyCong, string user_maKyCong)
        {
            try
            {
                var del_kc = db.tb_KyCong.FirstOrDefault(x => x.MaKyCong == maKyCong);
                del_kc.Delete_By = user_maKyCong;
                del_kc.Delete_Time = DateTime.Now;
                //db.tb_KyCong.Remove(del_kc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public bool checkTrangThai(string maKyCong)
        {
           var kc = db.tb_KyCong.FirstOrDefault(x=>x.MaKyCong==maKyCong);
            if (kc==null)
            {
                return false;
            }else
            {
                if (kc.TrangThai == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
