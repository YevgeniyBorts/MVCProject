using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListProjects()
        {
            List<Models.ProjectModel> projects = new List<Models.ProjectModel>();

            projects.Add(new Models.ProjectModel { Name = "MVC Project", Classification = "ASP.NET MVC", Description = "My first MVC project.", Reference = "https://github.com/YevgeniyBorts/MVCProject", Complete = false, Version = 1.0 }); 

            return View();
        }
    }
}