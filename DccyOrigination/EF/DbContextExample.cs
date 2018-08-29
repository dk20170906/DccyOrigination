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
