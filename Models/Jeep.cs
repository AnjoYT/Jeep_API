namespace Jeep_Config_Api_Service.Models
{
	public class Jeep
	{
		public Guid Id {  get;}
		public string Name { get; }
		public string Engine { get; }
		public string Edition { get; }
		public List<string> Package { get; }
		public DateTime LastTimeModified { get; }
		public string Rims { get; }
		public List<string> Tires { get; }
		public string Interior { get; }

        public Jeep(Guid id,string name,string engine, string edition, List<string> package, DateTime lastTimeModified, string rims, List<string> tires, string interior)
        {
            Id = id;
			Name = name;
			Engine = engine;
			Edition = edition;
			Package = package;
			LastTimeModified = lastTimeModified;
			Rims = rims;
			Tires = tires;
			Interior = interior;
			
        }
    }

}
