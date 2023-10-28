using Jeep_Config_Api_Service.Models;

namespace Jeep_Config_Api_Service.Services.JeepService
{
	public interface IJeepService
	{
		void CreateJeep(Jeep jeep);
		void DeleteJeep(Guid id);
		Jeep GetJeep(Guid id);
		void UpsertJeep(Jeep jeep);
	}
}
