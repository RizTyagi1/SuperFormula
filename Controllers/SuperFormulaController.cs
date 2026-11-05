using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SuperFormulaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            SuperFormulaModel model =
                new SuperFormulaModel();

            // ==========================================
            // DEFAULT VALUES
            // ==========================================

            model.M1 = 9.53;

            model.N1A = 0.31;

            model.N2A = 1.69;

            model.N3A = 1.69;


            // ==========================================
            // SECOND SUPERFORMULA
            // Controls vertical direction
            // ==========================================

            model.M2 = 6.0;

            model.N1B = 0.31;

            model.N2B = 1.69;

            model.N3B = 1.69;


            // ==========================================
            // DISPLAY
            // ==========================================

            model.Scale = 100;

            model.ParticleSize = 2.0;


            return View(model);
        }
    }
}