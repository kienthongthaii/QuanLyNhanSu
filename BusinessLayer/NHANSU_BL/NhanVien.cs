using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NhanVien
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_NhanVien getItem(string id)
        {
            return db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == id);

        }
        public NhanVien_DTO getItemFull(string ID)
        {
            var item = db.tb_NhanVien.FirstOrDefault(x=>x.ID_NV==ID);
            NhanVien_DTO nvDTO = new NhanVien_DTO();
                nvDTO.ID_NV = item.ID_NV;
                nvDTO.TenNV = item.TenNV;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.NgayLam = item.NgayLam;
                nvDTO.DienThoai = item.DienThoai;
                nvDTO.Email = item.Email;
                nvDTO.DiaChi = item.DiaChi;
                nvDTO.CCCD = item.CCCD;
                nvDTO.Anh = item.Anh;
                nvDTO.DaThoiViec = item.DaThoiViec;

                nvDTO.ID_PB = item.ID_PB;
                var pb = db.tb_PhongBan.FirstOrDefault(b => b.ID_PB == item.ID_PB);
                nvDTO.TenPB = pb.TenPB;

                nvDTO.ID_CV = item.ID_CV;
                var cv = db.tb_ChucVu.FirstOrDefault(b => b.ID_CV == item.ID_CV);
                nvDTO.TenCV = cv.TenCV;

                nvDTO.ID_BP = item.ID_BP;
                var bp = db.tb_BoPhan.FirstOrDefault(b => b.ID_BP == item.ID_BP);
                nvDTO.TenBP = bp.TenBP;

                nvDTO.ID_TD = item.ID_TD;
                var td = db.tb_TrinhDo.FirstOrDefault(b => b.ID_TD == item.ID_TD);
                nvDTO.TenTD = td.TenTD;

                nvDTO.ID_DT = item.ID_DT;
                var dt = db.tb_DanToc.FirstOrDefault(b => b.ID_DT == item.ID_DT);
                nvDTO.TenDT = dt.TenDT;

                nvDTO.ID_TG = item.ID_TG;
                var tg = db.tb_TonGiao.FirstOrDefault(b => b.ID_TG == item.ID_TG);
                nvDTO.TenTG = tg.TenTG;

            return nvDTO;
        }
        public List<tb_NhanVien> getlist()
        {
            return db.tb_NhanVien.ToList();
        }

        public List<NhanVien_DTO> getlistFull()
        {
            var lstNV = db.tb_NhanVien.ToList();
            List<NhanVien_DTO> listNVDTO = new List<NhanVien_DTO>();
            NhanVien_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NhanVien_DTO();
                nvDTO.ID_NV = item.ID_NV;
                nvDTO.TenNV = item.TenNV;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.NgayLam = item.NgayLam;
                nvDTO.DienThoai = item.DienThoai;
                nvDTO.Email = item.Email;
                nvDTO.DiaChi = item.DiaChi;
                nvDTO.CCCD = item.CCCD;
                nvDTO.Anh = item.Anh;
                nvDTO.DaThoiViec = item.DaThoiViec;

                nvDTO.ID_PB = item.ID_PB;
                var pb =db.tb_PhongBan.FirstOrDefault(b=>b.ID_PB==item.ID_PB);
                nvDTO.TenPB = pb.TenPB;

                nvDTO.ID_CV = item.ID_CV;
                var cv = db.tb_ChucVu.FirstOrDefault(b => b.ID_CV == item.ID_CV);
                nvDTO.TenCV = cv.TenCV;

                nvDTO.ID_BP = item.ID_BP;
                var bp = db.tb_BoPhan.FirstOrDefault(b => b.ID_BP == item.ID_BP);
                nvDTO.TenBP = bp.TenBP;

                nvDTO.ID_TD = item.ID_TD;
                var td = db.tb_TrinhDo.FirstOrDefault(b => b.ID_TD == item.ID_TD);
                nvDTO.TenTD = td.TenTD;

                nvDTO.ID_DT = item.ID_DT;
                var dt = db.tb_DanToc.FirstOrDefault(b => b.ID_DT == item.ID_DT);
                nvDTO.TenDT = dt.TenDT;

                nvDTO.ID_TG = item.ID_TG;
                var tg = db.tb_TonGiao.FirstOrDefault(b => b.ID_TG == item.ID_TG);
                nvDTO.TenTG = tg.TenTG;

                listNVDTO.Add(nvDTO);

            }
            return listNVDTO; 
        }

        public tb_NhanVien Add(tb_NhanVien nv)
        {
            try
            {
                db.tb_NhanVien.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public tb_NhanVien Update(tb_NhanVien nv)
        {
            try
            {
                var upd_nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == nv.ID_NV);
                upd_nv.TenNV = nv.TenNV;
                upd_nv.GioiTinh = nv.GioiTinh;
                upd_nv.NgaySinh = nv.NgaySinh;
                upd_nv.NgayLam = nv.NgayLam;
                upd_nv.DienThoai = nv.DienThoai;
                upd_nv.DiaChi = nv.DiaChi;
                upd_nv.CCCD = nv.CCCD;
                upd_nv.Email = nv.Email;
                upd_nv.Anh = nv.Anh;
                nv.DaThoiViec = nv.DaThoiViec;
                upd_nv.ID_PB = nv.ID_PB;
                upd_nv.ID_CV = nv.ID_CV;
                upd_nv.ID_BP = nv.ID_BP;
                upd_nv.ID_TD = nv.ID_TD;
                upd_nv.ID_DT = nv.ID_DT;
                upd_nv.ID_TG = nv.ID_TG;
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
        public void Delete(string id)
        {
            try
            {
                var del_nv = db.tb_NhanVien.FirstOrDefault(x => x.ID_NV == id);
                db.tb_NhanVien.Remove(del_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }

        public List<tb_NhanVien> getSinhNhat()
        {
            return db.tb_NhanVien.Where(x => x.NgaySinh.Month == DateTime.Now.Month).ToList();
        }
    }
}
