using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    /// <summary>
    /// 公司信息表
    /// </summary>
    public class CompanyInfo:ICommonModel
    {

        public void AnalyseData(System.Data.DataRow row)
        {
            ID = Convert.ToInt32(row["ID"]);
            ComName = row["ComName"].ToString();
            ComAddress = row["ComAddress"].ToString();
            ComTel = row["ComTel"].ToString();
            ComFax = row["ComFax"].ToString();
            ComPerson = row["ComPerson"].ToString();
            Market = row["Market"].ToString();
            
        }


        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string ComName { get; set; }

        /// <summary>
        /// 公司地址
        /// </summary>
        public string ComAddress { get; set; }

        /// <summary>
        /// 公司联系方式
        /// </summary>
        public string ComTel { get; set; }

        /// <summary>
        /// 公司传真
        /// </summary>
        public string ComFax { get; set; }

        /// <summary>
        /// 公司联系人
        /// </summary>
        public string ComPerson { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Market { get; set; }

        
    }
}