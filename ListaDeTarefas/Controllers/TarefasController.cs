using Microsoft.AspNetCore.Mvc;

namespace ListaDeTarefas.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Criar()
        {
            return View();
        }
    }
}
