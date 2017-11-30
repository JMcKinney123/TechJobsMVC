using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;
using System.Linq;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }
       
        public IActionResult Results(string searchType, string searchTerm)
        {

            
             ViewBag.columns = ListController.columnChoices;
            
            

             if (searchType == "all")
             {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
             }
             /*if (string.IsNullOrEmpty(searchTerm))
             {

                
             }*/
             else
             //else if (searchTerm != null && searchType != "all")
             {
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
             }

             /*else
             {
                 return Redirect("/search");
             }*/

             
             return View("index");
        }
            
            // TODO #1 - Create a Results action method to process 
        // search request and display results

    }
}
