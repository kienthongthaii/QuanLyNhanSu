using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KhenThuong_KyLuat
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_KhenThuongKyLuat getItem(string id)
        {
            return db.tb_KhenThuongKyLuat.FirstOrDefault(x => x.SoQD == id);

        }
        public List<tb_KhenThuongKyLuat> getlist(int loai)
        {
            return db.tb_KhenThuongKyLuat.Where(x=>x.Loai==loai ).ToList();
        }

        public List<KhenThuongKyLuat_DTO> getlistFull(int loai)
        {
            List<tb_KhenThuongKyLuat> lstKT = db.tb_KhenThuongKyLuat.Where(x=>x.Loai==loai).ToList();
            List<KhenThuongKyLuat_DTO> list_kt_DTO = new List<KhenThuongKyLuat_DTO>();
            KhenThuongKyLuat_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KhenThuongKyLuat_DTO();
                kt.SoQD = item.SoQD;
                kt.NgayKi = item.NgayKi;
                kt.TuNgay = item.TuNgay;
                kt.DenNgay = item.DenNgay;
                kt.NoiDung = item.NoiDung;
                kt.LiDo = item.LiDo;
                kt.ID_NV = item.ID_NV;

                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV==item.ID_NV);
                kt.TenNV = nv.TenNV;
                kt.Create_By = item.Create_By;
                kt.Create_Time = item.Create_Time;
                kt.Update_By = item.Update_By;
                kt.Update_Time = item.Update_Time;
                kt.Delete_By = item.Delete_By;
                kt.Delete_Time = item.Delete_Time;
                list_kt_DTO.Add(kt);

            }
            return list_kt_DTO;
        }

        public tb_KhenThuongKyLuat Add(tb_KhenThuongKyLuat ktkl)
        {
            try
            {
                db.tb_KhenThuongKyLuat.Add(ktkl);
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_KhenThuongKyLuat Update(tb_KhenThuongKyLuat ktkl)
        {
            try
            {
                var upd_ktkl = db.tb_KhenThuongKyLuat.FirstOrDefault(x => x.SoQD == ktkl.SoQD);
                upd_ktkl.NgayKi = ktkl.NgayKi;
                upd_ktkl.TuNgay = ktkl.TuNgay;
                upd_ktkl.DenNgay = ktkl.DenNgay;
                upd_ktkl.LiDo = ktkl.LiDo;
                upd_ktkl.NoiDung = ktkl.NoiDung;
                upd_ktkl.Loai = ktkl.Loai;
                upd_ktkl.Update_By = ktkl.Update_By;
                upd_ktkl.Update_Time = ktkl.Update_Time;
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(string soQD, string ID_NV)
        {
            try
            {
                var del_ktkl = db.tb_KhenThuongKyLuat.FirstOrDefault(x => x.SoQD == soQD);
                del_ktkl.Delete_By = ID_NV;
                del_ktkl.Delete_Time = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }

        public string SoQDMAX(int loai)
        {
            var _qd = db.tb_KhenThuongKyLuat.Where(x=>x.Loai==loai).OrderByDescending(x => x.Create_Time).FirstOrDefault();
            if (_qd != null)
            {
                return _qd.SoQD;
            }
            else
            {
                return "00000";
            }
        }
    }
}

