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
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_KhenThuongKyLuat getItem(string id)
        {
            return db.tb_KhenThuongKyLuat.FirstOrDefault(x => x.SoQuyetDinh == id);

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
                kt.SoQuyetDinh = item.SoQuyetDinh;
                kt.Ngay = item.Ngay;
                kt.TuNgay = item.TuNgay;
                kt.DenNgay = item.DenNgay;
                kt.NoiDung = item.NoiDung;
                kt.LyDo = item.LyDo;
                kt.ID_NV = item.ID_NV;

                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV==item.ID_NV);
                kt.Ten = nv.Ten;
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
                var upd_ktkl = db.tb_KhenThuongKyLuat.FirstOrDefault(x => x.SoQuyetDinh == ktkl.SoQuyetDinh);
                upd_ktkl.Ngay = ktkl.Ngay;
                upd_ktkl.TuNgay = ktkl.TuNgay;
                upd_ktkl.DenNgay = ktkl.DenNgay;
                upd_ktkl.LyDo = ktkl.LyDo;
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
        public void Delete(string soQD, int ID_NV)
        {
            try
            {
                var del_ktkl = db.tb_KhenThuongKyLuat.FirstOrDefault(x => x.SoQuyetDinh == soQD);
                del_ktkl.Delete_By = ID_NV;
                del_ktkl.Delete_Time = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }

        public string soQuyetDinhMAX(int loai)
        {
            var _qd = db.tb_KhenThuongKyLuat.Where(x=>x.Loai==loai).OrderByDescending(x => x.Create_Time).FirstOrDefault();
            if (_qd != null)
            {
                return _qd.SoQuyetDinh;
            }
            else
            {
                return "00000";
            }
        }
    }
}

