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
using BusinessLayer;
using BusinessLayer.CHAMCONG_BL;

namespace QLNhanSu.CHAMCONG
{
    public partial class frmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }
        KyCongChiTiet _kcct;
        frmBangCongChiTiet frmBCCT = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        BangCong_NV_CT _bc_nv;


        public string id_nv;
        public string name_nv;
        public string makycong;
        public string _ngay;
        public int _calNgay;

        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KyCongChiTiet();
            _bc_nv = new BangCong_NV_CT();
            lblID.Text=id_nv.ToString();
            lblHoTen.Text=name_nv.ToString();
            string nam = makycong.ToString().Substring(0,4);
            string thang = makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam+"-"+thang+"-"+ngay);
            cldNgayCong.SetDate(_d);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(id_nv.ToString()+makycong.ToString()+" - "+_ngay);
                string fielName = "D" + _calNgay.ToString();
                string _giaTriChamCong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString();
                string _giaTriNgayNghi = rdgLoaiNghi.Properties.Items[rdgLoaiNghi.SelectedIndex].Value.ToString();
                var kcct = _kcct.getItem(makycong, id_nv);

                //double? tongNgayThuong = kcct.TongNgayThuong;
                //double? tongNgayPhep = kcct.NgayPhep;
                //double? tongNgayKhongPhep = kcct.NghiKhongPhep;
                //double? tongNgayLe = kcct.CongNgayLe;

                if ((cldNgayCong.SelectionRange.Start.Year * 100 + cldNgayCong.SelectionRange.Start.Month).ToString() != makycong)
                {
                    MessageBox.Show("Ngoài thời gian kì công, vui lòng chọn từ 1/" + makycong.ToString().Substring(4) + " đến cuối tháng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Funcions.execQuery("UPDATE tb_KyCongChiTiet SET " + fielName + "='" + _giaTriChamCong + "' WHERE MaKyCong = " + makycong + " AND ID_NV =" + id_nv);
                tb_BangCong_NV_CT bcctnv = _bc_nv.getItem(makycong, id_nv, cldNgayCong.SelectionRange.Start.Day);
               
                if (cldNgayCong.SelectionStart.DayOfWeek==DayOfWeek.Sunday)
                {
                    if (_giaTriChamCong=="NN")
                    {
                        bcctnv.NgayChuNhat = 1;
                        bcctnv.NgayThuong = 0;
                    }
                    else
                    {
                        bcctnv.NgayChuNhat = 0.5;
                        bcctnv.NgayThuong = 0;
                    }
                }
                else
                {
                    bcctnv.KyHieu = _giaTriChamCong;
                    switch (_giaTriChamCong)
                    {
                        //Các lí do có xin phép (bệnh, tang gia đình, khẩn cấp,...)
                        case "P":

                            if (_giaTriNgayNghi == "NN")
                            {
                                bcctnv.NgayPhep = 1;
                            }
                            else
                            {
                                bcctnv.NgayThuong = 0.5;
                                bcctnv.NgayPhep = 0.5;

                            }
                            break;
                        //Đi công tác
                        case "CT":
                            if (_giaTriNgayNghi == "NN")
                            {
                                bcctnv.NgayThuong = 1;
                            }
                            else
                            {
                                bcctnv.NgayPhep = 0.5;
                                bcctnv.NgayThuong = 0.5;
                            }
                            break;
                        //Vắng không phép
                        case "V":
                            if (_giaTriNgayNghi == "NN")
                            {
                                bcctnv.NgayThuong = -1;
                                bcctnv.NgayPhep = 0;
                                bcctnv.NgayKhongPhep = 1;
                            }
                            else
                            {
                                bcctnv.NgayKhongPhep = 0.5;
                                bcctnv.NgayThuong = 0.5;
                            }
                            break;
                        default:
                            break;

                    }
                }
               
                _bc_nv.Update(bcctnv);

                double tongNgayPhep = _bc_nv.tongNgayPhep(makycong, id_nv);
                double tongNgayKhongPhep = _bc_nv.tongNgayKhongPhep(makycong, id_nv);
                double tongNgayThuong = _bc_nv.tongNgayThuong(makycong, id_nv);
                double tongCongChuNhat = _bc_nv.tongNgayChuNhat(makycong, id_nv);
                kcct.SoNgayPhep = tongNgayPhep;
                kcct.SoNgayThuong = tongNgayThuong;
                kcct.SoNgayKhongPhep = tongNgayKhongPhep;
                kcct.SoNgayChuNhat = tongCongChuNhat;
                _kcct.Update(kcct);
                frmBCCT.loadBangCong();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cldNgayCong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _calNgay = cldNgayCong.SelectionRange.Start.Day;
        }

        private void rdgChamCong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}