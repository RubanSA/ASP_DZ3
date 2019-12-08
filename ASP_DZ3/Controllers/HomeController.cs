using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_DZ3.Models;

namespace ASP_DZ3.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Account> repos;

        public HomeController(IRepository<Account> repository)
        {
            this.repos = repository;
        }
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            AccountViewModel model = new AccountViewModel();
            model.InfoSources = new List<InfoSourceModel>();
            foreach (InfoSource source in Enum.GetValues(typeof(InfoSource)))
            {
                model.InfoSources.Add(new InfoSourceModel { InfoSource = source, IsSelected = false });
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AccountViewModel model)
        {
            if(ModelState.IsValid)
            {
                Account account = new Account { Login = model.Login, Password = model.Password, Sex = model.Sex, About = model.About };
                account.InfoSources = model.InfoSources.Where(m => m.IsSelected).Select(m => m.InfoSource).ToList();
                repos.Add(account);
                ViewBag.Message = "Thank you for registration!";
                return View("Thanks");
            }
            else

            //string str = "Thanks!";
            return View(model);
        }
    }
}