using AutoMapper;
using MeetPoint.API.Database.Entities;
using MeetPoint.API.Dtos.Categories;
using MeetPoint.API.Dtos.Events;

namespace MeetPoint.API.Helpers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			MapsForCategories();
			MapsForEvents();
			//MapsForUsers();
			//MapsForAttendances();
			//MapsForComments();
		}

		private void MapsForCategories()
		{
			CreateMap<CategoryEntity, CategoryDto>();
			CreateMap<CategoryCreateDto, CategoryEntity>();
			CreateMap<CategoryEditDto, CategoryEntity>();
		}

		private void MapsForEvents()
		{
			CreateMap<EventEntity, EventDto>();
			CreateMap<EventCreateDto, EventEntity>();
			CreateMap<EventEditDto, EventEntity>();
		}
	}
}
