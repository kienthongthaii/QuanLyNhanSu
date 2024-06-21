using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class BoPhan
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_BoPhan getItem(string id)
        {
            return db.tb_BoPhan.FirstOrDefault(x => x.ID_BP == id);

        }
        public List<tb_BoPhan> getlist()
        {
            return db.tb_BoPhan.ToList();
        }
        public List<tb_BoPhan> getlistWithPB(string _id)
        {
            return db.tb_BoPhan.ToList().Where(x=>x.ID_PB ==_id).ToList();
        }
        public List<BoPhan_DTO> getlistFull()
        {
            List<tb_BoPhan> lstBP = db.tb_BoPhan.ToList();
            List<tb_NhanVien> lstNV = db.tb_NhanVien.ToList();
            List<BoPhan_DTO> list_bp_DTO = new List<BoPhan_DTO>();
            BoPhan_DTO bp;
            foreach (var item in lstBP)
            {
                bp = new BoPhan_DTO();
                bp.ID_BP = item.ID_BP;
                bp.TenBP = item.TenBP;
                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == item.ID_TruongBP);
                if (nv != null)
                {
                    bp.TenTruongBP = nv.TenNV;
                }
                else
                {
                    bp.TenTruongBP = "Không có trưởng bộ phận";
                }
                var pb = db.tb_PhongBan.FirstOrDefault(y => y.ID_PB == item.ID_PB);
                bp.TenPB = pb.TenPB;
                bp.SoThanhVien = lstNV.Count(x => x.ID_BP == item.ID_BP);
                bp.Delete_By = item.Delete_By;
                bp.MoTa = item.MoTa;
                list_bp_DTO.Add(bp);

            }
            return list_bp_DTO;
        }
       

        public tb_BoPhan Add(tb_BoPhan bp)
        {
            try
            {
                db.tb_BoPhan.Add(bp);
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_BoPhan Update(tb_BoPhan bp)
        {

            try
            {
                var upd_bp = db.tb_BoPhan.FirstOrDefault(x => x.ID_BP == bp.ID_BP);
                upd_bp.TenBP = bp.TenBP;
                upd_bp.ID_PB = bp.ID_PB;
                upd_bp.ID_TruongBP = bp.ID_TruongBP;
                db.SaveChanges();
                return bp;
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
                var del_bp = db.tb_BoPhan.FirstOrDefault(x => x.ID_BP == id);
                if (del_bp.Delete_By != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có xác nhận sẽ xóa dữ liệu này khỏi database?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        db.tb_BoPhan.Remove(del_bp);
                        db.SaveChanges();
                    }
                    else
                    {
                        return; 
                    }
                }
                else
                {
                    del_bp.Delete_By = id_nv;
                    del_bp.Delete_Time = DateTime.Now;
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
