﻿using MeetPoint.API.Database;
using MeetPoint.API.Helpers;
using MeetPoint.API.Services;
using MeetPoint.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MeetPoint.API
{
	public class Startup
	{
		private IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// Services
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			// Add DbContext
			services.AddDbContext<MeetPointContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			// Add Custom Services
			services.AddTransient<ICategoriesService, CategoriesService>();
			services.AddTransient<IEventsService, EventsService>();
			services.AddTransient<IAuthService, AuthService>();
			//services.AddTransient<IUsersService, UsersService>();
			//services.AddTransient<IAttendancesService, AttendancesService>();
			//services.AddTransient<ICommentsService, CommentsService>();

			// Add AutoMapper
			services.AddAutoMapper(typeof(AutoMapperProfile));
		}

		// Middlewords
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}