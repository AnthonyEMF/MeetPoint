using AutoMapper;
using MeetPoint.API.Database;
using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Dtos.Users;
using MeetPoint.API.Services.Interfaces;

namespace MeetPoint.API.Services
{
    public class UsersService : IUsersService
    {
        private readonly MeetPointContext _context;
        private readonly IMapper _mapper;

        public UsersService(MeetPointContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<ResponseDto<List<UserDto>>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserDto>> GetUserByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserDto>> CreateAsync(UserCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserDto>> EditAsync(UserEditDto dto, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
