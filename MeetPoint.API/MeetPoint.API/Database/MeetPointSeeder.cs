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
				await LoadUsersAsync(context, loggerFactory);
				await LoadAttendancesAsync(context, loggerFactory);
				await LoadCommentsAsync(context, loggerFactory);
				await LoadEventsCommentsAsync(context, loggerFactory);
				await LoadEventsAttendancesAsync(context, loggerFactory);
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
		public static async Task LoadUsersAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				var jsonFilePatch = "SeedData/users.json";
				var jsonContent = await File.ReadAllTextAsync(jsonFilePatch);
				var users = JsonConvert.DeserializeObject<List<UserEntity>>(jsonContent);

				if (!await context.Users.AnyAsync())
				{
					for (int i = 0; i < users.Count; i++)
					{
						users[i].CreatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						users[i].CreatedDate = DateTime.Now;
						users[i].UpdatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						users[i].UpdatedDate = DateTime.Now;
					}
					context.AddRange(users);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al ejecutar el Seed de Usuarios.");
			}
		}
		public static async Task LoadAttendancesAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				var jsonFilePatch = "SeedData/attendances.json";
				var jsonContent = await File.ReadAllTextAsync(jsonFilePatch);
				var attendances = JsonConvert.DeserializeObject<List<AttendanceEntity>>(jsonContent);

				if (!await context.Attendances.AnyAsync())
				{
					for (int i = 0; i < attendances.Count; i++)
					{
						attendances[i].CreatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						attendances[i].CreatedDate = DateTime.Now;
						attendances[i].UpdatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						attendances[i].UpdatedDate = DateTime.Now;
					}
					context.AddRange(attendances);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al ejecutar el Seed de Asistencias.");
			}
		}
		public static async Task LoadCommentsAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				var jsonFilePatch = "SeedData/comments.json";
				var jsonContent = await File.ReadAllTextAsync(jsonFilePatch);
				var comments = JsonConvert.DeserializeObject<List<CommentEntity>>(jsonContent);

				if (!await context.Comments.AnyAsync())
				{
					for (int i = 0; i < comments.Count; i++)
					{
						comments[i].CreatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						comments[i].CreatedDate = DateTime.Now;
						comments[i].UpdatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						comments[i].UpdatedDate = DateTime.Now;
					}
					context.AddRange(comments);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al ejecutar el Seed de Comentarios.");
			}
		}
		public static async Task LoadEventsCommentsAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				var jsonFilePatch = "SeedData/events_comments.json";
				var jsonContent = await File.ReadAllTextAsync(jsonFilePatch);
				var eventsComments = JsonConvert.DeserializeObject<List<EventCommentEntity>>(jsonContent);

				if (!await context.EventsComments.AnyAsync())
				{
					for (int i = 0; i < eventsComments.Count; i++)
					{
						eventsComments[i].CreatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						eventsComments[i].CreatedDate = DateTime.Now;
						eventsComments[i].UpdatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						eventsComments[i].UpdatedDate = DateTime.Now;
					}
					context.AddRange(eventsComments);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al ejecutar el Seed de Eventos y Comentarios.");
			}
		}
		public static async Task LoadEventsAttendancesAsync(MeetPointContext context, ILoggerFactory loggerFactory)
		{
			try
			{
				var jsonFilePatch = "SeedData/events_attendances.json";
				var jsonContent = await File.ReadAllTextAsync(jsonFilePatch);
				var eventsAttendances = JsonConvert.DeserializeObject<List<EventAttendanceEntity>>(jsonContent);

				if (!await context.EventsAttendances.AnyAsync())
				{
					for (int i = 0; i < eventsAttendances.Count; i++)
					{
						eventsAttendances[i].CreatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						eventsAttendances[i].CreatedDate = DateTime.Now;
						eventsAttendances[i].UpdatedBy = "2a373bd7-1829-4bb4-abb7-19da4257891d";
						eventsAttendances[i].UpdatedDate = DateTime.Now;
					}
					context.AddRange(eventsAttendances);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<MeetPointSeeder>();
				logger.LogError(ex, "Error al ejecutar el Seed de Eventos y Asistencias.");
			}
		}
	}
}
