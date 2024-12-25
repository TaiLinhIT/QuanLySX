using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuanLySX._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySX
{
    public class StartUp
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }
        public StartUp() 
        {
            // Đọc file appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Lấy thư mục hiện tại
                .AddJsonFile("AppSetting.json", optional: false, reloadOnChange: true); // Đọc file JSON

            Configuration = builder.Build(); 
            // Xây dựng cấu hình
            // Đọc AppSetting từ Configuration
            var appSettings = Configuration.GetSection("AppSetting").Get<AppSetting>();

            // Kiểm tra AppSetting có hợp lệ hay không
            if (appSettings == null || appSettings.ConnectionString == null)
            {
                throw new Exception("AppSettings configuration is invalid.");
            }

            // Tạo database với AppSetting
            //CreateDatabase(appSettings);

            // Đăng ký các dịch vụ vào container
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Tạo ServiceProvider
            ServiceProvider = serviceCollection.BuildServiceProvider();

            
        }
        static void CreateDatabase(AppSetting appSetting)
        {
            try
            {
                using var dbContext = new ProductDbContext(appSetting);

                // Lấy tên database từ chuỗi kết nối
                string dbname = dbContext.Database.GetDbConnection().Database;

                // Kiểm tra kết nối trước khi tạo database
                Console.WriteLine($"Checking connection to database: {dbname}");
                using (var connection = dbContext.Database.GetDbConnection())
                {
                    connection.Open(); // Thử mở kết nối
                    Console.WriteLine("Database connection successful!");
                }

                // Tạo database nếu chưa tồn tại
                var result = dbContext.Database.EnsureCreated();
                if (result)
                {
                    Console.WriteLine($"Create database {dbname} successfully");
                }
                else
                {
                    Console.WriteLine($"Database {dbname} already exists");
                }
            }
            catch (SqlException sqlEx)
            {
                // Lỗi liên quan đến SQL Server
                Console.WriteLine($"SQL Exception: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // Lỗi khác
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void DeleteDatabase(AppSetting appSetting)
        {
            using var dbContext = new ProductDbContext(appSetting);
            string dbname = dbContext.Database.GetDbConnection().Database;
            var result = dbContext.Database.EnsureDeleted();
            if (result)
            {
                Console.WriteLine($"Delete database {dbname} successfully");
            }
            else
            {
                Console.WriteLine($"Delete database {dbname} fail");
            }
        }
        public void Run()
        {
            // Lấy Form1 từ DI container và chạy vòng lặp chính
            var mainWindow = ServiceProvider.GetRequiredService<frm_Main>();
            Application.Run(mainWindow);
        }
        private void ConfigureServices(IServiceCollection services)
        {
            // Đọc cấu hình từ appsettings.json
            var appSettings = Configuration.GetSection("AppSetting").Get<AppSetting>();
            if (appSettings == null || appSettings.ConnectionString == null)
            {
                throw new Exception("AppSettings configuration is invalid.");
            }

            // Đăng ký AppSetting để có thể inject ở các nơi khác
            services.AddSingleton(appSettings);

            // Đăng ký ProductDbContext
            services.AddSingleton<ProductDbContext>(provider => new ProductDbContext(appSettings));

            // Đăng ký các Form
            services.AddSingleton<frm_Main>();
        }


    }
}
