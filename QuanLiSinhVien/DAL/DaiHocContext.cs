using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.DAL
{
    public class DaiHocContext:DbContext
    {
        public DaiHocContext():base("DaiHocContext")
        {

        }

        public DbSet<SinhVien> SinhViens { set; get; }
        public DbSet<ThamGiaHoc> ThamGiaHocs { set; get; }
        public DbSet<KhoaHoc> KhoaHocs { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}