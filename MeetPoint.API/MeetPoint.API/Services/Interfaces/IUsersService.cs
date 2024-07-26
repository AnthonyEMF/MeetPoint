using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Dtos.Users;

namespace MeetPoint.API.Services.Interfaces
{
    public interface IUsersService
    {
        Task<ResponseDto<List<UserDto>>> GetAllUsersAsync();
        Task<ResponseDto<UserDto>> GetUserByIdAsync(Guid id);
        Task<ResponseDto<UserDto>> CreateAsync(UserCreateDto dto);
        Task<ResponseDto<UserDto>> EditAsync(UserEditDto dto, Guid id);
        Task<ResponseDto<UserDto>> DeleteAsync(Guid id);
    }
}
