namespace Jeep_Config_Api_Service.JeepRequests
{
	public record JeepResponse
	(
		Guid Id,
		string Name,
		string Engine,
		string Edition,
		List<string> Package,
		DateTime LastTimeModified,
		string Rims,
		List<string> Tires,
		string Interior
	);
}
