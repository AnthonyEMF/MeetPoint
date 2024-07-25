using AutoMapper;
using MeetPoint.API.Database;
using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Dtos.Events;
using MeetPoint.API.Services.Interfaces;

namespace MeetPoint.API.Services
{
	public class EventsService : IEventsService
	{
		private readonly MeetPointContext _context;
		private readonly IMapper _mapper;

		public EventsService(MeetPointContext context, IMapper mapper)
        {
			this._context = context;
			this._mapper = mapper;
		}

        public Task<ResponseDto<List<EventDto>>> GetAllEventsAsync()
		{
			throw new NotImplementedException();
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
