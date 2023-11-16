namespace quanlydoannhanh.TK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        private static QLDOAN _context = new QLDOAN();
        [Key]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("taiKhoan")]
        [Required]
        [StringLength(100)]
        public string taiKhoan1 { get; set; }

        [Required]
        [StringLength(200)]
        public string MatKhau { get; set; }
        public static bool KiemTraTaiKhoanVaMatKhau(string taiKhoan1, string MatKhau)
        {
            if (taiKhoan1 is null || MatKhau is null)
            {
                throw new ArgumentNullException(nameof(taiKhoan1));
            }


            return _context.TaiKhoans.Any(tk => tk.taiKhoan1 == taiKhoan1 && tk.MatKhau == MatKhau);

        }

        public static bool KiemTraEmailTonTai(string email)
        {
            if (email is null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            return _context.TaiKhoans.Any(tk => tk.Email == email);
        }
        public static void CapNhatMatKhau(string email, string matKhauMoi)
        {
            var taiKhoan = _context.TaiKhoans.FirstOrDefault(tk => tk.Email == email);
            if (taiKhoan != null)
            {
                taiKhoan.MatKhau = matKhauMoi;
                _context.SaveChanges();
            }
        }
    }
}