using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLiSinhVien.Models
{
    public class KhoaHoc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KhoaHocId { set; get; }
        public string TenKhoa { set; get; }
        public int SoTinChi { set; get; }
        public virtual ICollection<ThamGiaHoc> ThamGiaHocs { set; get; }
    }
}