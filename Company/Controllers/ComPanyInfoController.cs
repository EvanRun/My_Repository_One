using Company.Dao;
using System;
using System.Collections.Generic;
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
            com.SelectCompanyInfo();
            return View();
        }
    }
}