using MeetPoint.API.Dtos.Common;

namespace MeetPoint.API.Services.Interfaces
{
    public interface ICommentsService
    {
        Task<ResponseDto<List<CommentDto>>> GetAllEventsAsync();
        Task<ResponseDto<CommentDto>> GetEventByIdAsync(Guid id);
        Task<ResponseDto<CommentDto>> CreateAsync(CommentCreateDto dto);
        Task<ResponseDto<CommentDto>> EditAsync(CommentEditDto dto, Guid id);
        Task<ResponseDto<CommentDto>> DeleteAsync(Guid id);
    }
}
