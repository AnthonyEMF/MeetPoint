using AutoMapper;
using MeetPoint.API.Database;
using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Services.Interfaces;

namespace MeetPoint.API.Services
{
    public class AttendancesService : IAttendancesService
    {
        private readonly MeetPointContext context;
        private readonly IMapper mapper;

        public AttendancesService(MeetPointContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<ResponseDto<List<AttendanceDto>>> GetAllAttendancesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<AttendanceDto>> GetAttendanceByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<AttendanceDto>> CreateAsync(AttendanceCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<AttendanceDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<AttendanceDto>> EditAsync(AttendanceEditDto dto, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
