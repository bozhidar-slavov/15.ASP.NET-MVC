namespace InformationalApp.Controllers
{
    using System.Web.Mvc;

    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return this.View();
        }
    }
}