using quanlydoannhanh.TK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydoannhanh.dao
{
    internal class HoaDonDAO
    {

        private QLDOAN db;
        public HoaDonDAO()
        {
            db = new QLDOAN();
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return db.HoaDons.ToList();
        }
    }
}
