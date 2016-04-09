using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    /// <summary>
    /// 留言类
    /// </summary>
    public class NickInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 留言昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        public string NickContent { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 留言时间
        /// </summary>
        public string NickTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Market { get; set; }
    }
}