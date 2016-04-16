using Company.Dao;
using Company.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class ComPanyInfoController : Controller
    {
        CompanyInfoDao com = new CompanyInfoDao();
        
        public ActionResult Index()
        {
            DataSet ds = com.SelectCompanyInfo();
            return View(ds);
        }
    }
}