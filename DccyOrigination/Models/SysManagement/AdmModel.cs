using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Models.SysManagement
{
    /// <summary>
    /// 系统管理父类
    /// </summary>
    public class AdmModel
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 父Id
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// guid
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 父GUiD
        /// </summary>
        public string PGuid { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
