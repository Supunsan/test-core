using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YukonTest.Dtos.TimeTableHandle;
using YukonTest.Services.SchoolServices;

namespace YukonTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeTableController : ControllerBase
    {
        private readonly ITimeTableService _ttService;
        public TimeTableController(ITimeTableService timeTable)
        {
            _ttService = timeTable;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllTeachers()
        {
            return Ok(await _ttService.GetAllTeachers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _ttService.GetTeacherById(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSample(UpdateTeacherDto req)
        {
            return Ok(await _ttService.UpdateTeacher(req));
        }
    }
}