using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.DAL
{
    public class KhoiTaoDatabase: System.Data.Entity.DropCreateDatabaseIfModelChanges<DaiHocContext>
    {
        protected override void Seed(DaiHocContext context)
        {
            var sinhViens = new List<SinhVien>()
            {
                new SinhVien {HoDem = "NguyenTrong",Ten = "An",NgayNhapHoc = DateTime.Parse("2010-01-01")},
                new SinhVien {HoDem = "ThienHieu",Ten = "Hieu",NgayNhapHoc = DateTime.Parse("2015-12-12")}
            };
            sinhViens.ForEach(s=>context.SinhViens.Add(s));
            context.SaveChanges();

            var khoaHocs = new List<KhoaHoc>
            {
                new KhoaHoc {KhoaHocId = 101, TenKhoa = "Cơ sở dự liệu", SoTinChi = 10},
                new KhoaHoc {KhoaHocId = 102, TenKhoa = "Khung lập trình", SoTinChi = 10},
                new KhoaHoc {KhoaHocId = 103, TenKhoa = "Lập trình mobile", SoTinChi = 10}
            };
            khoaHocs.ForEach(kh=>context.KhoaHocs.Add(kh));
            context.SaveChanges();

            var thamGiaHocs = new List<ThamGiaHoc>()
            {
                new ThamGiaHoc {SinhVienId = 1, KhoaHocId = 101, Lop = Lop.Sang},
                new ThamGiaHoc {SinhVienId = 2, KhoaHocId = 102, Lop = Lop.Chieu},
                new ThamGiaHoc {SinhVienId = 2, KhoaHocId = 103, Lop = Lop.Toi}
            };
            thamGiaHocs.ForEach(tgh=>context.ThamGiaHocs.Add(tgh));
            context.SaveChanges();
        }
    }
}