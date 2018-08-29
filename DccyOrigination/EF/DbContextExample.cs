using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.EF
{
    /// <summary>
    ///     延迟初始化数据库连接实例
    /// </summary>
    public sealed class DbContextExample
    {
        https://blog.csdn.net/hhhh222222/article/details/77896522
        https://www.cnblogs.com/LibraThinker/p/6086026.html
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("MyConnection");

            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Sets the properties that make up the primary key for this entity type.
            builder.Entity<User>().HasKey(m => m.ID);
            base.OnModelCreating(builder);
        }

        static  IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
      static  IConfigurationRoot configuration = builder.Build();
      static  string conStr = configuration["SqlServerConnectiion"].ToString();
      //  static string conStr = ConfigurationManager.ConnectionStrings["SqlServerConnectiion"].ToString();
     static  DbContextOptions<DccyDbContext> Options = new DbContextOptionsBuilder<DccyDbContext>().UseSqlServer(conStr).Options;
        /// <summary>
        /// 延迟初始化数据库连接
        /// </summary>
        /// 
        private static readonly Lazy<DccyDbContext> lazy =new Lazy<DccyDbContext>(() => new DccyDbContext(Options));
        public static DccyDbContext Db { get { return lazy.Value; } }

        private DbContextExample()
        {
        }
    }
}
