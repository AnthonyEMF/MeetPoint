using AutoMapper;
using MeetPoint.API.Constants;
using MeetPoint.API.Database;
using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Dtos.Events;
using MeetPoint.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MeetPoint.API.Services
{
	public class EventsService : IEventsService
	{
		private readonly MeetPointContext _context;
		private readonly IMapper _mapper;
		private readonly ILogger _logger;
		private readonly int PAGE_SIZE;

		public EventsService(
			MeetPointContext context,
			IMapper mapper,
			ILogger<EventsService> logger,
			IConfiguration configuration)
        {
			this._context = context;
			this._mapper = mapper;
			this._logger = logger;
			PAGE_SIZE = configuration.GetValue<int>("PageSize");
		}

        public async Task<ResponseDto<PaginationDto<List<EventDto>>>> GetAllEventsAsync(string searchTerm = "", int page = 1)
		{
			int startIndex = (page - 1) * PAGE_SIZE;

			var eventsEntityQuery = _context.Events
				.Include(x => x.Category) // TODO: Mostrar solo el nombre de la Categoría
				.Include(x => x.Attendances).ThenInclude(x => x.Attendance)
				.Include(x => x.Comments).ThenInclude(x => x.Comment)
				.Where(x => x.PublicationDate <= DateTime.Now);

			if (!string.IsNullOrEmpty(searchTerm))
			{
				eventsEntityQuery = eventsEntityQuery
					.Where(x => (x.Title + " " + x.Category.Name + " " + x.Description)
					.ToLower().Contains(searchTerm.ToLower()));
			}

			int totalEvents = await eventsEntityQuery.CountAsync();
			int totalPages = (int)Math.Ceiling((double)totalEvents / PAGE_SIZE);

			var eventsEntity = await eventsEntityQuery
				.OrderByDescending(x => x.PublicationDate)
				.Skip(startIndex)
				.Take(PAGE_SIZE)
				.ToListAsync();

			var eventsDtos = _mapper.Map<List<EventDto>>(eventsEntity);

			return new ResponseDto<PaginationDto<List<EventDto>>>
			{
				StatusCode = 200,
				Status = true,
				Message = MessagesConstant.RECORDS_FOUND,
				Data = new PaginationDto<List<EventDto>>
				{
					CurrentPage = page,
					PageSize = PAGE_SIZE,
					TotalItems = totalEvents,
					TotalPages = totalPages,
					Items = eventsDtos,
					HasPreviousPage = page > 1,
					HasNextPage = page < totalPages,
				}
			};
		}

		public Task<ResponseDto<EventDto>> GetEventByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<ResponseDto<EventDto>> CreateAsync(EventCreateDto dto)
		{
			throw new NotImplementedException();
		}

		public Task<ResponseDto<EventDto>> DeleteAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<ResponseDto<EventDto>> EditAsync(EventEditDto dto, Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
