using AutoMapper;
using MeetPoint.API.Database;
using MeetPoint.API.Dtos.Comments;
using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Services.Interfaces;

namespace MeetPoint.API.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly MeetPointContext _context;
        private readonly IMapper _mapper;

        public CommentsService(MeetPointContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<ResponseDto<List<CommentDto>>> GetAllCommentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CommentDto>> GetCommentByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CommentDto>> CreateAsync(CommentCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CommentDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CommentDto>> EditAsync(CommentEditDto dto, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
