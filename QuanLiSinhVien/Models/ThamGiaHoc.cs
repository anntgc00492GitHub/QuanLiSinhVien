using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.EnterpriseServices.Internal;

namespace QuanLiSinhVien.Models
{
    public enum Lop
    {
        Sang,Chieu,Toi        
    }

    public class ThamGiaHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ThamGiaId { set; get; }
        public int KhoaHocId { set; get; }
        public int SinhVienId { set; get; }
        public Lop? Lop { set; get; }
        [ForeignKey("KhoaHocId")]
        public virtual KhoaHoc KhoaHoc { set; get; }
        [ForeignKey("SinhVienId")]
        public virtual SinhVien SinhVien { set; get; }
    }
}