using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using quanlydoannhanh.TK; 

namespace quanlydoannhanh.dao
{
    internal class BanAnDAO
    {
        private BanAn BanAn = new BanAn();
        private QLDOAN db;

        public BanAnDAO()
        {
            db = new QLDOAN();
        }
        public BanAn getRow(string user)
        {
            BanAn tv = db.BanAns.Where(m => m.TenBanAn == user).FirstOrDefault();
            return tv;
        }
        public void DeleteBanAn(string tenBanAn)
        {
            var banAnToDelete = db.BanAns.SingleOrDefault(b => b.TenBanAn == tenBanAn);

            if (banAnToDelete != null)
            {
                db.BanAns.Remove(banAnToDelete);
                db.SaveChanges();
            }
        }

        public List<BanAn> GetAllBanAn()
        {
            return db.BanAns.ToList();
        }

        public void AddBanAn(BanAn BA)  
        {
            db.BanAns.Add(BA);
            db.SaveChanges();
        }
        public void EditBanAn(BanAn BA)  
        {
            db.Entry(BA).State = EntityState.Modified;
            db.SaveChanges();
        }
       
    }
}
