using ConfigurationTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationTask.Controllers
{
	public class SocialMediaLinksController : Controller
	{
		private readonly IOptions<SocialMediaLinksOptions> _socialMediaOptions;
		private readonly IWebHostEnvironment _webHost;	
		public SocialMediaLinksController(IOptions<SocialMediaLinksOptions> socialMediaOptions, IWebHostEnvironment webHost) {
			_webHost = webHost;
			_socialMediaOptions = socialMediaOptions;
		}
		[Route("/")]
		public IActionResult ReturnSocialMediaLinks()
		{
			
			if(_webHost.IsDevelopment())
				return View("ReturnSocialMediaLinksInDevelopment", _socialMediaOptions.Value);

			return View("ReturnSocialMediaLinksInProduction", _socialMediaOptions.Value);

		}
	}
}
