using BusinessLayer;
using BusinessLayer.CHAMCONG_BL;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.CHAMCONG
{
    public partial class frmChamCong_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmChamCong_NhanVien()
        {
            InitializeComponent();
        }
        NhanVien _nhanVien;
        BangCong_NV_CT _bcnvct;
        KyCongChiTiet _kcct;
        bool _vaoCa=true;
        public string _idNhanVien;
        string _idKyCong = (DateTime.Now.Year*100+DateTime.Now.Month).ToString();
        bool checkChamCong()
        {
            var existingBangCong = _bcnvct.getItem(_idKyCong,_idNhanVien, DateTime.Now.Day);
            if (existingBangCong != null)
            {
                txtChamCong.ForeColor = Color.Green;
                txtChamCong.Text = "Bạn đã chấm công hôm nay rồi, hãy quay lại vào ngày mai nhé! ";
                return true;
                
            }
            else
            {
                txtChamCong.ForeColor = Color.Red;
                txtChamCong.Text = "Bạn chưa chấm công hôm nay! Hãy tiến hành chấm công.";
                return false;
                
            }
        }
        void CapNhatBangCongChiTiet()
        {
            
            _kcct.getItem(_idKyCong,_idNhanVien).SoNgayThuong+=1;
            _kcct.UpdateChamCong(_idKyCong, _idNhanVien, DateTime.Now.Day);
        }
        void SaveData()
        {
            
            tb_BangCong_NV_CT bc = new tb_BangCong_NV_CT();
            if (_vaoCa)
            {
                if (!checkChamCong())
                {
                    bc.MaKyCong = _idKyCong;
                    bc.ID_NV = _idNhanVien;
                    bc.TenNV = _nhanVien.getItem(_idNhanVien).TenNV;
                    bc.Ngay = DateTime.Now;
                    bc.Thu = DateTime.Now.DayOfWeek.ToString();
                    bc.KyHieu = "X";
                    bc.GioVao = DateTime.Now.Hour.ToString();
                    bc.NgayThuong += 1;
                    bc.ID_NV = _idNhanVien;
                   
                    _bcnvct.Add(bc);
                    btnRaCa.Enabled = true;
                    txtChamCong.Text = "Bạn đã VÀO CA lúc : " + DateTime.Now;
                    btnVaoCa.Enabled = false;
                    _vaoCa = false;
                }
                else
                {
                    return;
                }
            }
            else
            {   
                var bco =  _bcnvct.getItem(_idKyCong,_idNhanVien,DateTime.Now.Day);
                bco.GioRa = DateTime.Now.Hour.ToString();
                _bcnvct.Update(bco);
                CapNhatBangCongChiTiet();
            }
        }
        void loadThongTinNhanVien()
        {
            _bcnvct = new BangCong_NV_CT();
            txtCongChuan.Text = Funcions.demSoNgayLamViecTrongThang(DateTime.Now.Month, DateTime.Now.Year).ToString();
            //txtNgayCong.Text = _kcct.getList(_idBangCong)
        }
        private void frmChamCong_NhanVien_Load(object sender, EventArgs e)
        {
            _nhanVien = new NhanVien();
            _kcct = new KyCongChiTiet();
            txtTenNV.Text =  _nhanVien.getItem(_idNhanVien).TenNV;
            loadThongTinNhanVien();
            checkChamCong();
        }
        private void btnVaoCa_Click(object sender, EventArgs e)
        {
                _vaoCa = true;
                SaveData();
                
        }

        private void btnRaCa_Click(object sender, EventArgs e)
        {
            //if (DateTime.Now.Hour<16)
            //{
            //    txtChamCong.Text = "Vui lòng không RA CA quá sớm!";
            //    return;
            //}
            SaveData();
            txtChamCong.Text = "Bạn đã RA CA lúc : " + DateTime.Now;
            btnVaoCa.Enabled = true;
            btnRaCa.Enabled=false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}