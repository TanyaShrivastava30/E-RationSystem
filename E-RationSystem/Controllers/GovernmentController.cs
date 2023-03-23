using BLL;
using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace E_RationSystem.Controllers
{
    public class GovernmentController : Controller
    {

        private readonly ILogger<GovernmentController> _logger;
        private IConsumer _IConsumer;
        private IStock _IStock;
        private IDistributor _IDistributor;
        private ISupplier _ISupplier;

        public GovernmentController(ILogger<GovernmentController> logger)
        {
            _logger = logger;
            _IConsumer = new ConsumerDAL();
            _IStock = new StockDAL();
            _IDistributor = new DistributorDAL();
            _ISupplier = new SupplierDAL();

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ShowCardHolder()
        {
            if (HttpContext.Session.GetString("government") == "1")
            {
                List<Consumer> user = _IConsumer.getAllConsumer();

                if (user != null)
                {
                    ViewData["consumer"] = user;
                }
            }

            return View();
        }

        public IActionResult ShowNewRequest()
        {

            ViewData["name"] = TempData["name"];
            ViewData["mob"] = TempData["mob"];
            ViewData["adhar"] = TempData["adhar"];
            ViewData["gender"] = TempData["gender"];
            ViewData["dob"] = TempData["dob"];
            ViewData["income"] = TempData["income"];
            ViewData["member"] = TempData["member"];
            ViewData["address"] = TempData["address"];
            ViewData["pin"] = TempData["pin"] ;
            return View();

        }

        public IActionResult ShowStock()
        {
            
                List<Stock> slist = _IStock.getAllStock();

                if (slist != null)
                {
                    ViewData["stocks"] = slist;
                }
            

            return View();
        }

        public IActionResult ShowDistributor()
        {
            if (HttpContext.Session.GetString("government") == "1")
            {
                List<Distributor> user = _IDistributor.getAllDistributor();

                if (user != null)
                {
                    ViewData["distributor"] = user;
                }
            }

            return View();
        }

        public IActionResult ShowSupplier()
        {
            if (HttpContext.Session.GetString("government") == "1")
            {
                List<Supplier> user = _ISupplier.getALLSupplier();

                if (user != null)
                {
                    ViewData["supplier"] = user;
                }
            }

            return View();
        }

        public IActionResult ShowSupplierStock()
        {

            List<Stock> slist = _IStock.getSupplierStock();

            if (slist != null)
            {
                ViewData["stocks"] = slist;
            }


            return View();
        }

        public IActionResult ShowDistributorStock()
        {

            List<Stock> slist = _IStock.getDistributorStock();

            if (slist != null)
            {
                ViewData["stocks"] = slist;
            }


            return View();
        }

    }
}
