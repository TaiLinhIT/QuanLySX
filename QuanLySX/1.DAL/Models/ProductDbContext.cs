using Microsoft.EntityFrameworkCore;

namespace QuanLySX._1.DAL.Models
{
    public class ProductDbContext : DbContext
    {
        private readonly string _connectionString;

        public ProductDbContext(AppSetting appSetting)
        {
            // Thay thế {ServerName} trong chuỗi kết nối
            _connectionString = appSetting.ConnectionString.DefaultConnection.Replace("{ServerName}", appSetting.ServerName);
        }
        DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
