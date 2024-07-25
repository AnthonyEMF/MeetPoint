using MeetPoint.API.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MeetPoint.API.Database
{
	public class MeetPointSeeder
	{
		public static async Task LoadDataAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				await LoadCategoriesAsync(context, loggerFactory);
				await LoadEventsAsync(context, loggerFactory);

				//await LoadUsersAsync(context, loggerFactory);
				//await LoadAttendancesAsync(context, loggerFactory);
				//await LoadCommentsAsync(context, loggerFactory);
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al inicializar la Data del API.");
			}
		}

		public static async Task LoadCategoriesAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				var jsonFilePatch = "SeedData/categories.json";
				var jsonContent = await File.ReadAllTextAsync(jsonFilePatch);
				var categories = JsonConvert.DeserializeObject<List<CategoryEntity>>(jsonContent);
				
				if (!await context.Categories.AnyAsync())
				{
					for (int i=0; i < categories.Count; i++)
					{
						categories[i].CreatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						categories[i].CreatedDate = DateTime.Now;
						categories[i].UpdatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						categories[i].UpdatedDate = DateTime.Now;
					}
					context.AddRange(categories);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al ejecutar el Seed de Categorias.");
			}
		}
		public static async Task LoadEventsAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				var jsonFilePatch = "SeedData/events.json";
				var jsonContent = await File.ReadAllTextAsync(jsonFilePatch);
				var events = JsonConvert.DeserializeObject<List<EventEntity>>(jsonContent);

				if (!await context.Events.AnyAsync())
				{
					for (int i = 0; i < events.Count; i++)
					{
						events[i].CreatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						events[i].CreatedDate = DateTime.Now;
						events[i].UpdatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						events[i].UpdatedDate = DateTime.Now;
					}
					context.AddRange(events);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al ejecutar el Seed de Eventos.");
			}
		}
	}
}
