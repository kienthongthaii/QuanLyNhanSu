using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CHAMCONG_BL
{
    public class BangCong_NV_CT
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
       
        public tb_BangCong_NV_CT getItem(string maKyCong, string ID_NV, int ngay) 
        {
            return db.tb_BangCong_NV_CT.FirstOrDefault(x => x.MaKyCong == maKyCong && x.ID_NV == ID_NV && x.Ngay.Day == ngay);
        }
       
        public List<tb_BangCong_NV_CT> getBangCongCT(string maKyCong, string ID_NV)
        {
            return db.tb_BangCong_NV_CT.Where(x => x.MaKyCong == maKyCong && x.ID_NV == ID_NV).ToList();
        }
        public tb_BangCong_NV_CT Add(tb_BangCong_NV_CT bcnvct)
        {
            try
            {
                db.tb_BangCong_NV_CT.Add(bcnvct);
                db.SaveChanges();
                return bcnvct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: "+ex.Message);
            }
        }
        public tb_BangCong_NV_CT Update(tb_BangCong_NV_CT bcnvct)
        {
            try
            {
               tb_BangCong_NV_CT bcnv =db.tb_BangCong_NV_CT.FirstOrDefault(x=>x.MaKyCong==bcnvct.MaKyCong && x.Ngay == bcnvct.Ngay.Date && x.ID_NV==bcnvct.ID_NV);
                bcnv.KyHieu = bcnvct.KyHieu;
                bcnv.GioVao = bcnv.GioVao;
                bcnv.GioRa = bcnvct.GioRa;
                bcnv.NgayPhep = bcnvct.NgayPhep;
                bcnv.NgayKhongPhep = bcnvct.NgayKhongPhep;
                bcnv.NgayChuNhat = bcnvct.NgayChuNhat;
                bcnv.NgayLe = bcnvct.NgayLe;
                bcnv.GhiChu = bcnvct.GhiChu;
                bcnv.Update_By = "1";
                bcnv.Update_Time = DateTime.Now;
                db.SaveChanges();
                return bcnv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public double tongNgayPhep(string maKyCong, string ID_NV)
        {
            return db.tb_BangCong_NV_CT.Where(x=>x.MaKyCong==maKyCong&&x.ID_NV==ID_NV).ToList().Sum(p=>p.NgayPhep ?? 0);
        }
        public double tongNgayThuong(string maKyCong, string ID_NV)
        {
            return db.tb_BangCong_NV_CT.Where(x => x.MaKyCong == maKyCong && x.ID_NV == ID_NV).ToList().Sum(p => p.NgayThuong ?? 0);
        }
        public double tongNgayKhongPhep(string maKyCong, string ID_NV)
        {
            return db.tb_BangCong_NV_CT.Where(x => x.MaKyCong == maKyCong && x.ID_NV == ID_NV).ToList().Sum(p => p.NgayKhongPhep ?? 0);
        }
        public double tongNgayChuNhat(string maKyCong, string ID_NV)
        {
            return db.tb_BangCong_NV_CT.Where(x => x.MaKyCong == maKyCong && x.ID_NV == ID_NV).ToList().Sum(p => p.NgayChuNhat ?? 0);
        }
        public double tongNgayLe(string maKyCong, string ID_NV)
        {
            return db.tb_BangCong_NV_CT.Where(x => x.MaKyCong == maKyCong && x.ID_NV == ID_NV).ToList().Sum(p => p.NgayLe ?? 0);
        }

    }
}
