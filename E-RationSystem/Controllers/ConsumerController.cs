using BLL;
using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace E_RationSystem.Controllers
{
    public class ConsumerController : Controller
    {
        private readonly ILogger<ConsumerController> _logger;
        private IConsumer _IConsumer;
        private ICard_Stock _ICard;


        public ConsumerController(ILogger<ConsumerController> logger)
        {
            _logger = logger;
            _IConsumer = new ConsumerDAL();
            _ICard = new Card_StockDAL();
        }

        [HttpGet]
        public IActionResult Consumer_login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Consumer_login(string Ration_Id, string Password)
     
        {
            try
            {
              
                var result = _IConsumer.validateConsumer(Ration_Id, Password);

                if (result != null)
                {
                    TempData["username"] = result.Ration_Id;
                    return RedirectToAction("Index", "Consumer");
                   
                }
                else
                {
                        TempData["message"] = "Entered Invalid Username and Password";
                        return RedirectToAction("Consumer_login", "Consumer");  
                }
                
            }
            catch(Exception)
            {
                throw;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Registration(Consumer consumer)
        {
            TempData["name"] = consumer.Name;
            TempData["mob"] = consumer.Mobile_No;
            TempData["adhar"] = consumer.Adhar_No;
            TempData["gender"] = consumer.Gender;
            TempData["dob"] = consumer.Date_of_Birth.ToString();
            TempData["income"] = consumer.Income.ToString();
            TempData["member"] = consumer.Total_Members;
            TempData["address"] = consumer.Address;
            TempData["pin"] = consumer.Pincode;

            TempData["message"] = "Data Submitted Successfully...Wait For Confirmation";
            return RedirectToAction("Registration", "Consumer");
        }


        public IActionResult Index()
        {
            return View();
        }

        /* public IActionResult ShowCardHolder()
         {

             List<Consumer> user = _IConsumer.getAllConsumer();

             if (user != null)
             {
                 ViewData["consumer"] = user;
             }
             return View();
         }*/

        public IActionResult ShowProfile()
        {
            string user = (string)TempData["username"];
            Consumer c = _IConsumer.showDetailsByID(user);
            if (c != null)
            {
                ViewData["profile"] = c;
                return View();
            }      
              
            return View();
        }

       
        public IActionResult Profile_updation()
        {
            string user = (string)TempData["username"];
            Consumer c = _IConsumer.showDetailsByID(user);
            if (c != null)
            {
                ViewData["profile"] = c;
                return View();
            }

            return View();

        }

        /*[HttpPost]
        public IActionResult Profile_updation(Consumer cons)
        {
            TempData["msg"] = "Account Details Updated";
            return View();

        }*/
    }
}
