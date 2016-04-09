using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    /// <summary>
    /// 招聘类
    /// </summary>
    public class RecruitInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 招聘部门
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 招聘人数
        /// </summary>
        public int RecruitNum { get; set; }

        /// <summary>
        /// 招聘类型
        /// </summary>
        public string RecruitType { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string ReleaseTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// 经验
        /// </summary>
        public string Experience { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        public string Education { get; set; }

        /// <summary>
        /// 岗位描述
        /// </summary>
        public string Des { get; set; }

        /// <summary>
        /// 岗位需求
        /// </summary>
        public string Demand { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }
    }
}