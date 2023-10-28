using Jeep_Config_Api_Service.Models;

namespace Jeep_Config_Api_Service.Services.JeepService
{
	public class JeepService : IJeepService
	{
		private static readonly Dictionary<Guid,Jeep> _jeep = new();
		public void CreateJeep(Jeep jeep)
		{
			//TODO storing in DB
			_jeep.Add(jeep.Id,jeep);
		}

		public void DeleteJeep(Guid id)
		{
			_jeep.Remove(id);
		}

		public Jeep GetJeep(Guid id)
		{
			return _jeep[id];
		}

		public void UpsertJeep(Jeep jeep)
		{
			_jeep[jeep.Id] = jeep;
		}
	}
}
