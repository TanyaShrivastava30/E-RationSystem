using BLL;
using DAL;
using BOL;
using Microsoft.AspNetCore.Mvc;



namespace E_RationSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        private ILogin _ILogin;
        
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
            _ILogin = new LoginDAL();
            
        }

        [HttpGet]
        public ActionResult login()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult login(Login login)
        {
            try
            {

                var Username = login.User_Name;
                var password = login.Password;

                var result = _ILogin.ValidateUser(Username, password);

                if (result != null)
                {
                    var RoleID = result.Role_Id;
                    if (RoleID == 1)
                    {
                        HttpContext.Session.SetString("government", "1");    //for view Context.Session.SetString("govt", "1")
                        return RedirectToAction("Index", "Government");
                    }

                    if (RoleID == 2)
                    {
                        // HttpContext.Session.SetString("supplier", "2");
                        TempData["username"] = result.User_Name;
                        return RedirectToAction("Index", "Supplier");
                    }
                    if (RoleID == 3)
                    {
                        HttpContext.Session.SetString("distributor", "3");
                        return RedirectToAction("Index", "Distributor");
                    }

                }
                else
                {
                    TempData["message"] = "Entered Invalid Username and Password";
                    return RedirectToAction("login", "Login");
                }
            }
            catch(Exception)
            {
                throw;
            }

            return View();
        }

        
    }
}
