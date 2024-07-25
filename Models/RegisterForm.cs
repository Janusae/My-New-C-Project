using System.ComponentModel.DataAnnotations;

namespace Project6.Models
{
	public class RegisterForm
	{
		[Display(Name = "نام و نام خانوادگی")]
		public string FullName { get; set; }
		[Display(Name = "سن")] 
		public int Age { get; set; }
		[Display(Name = "ایمیل")]
		public string Email { get; set; }
	}
}
