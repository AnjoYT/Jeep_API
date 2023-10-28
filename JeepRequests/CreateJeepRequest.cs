namespace Jeep_Config_Api_Service.JeepRequests
{
	public record CreateJeepRequest
	(
		string Name,
		string Engine,
		string Edition,
		List<string> Package,
		DateTime CreateDate,
		string Rims,
		List<string> Tires,
		string Interior
	);
}
