using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    /// <summary>
    /// 产品类
    /// </summary>
    public class ProductInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProName { get; set; }

        /// <summary>
        /// 产品单价
        /// </summary>
        public double ProPrice { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public int ProNum { get; set; }

        /// <summary>
        /// 产品介绍
        /// </summary>
        public string ProIntro { get; set; }

        /// <summary>
        /// 产品详细
        /// </summary>
        public string ProDetail { get; set; }

        /// <summary>
        /// 产品图片URL
        /// </summary>
        public string ProImgUrl { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public int ProType { get; set; }

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