using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Dtos.Events;
using MeetPoint.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MeetPoint.API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class AttendancesController : ControllerBase
    {
        private readonly IAttendancesService _AttendancesService;

        public AttendancesController(IAttendancesService attendancesService)
        {
            this._AttendancesService = attendancesService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<AttendanceDto>>>> GetAll()
        {
            var response = await _AttendancesService.GetAllAttendancesAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<AttendanceDto>>> Get(Guid id)
        {
            var response = await _AttendancesService.GetAttendanceByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<AttendanceDto>>> Create(AttendanceCreateDto dto)
        {
            var response = await _AttendancesService.CreateAsync(dto);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<AttendanceDto>>> Edit(AttendanceEditDto dto, Guid id)
        {
            var response = await _AttendancesService.EditAsync(dto, id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<AttendanceDto>>> Delete(Guid id)
        {
            var response = await _AttendancesService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
