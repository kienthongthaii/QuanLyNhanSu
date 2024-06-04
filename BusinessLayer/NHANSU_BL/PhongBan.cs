using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PhongBan
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_PhongBan getItem(int id)
        {
            return db.tb_PhongBan.FirstOrDefault(x => x.ID_PB == id);

        }
        public List<tb_PhongBan> getlist()
        {
            return db.tb_PhongBan.ToList();
        }

        public tb_PhongBan Add(tb_PhongBan pb)
        {
            try
            {
                db.tb_PhongBan.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_PhongBan Update(tb_PhongBan pb)
        {
            try
            {
                var upd_pb = db.tb_PhongBan.FirstOrDefault(x => x.ID_PB == pb.ID_PB);
                upd_pb.TenPB = pb.TenPB;
                db.SaveChanges();
                return pb;
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
                var del_pb = db.tb_PhongBan.FirstOrDefault(x => x.ID_PB == id);
                db.tb_PhongBan.Remove(del_pb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
