using Microsoft.EntityFrameworkCore;

namespace CrudApp.Models
{
	public static class DatabaseInitializer
	{
		public static void InitializeDatabase(this IApplicationBuilder app)
		{
			using (var serviceScope = app.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
				context.Database.Migrate(); // Aplica as migrações e cria o banco se não existir
			}
		}
	}

}
