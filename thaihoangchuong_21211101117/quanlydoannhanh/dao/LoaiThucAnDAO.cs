using quanlydoannhanh.TK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydoannhanh.dao
{
    internal class LoaiThucAnDAO
    {
        private QLDOAN TA;
        public LoaiThucAnDAO()
        {
            TA = new QLDOAN();
        }

        public List<LoaiThucAn> GetAllLoaiThucAn()
        {
            return TA.LoaiThucAns.ToList();
        }


        public void AddLoaiThucAn(LoaiThucAn loaiThucAn)
        {
            TA.LoaiThucAns.Add(loaiThucAn);
            TA.SaveChanges();
        }

        public void DeleteLoaiThucAn(int id)
        {
            var loaiThucAnToDelete = TA.LoaiThucAns.SingleOrDefault(l => l.MaLoaiThucAn == id);

            if (loaiThucAnToDelete != null)
            {
                TA.LoaiThucAns.Remove(loaiThucAnToDelete);
                TA.SaveChanges();
            }
        }

        public void EditLoaiThucAn(LoaiThucAn loaiThucAn)
        {
            TA.Entry(loaiThucAn).State = System.Data.Entity.EntityState.Modified;
            TA.SaveChanges();
        }
    }
}
