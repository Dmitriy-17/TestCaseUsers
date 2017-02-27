using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestCaseUsers.Entity;
using TestCaseUsers.Models;

namespace TestCaseUsers.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork _unitOfWork = new UnitOfWork();
        public ActionResult Index(int? page)
        {
            int pageSize = 5;
            int pageNumber = (page ?? 1);            
            return View(_unitOfWork.Users.GetAll().ToList().ToPagedList(pageNumber, pageSize));
        }
    }
}