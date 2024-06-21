using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class ChucVu
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_ChucVu getItem(string id)
        {
            return db.tb_ChucVu.FirstOrDefault(x => x.ID_CV == id);

        }
        public List<tb_ChucVu> getlist()
        {
            return db.tb_ChucVu.ToList();
        }
        public List<ChucVu_DTO> getlistFull()
        {
            List<tb_ChucVu> lstCV= db.tb_ChucVu.ToList();
            List<tb_NhanVien> lstNV = db.tb_NhanVien.ToList();
            List<ChucVu_DTO> list_cv_DTO = new List<ChucVu_DTO>();
            ChucVu_DTO cv;
            foreach (var item in lstCV)
            {
                cv = new ChucVu_DTO();
                cv.ID_CV = item.ID_CV;
                cv.TenCV = item.TenCV;
                cv.SoThanhVien = lstNV.Count(x => x.ID_CV == item.ID_CV);
                cv.Delete_By = item.Delete_By;
                cv.MoTa = item.MoTa;
                list_cv_DTO.Add(cv);

            }
            return list_cv_DTO;
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
        public void Delete(string id, string id_nv)
        {
            try
            {
                var del_cv = db.tb_ChucVu.FirstOrDefault(x => x.ID_CV == id);
                if (del_cv.Delete_By != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có xác nhận sẽ xóa dữ liệu này khỏi database?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        db.tb_ChucVu.Remove(del_cv);
                        db.SaveChanges();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    del_cv.Delete_By = id_nv;
                    del_cv.Delete_Time = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
