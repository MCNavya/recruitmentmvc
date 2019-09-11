using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recruitment_Application.Controllers
{
    public class RequirementController : Controller
    {
        // GET: Requirement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReqInput()
        {
            return View();
        }
    }
}