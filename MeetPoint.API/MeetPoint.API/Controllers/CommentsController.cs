using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MeetPoint.API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            this._commentsService = commentsService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<CommentDto>>>> GetAll()
        {
            var response = await _commentsService.GetAllEventsAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<CommentDto>>> Get(Guid id)
        {
            var response = await _commentsService.GetEventByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<CommentDto>>> Create(CommentCreateDto dto)
        {
            var response = await _commentsService.CreateAsync(dto);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<CommentDto>>> Edit(CommentEditDto dto, Guid id)
        {
            var response = await _commentsService.EditAsync(dto, id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<CommentDto>>> Delete(Guid id)
        {
            var response = await _commentsService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
