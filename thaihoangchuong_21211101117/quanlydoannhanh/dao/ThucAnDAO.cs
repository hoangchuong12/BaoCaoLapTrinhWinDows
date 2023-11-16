using System;
using System.Collections.Generic;
using System.Linq;
using quanlydoannhanh.TK;

namespace quanlydoannhanh.dao
{
    internal class ThucAnDAO
    {
        private QLDOAN TA;

        public ThucAnDAO()
        {
            TA = new QLDOAN();
        }

        public List<ThucAn> GetAllThucAn()
        {
            return TA.ThucAns.ToList();
        }

        public void AddThucAn(ThucAn thucAn)
        {
            TA.ThucAns.Add(thucAn);
            TA.SaveChanges();
        }

        public void DeleteThucAn(int maThucAn)
        {
            var thucAnToDelete = TA.ThucAns.Find(maThucAn);

            if (thucAnToDelete != null)
            {
                TA.ThucAns.Remove(thucAnToDelete);
                TA.SaveChanges();
            }
        }

        public void EditThucAn(ThucAn updatedThucAn)
        {
            var existingThucAn = TA.ThucAns.Find(updatedThucAn.MaThucAn);

            if (existingThucAn != null)
            {
             
                existingThucAn.MaLoaiThucAn = updatedThucAn.MaLoaiThucAn;
                existingThucAn.TenThucAn = updatedThucAn.TenThucAn;
                existingThucAn.GiaThucAn = updatedThucAn.GiaThucAn;

                TA.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("ThucAn not found in the database.");
            }
        }
    }
}
