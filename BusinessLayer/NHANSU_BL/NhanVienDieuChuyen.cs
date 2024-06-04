using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NhanVienDieuChuyen
    {
        QLNS_CELLPHONES_Entities db = new QLNS_CELLPHONES_Entities();
        public tb_DieuChuyen getItem(string id)
        {
            return db.tb_DieuChuyen.FirstOrDefault(x => x.SoQD == id);
        }
        public List<tb_DieuChuyen> getList()
        {
            return db.tb_DieuChuyen.ToList();
        }

        public List<DieuChuyen_DTO> getListFull()
        {
            var lstDC = db.tb_DieuChuyen.ToList();
            List<DieuChuyen_DTO> lstDTO = new List<DieuChuyen_DTO>();
            DieuChuyen_DTO dc_DTO;
            foreach (var item in lstDC)
            {
                dc_DTO = new DieuChuyen_DTO();
                dc_DTO.SoQD = item.SoQD;
                dc_DTO.ID_NV = item.ID_NV;
                dc_DTO.Ngay = item.Ngay;
                dc_DTO.LiDo = item.LiDo;
                dc_DTO.GhiChu = item.GhiChu;
                var nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == item.ID_NV);
                dc_DTO.Ten = nv.Ten;
                var pb = db.tb_PhongBan.FirstOrDefault(p => p.ID_PB == item.ID_PB);
                dc_DTO.TenPB = pb.TenPB;
                var pb_New = db.tb_PhongBan.FirstOrDefault(p2 => p2.ID_PB == item.ID_PBNew);
                dc_DTO.TenPBNEW = pb_New.TenPB;
                var bp = db.tb_BoPhan.FirstOrDefault(p3 => p3.ID_BP == item.ID_BP);
                dc_DTO.TenBP = bp.TenBP;
                var bp_New = db.tb_BoPhan.FirstOrDefault(p4 => p4.ID_BP == item.ID_BPNew);
                dc_DTO.TenBPNEW = bp_New.TenBP;

                dc_DTO.Create_By = item.Create_By;
                dc_DTO.Create_Time = item.Create_Time;
                dc_DTO.Update_By = item.Update_By;
                dc_DTO.Update_Time = item.Update_Time;
                dc_DTO.Delete_By = item.Delete_By;
                dc_DTO.Delete_Time = item.Delete_Time;

                lstDTO.Add(dc_DTO);
            }
            return lstDTO;
        }
        public tb_DieuChuyen Add(tb_DieuChuyen dc)
        {
            try
            {
                db.tb_DieuChuyen.Add(dc);
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi : "+ex.Message);
            }
        }
        public tb_DieuChuyen Update(tb_DieuChuyen dc)
        {
            try
            {
                var upd_dc = db.tb_DieuChuyen.FirstOrDefault(x=>x.SoQD==dc.SoQD);
                upd_dc.Ngay = dc.Ngay;
                upd_dc.ID_PBNew = dc.ID_PBNew;
                upd_dc.ID_BPNew = dc.ID_BPNew;
                upd_dc.ID_NV = dc.ID_NV;
                upd_dc.LiDo = dc.LiDo;
                upd_dc.GhiChu = dc.GhiChu;
                upd_dc.Update_By = dc.Update_By;
                upd_dc.Update_Time = dc.Update_Time;
                db.SaveChanges();
                return upd_dc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(string soQD, int IDUser)
        {
            try
            {
                var del_dc = db.tb_DieuChuyen.FirstOrDefault(x => x.SoQD == soQD);
                del_dc.Delete_By = IDUser;
                del_dc.Delete_Time = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi : " + ex.Message);
            }
        }

        public string soQuyetDinhMAX()
        {
            var _qd = db.tb_DieuChuyen.OrderByDescending(x => x.Create_Time).FirstOrDefault();
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
