namespace InformationalApp.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}