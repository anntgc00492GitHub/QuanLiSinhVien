using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiSinhVien.Models
{
    public class SinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SinhVienId { set; get; }
        public string HoDem { set; get; }
        public string Ten { set; get; }
        public DateTime NgayNhapHoc { set; get; }
        public virtual ICollection<ThamGiaHoc> ThamGiaHocs { set; get; }
    }
}