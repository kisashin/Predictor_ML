using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Predictor_ML.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Portal()
        {
            return View();
        }
    }
}
