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
    public class PhongBan
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_PhongBan getItem(string id)
        {
            return db.tb_PhongBan.FirstOrDefault(x => x.ID_PB == id);

        }
        public List<tb_PhongBan> getlist()
        {
            return db.tb_PhongBan.ToList();
        }

        public List<PhongBan_DTO> getlistFull()
        {
            List<tb_PhongBan> lstPB = db.tb_PhongBan.ToList();
            List<tb_NhanVien> lstNV = db.tb_NhanVien.ToList();
            List<PhongBan_DTO> list_pb_DTO = new List<PhongBan_DTO>();
            PhongBan_DTO pb;
            foreach (var item in lstPB)
            {
                pb = new PhongBan_DTO();
                pb.ID_PB = item.ID_PB;
                pb.TenPB = item.TenPB;
                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == item.ID_TruongPB);
                if (nv != null)
                {
                    pb.TenTruongPB = nv.TenNV;
                }
                else
                {
                    pb.TenTruongPB = "Không có trưởng phòng ban";
                }
                pb.SoThanhVien = lstNV.Count(x => x.ID_PB == item.ID_PB);
                pb.Delete_By = item.Delete_By;
                pb.MoTa = item.MoTa;
                list_pb_DTO.Add(pb);

            }
            return list_pb_DTO;
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
        public void Delete(string id, string id_nv)
        {
            try
            {
                var del_pb = db.tb_PhongBan.FirstOrDefault(x => x.ID_PB == id);
                if (del_pb.Delete_By != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có xác nhận sẽ xóa dữ liệu này khỏi database?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        db.tb_PhongBan.Remove(del_pb);
                        db.SaveChanges();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    del_pb.Delete_By = id_nv;
                    del_pb.Delete_Time = DateTime.Now;
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
