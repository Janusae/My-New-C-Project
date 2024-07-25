using Microsoft.AspNetCore.Mvc;
using Project6.Models;

namespace Project6.Controllers
{

	public class RegisterController : Controller
	{
		[Route("Register")]
		public IActionResult Index()
		{
			return View(new RegisterForm());
		}

		public IActionResult RegisterCheck(RegisterForm registerform)
		{
			var result = processRegisterForm(registerform);
			if (Convert.ToString(result) == "success")
			{
				return View("registersuccess");
			}
			else
			{
				ViewBag.status = "Your information is not correct!";
				return View("registererror");
			}
			
		}
		private Status processRegisterForm(RegisterForm registerform)
		{
			var check_name = registerform.FullName != null;
			var check_age = registerform.Age != 0 && registerform.Age < 110;
			var check_email = registerform.Email != null &&registerform.Email.Contains("@") && registerform.Email.Contains(".com");



            if (check_email && check_age && check_name)
			{
				var registerStatusstatus = Status.success;
				return registerStatusstatus;


			}
			else
			{
                var registerStatusstatus = Status.failed;
                return registerStatusstatus;

            }

		}

	}

	
}


