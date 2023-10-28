
using Jeep_Config_Api_Service.Services.JeepService;

namespace Jeep_Config_Api_Service
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllers();
			builder.Services.AddScoped<IJeepService, JeepService>();
			var app = builder.Build();
			app.UseExceptionHandler("/error");
			app.UseHttpsRedirection();

			app.MapControllers();

			app.Run();
		}
	}
}