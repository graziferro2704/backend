using Microsoft.AspNetCore.Mvc;

using _19_Atividade_CRUD.Filters;

namespace Produtos_Com_Admin.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        [AdminAuthorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}