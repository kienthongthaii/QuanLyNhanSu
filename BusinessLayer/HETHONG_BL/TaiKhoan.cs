using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.HETHONG_BL
{
    public class TaiKhoan
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_SYS_User getItem(int id)
        {
            return db.tb_SYS_User.FirstOrDefault(x => x.ID == id);

        }
        public List<tb_SYS_User> getlist()
        {
            return db.tb_SYS_User.ToList();
        }
        

        public tb_SYS_User Add(tb_SYS_User lc)
        {
            try
            {
                db.tb_SYS_User.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_SYS_User Update(tb_SYS_User user)
        {
            try
            {
                var upd_user = db.tb_SYS_User.FirstOrDefault(x => x.ID == user.ID);
                upd_user.UserName = user.UserName;
                upd_user.PassWord = user.PassWord;
                upd_user.Last_PWD_Change = DateTime.Now;
                upd_user.Disable = user.Disable;
                db.SaveChanges();
                return user;
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
                var del_user = db.tb_SYS_User.FirstOrDefault(x => x.ID == id);
                //del_user.Delete_By = user_id;
                //del_user.Delete_Time = DateTime.Now;
                db.tb_SYS_User.Remove(del_user);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
