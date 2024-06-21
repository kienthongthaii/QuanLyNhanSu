using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.HETHONG_BL
{
    public class NhanVien_ChamCong
    {
        QuanLyNhanSu_MasterEntities db = new QuanLyNhanSu_MasterEntities();
        public tb_SYS_User getItem(int id)
        {
            return db.tb_SYS_User.FirstOrDefault(x => x.ID == id);

        }
    }
}
