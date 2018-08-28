using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.EF
{
    /// <summary>
    ///     延迟初始化数据库连接实例
    /// </summary>
    public sealed class DbContextExample
    {

      static  DbContextOptions<DccyDbContext> Options = new DbContextOptionsBuilder<DccyDbContext>().UseSqlServer("").Options;
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
