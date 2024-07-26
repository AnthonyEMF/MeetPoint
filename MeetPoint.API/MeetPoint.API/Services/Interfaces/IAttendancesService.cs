using MeetPoint.API.Dtos.Attendances;
using MeetPoint.API.Dtos.Common;

namespace MeetPoint.API.Services.Interfaces
{
    public interface IAttendancesService
    {
        Task<ResponseDto<List<AttendanceDto>>> GetAllAttendancesAsync();
        Task<ResponseDto<AttendanceDto>> GetAttendanceByIdAsync(Guid id);
        Task<ResponseDto<AttendanceDto>> CreateAsync(AttendanceCreateDto dto);
        Task<ResponseDto<AttendanceDto>> EditAsync(AttendanceEditDto dto, Guid id);
        Task<ResponseDto<AttendanceDto>> DeleteAsync(Guid id);
    }
}
