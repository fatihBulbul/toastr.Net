using System.Web.Mvc;
using toastr.Net.OptionEnums;

namespace toastr.Net.Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message =
                Notification.Show("Merhaba dünya", onclick: "hello") +
                Notification.Show("Elveda dünya", position: Position.BottomCenter, type: ToastType.Error, timeOut: 7000);
            return View();
        }
    }
}