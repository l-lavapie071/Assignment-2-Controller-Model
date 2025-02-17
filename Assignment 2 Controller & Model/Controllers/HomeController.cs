using Microsoft.AspNetCore.Mvc;

namespace Assignment_2_Controller___Model.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public string Index()
        {
            return "Home Page";
        }
    }
}
