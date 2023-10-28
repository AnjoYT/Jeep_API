using Jeep_Config_Api_Service.JeepRequests;
using Jeep_Config_Api_Service.Models;
using Jeep_Config_Api_Service.Services.JeepService;
using Microsoft.AspNetCore.Mvc;

namespace Jeep_Config_Api_Service.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class JeepController : ControllerBase
	{
		private readonly IJeepService _jeepService;
		public JeepController(IJeepService jeepService) 
		{
			_jeepService = jeepService;
		}
		[HttpPost]
		public IActionResult CreateJeep(CreateJeepRequest request) 
		{
			var jeep = new Jeep(
				Guid.NewGuid(),
				request.Name,
				request.Engine,
				request.Edition,
				request.Package,
				DateTime.UtcNow,
				request.Rims,
				request.Tires,
				request.Interior
				);

			_jeepService.CreateJeep(jeep);
			var response = new JeepResponse( 
				jeep.Id,
				jeep.Name,
				jeep.Engine,
				jeep.Edition,
				jeep.Package,
				jeep.LastTimeModified,
				jeep.Rims,
				jeep.Tires,
				jeep.Interior
				);
			return CreatedAtAction(
				nameof(GetJeep),
				new {id=jeep.Id},
				response
				);
		}
		[HttpGet("{id:guid}")]
		public IActionResult GetJeep(Guid id)
		{
			Jeep jeep = _jeepService.GetJeep(id);
			var response = new JeepResponse(
				jeep.Id,
				jeep.Name,
				jeep.Engine,
				jeep.Edition,
				jeep.Package,
				jeep.LastTimeModified,
				jeep.Rims,
				jeep.Tires,
				jeep.Interior
				);
			return Ok(response);
		}
		[HttpPut("{id:guid}")]
		public IActionResult UpsertJeep(Guid id,UpsertJeepRequest request)
		{
			var jeep = new Jeep(
				id,
				request.Name,
				request.Engine,
				request.Edition,
				request.Package,
				DateTime.UtcNow,
				request.Rims,
				request.Tires,
				request.Interior);
			_jeepService.UpsertJeep(jeep);
			return NoContent();
		}
		[HttpDelete("{id:guid}")]
		public IActionResult DeleteJeep(Guid id)
		{
			_jeepService.DeleteJeep(id);
			return NoContent();
		}
	}
}
