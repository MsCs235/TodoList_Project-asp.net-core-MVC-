using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using TodoList.Models;
using TodoList.ViewModels;

namespace TodoList.Controllers
{
	public class UserController : Controller
	{
		APPContext context = new APPContext();

		public string hashPassword(string password)
		{
            // Create an instance of PasswordHasher
            var passwordHasher = new PasswordHasher<object>();
            // Hash the password
            string hashedPassword = passwordHasher.HashPassword(null, password);
            return hashedPassword;
        }

		public bool verifyPassword(string userPassword, string password) {

            // Create an instance of PasswordHasher
            var passwordHasher = new PasswordHasher<object>();

            var result = passwordHasher.VerifyHashedPassword(null, userPassword, password);

            if (result == PasswordVerificationResult.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


		[HttpGet]
		public IActionResult Index()
		{
			return View("login");
		}

		[HttpPost]
		public IActionResult Login(string email, string pass)
		{
			if (email == null || pass == null)
			{
				ViewBag.error = "Email or Password field is empty!";
				return View("login");
			}

			User userDetails = context.User.FirstOrDefault(x => x.Email == email);

			if (userDetails == null)
			{
                ViewBag.error = "Email or Password not correct!";
                return View("login");
			}
			else
			{
				try
				{
					if (!verifyPassword(userDetails.Password, pass))
					{
						ViewBag.error = "Email or Password not correct!";
						return View("login");
					}
				}
				catch {
                    ViewBag.error = "Email or Password not correct!";
                    return View("login");
                }

				

                HttpContext.Session.SetInt32("AuthId", userDetails.Id);
                HttpContext.Session.SetString("AuthName", userDetails.Name);
                HttpContext.Session.SetString("AuthEmail", userDetails.Email);
                HttpContext.Session.SetString("AuthPhone", (userDetails.Phone != null) ? userDetails.Phone : "+2");

                return Redirect("/Note/Index");
			}

		}

		[HttpGet]
		public IActionResult RegisterPage()
		{
			registerValidData newdata = new registerValidData();
			return View("register" , newdata);
		}

		[HttpPost]
		public IActionResult Signup(registerValidData user)
		{
			if (user.Name == null || user.Password == null || user.Email == null)
			{
				TempData["error"] = "Complete your form PLZ.";
				return View("register" , user);
			}

			User newUser = new()
			{
				Email = user.Email,
				Name = user.Name,
				Password = hashPassword(user.Password),
				Phone = user.Phone
			};
			context.User.Add(newUser);
			context.SaveChanges();

			return RedirectToAction("Index");
		}


		[HttpGet]
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return View("login");
		}

    }
}
