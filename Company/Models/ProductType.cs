using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    /// <summary>
    /// 产品类型类
    /// </summary>
    public class ProductType
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string ProdTypeName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Market { get; set; }
    }
}