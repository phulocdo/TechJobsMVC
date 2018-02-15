using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class TechJobsController : Controller
    {
        private static Dictionary<string, string> actionChoices = new Dictionary<string, string>();
        internal static Dictionary<string, string> columnChoices = new Dictionary<string, string>();

        //static constructor use to initialize static memeber of the class
        static TechJobsController()
        {
            
            actionChoices.Add("list","List");
            actionChoices.Add("search", "Search");

            columnChoices.Add("core competency", "Skill");
            columnChoices.Add("employer", "Employer");
            columnChoices.Add("location", "Location");
            columnChoices.Add("position type", "Position Type");
            columnChoices.Add("all", "All");
        }

        //add actionchoices to viewbag
        public override ViewResult View()
        {
            //TODO 3
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View();
        }

        public override ViewResult View(string viewName)
        {
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View(viewName);
        }

        
    }
}

