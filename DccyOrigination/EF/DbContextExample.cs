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
        /// <summary>
        /// 延迟初始化数据库连接
        /// </summary>
        private static readonly Lazy<DccyDbContext> lazy =new Lazy<DccyDbContext>(() => new DccyDbContext());
        public static DccyDbContext Db { get { return lazy.Value; } }

        private DbContextExample()
        {
        }
    }
}
