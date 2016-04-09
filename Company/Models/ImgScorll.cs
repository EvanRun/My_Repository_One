using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    /// <summary>
    /// 标题图片轮换类
    /// </summary>
    public class ImgScorll
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 轮换地址
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string ReleaseTime { get; set; }
    }
}