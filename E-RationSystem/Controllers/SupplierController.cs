using BLL;
using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace E_RationSystem.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ILogger<SupplierController> _logger;

        private ILogin _ILogin;
        private ISupplier _ISupplier;
        private IStock _IStock;

        public SupplierController(ILogger<SupplierController> logger)
        {
            _logger = logger;
            _ILogin = new LoginDAL();
            _ISupplier = new SupplierDAL();
            _IStock = new StockDAL();

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowProfile()
        {
            string user = (string)TempData["username"];
            Supplier s = _ISupplier.showDetailsByID(user);
       
            if (s != null)
            {
                ViewData["profile"] = s;
                return View();
            }

            return View();
        }

        public IActionResult Profile_updation()
        {
            string user = (string)TempData["username"];
            Supplier s = _ISupplier.showDetailsByID(user);
            if (s != null)
            {
                ViewData["profile"] = s;
                return View();
            }

            return View();

        }

      /*  public IActionResult ShowSupplierStock()
        {

            List<Stock> slist = _IStock.getAllStock();

            if (slist != null)
            {
                ViewData["stk"] = slist;
            }


            return View();
        }*/
    }
}
