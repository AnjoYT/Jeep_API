using Microsoft.AspNetCore.Mvc;

namespace Jeep_Config_Api_Service.Controllers
{
	public class ErrorsController : ControllerBase
	{
		[Route("/error")]
		public IActionResult Error()
		{
			return Problem();
		}
	}
}
