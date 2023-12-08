using Microsoft.AspNetCore.Mvc;
using App.Filters; 

namespace App.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        //Essa marcação quer dizer que este arquivo pertence a área Admin
        [Area("Admin")]
        [AdminAuthorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}