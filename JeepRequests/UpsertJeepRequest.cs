namespace Jeep_Config_Api_Service.JeepRequests
{
	public record UpsertJeepRequest
	(
		string Name,
		string Engine,
		string Edition,
		List<string> Package,
		string Rims,
		List<string> Tires,
		string Interior
	);
}
