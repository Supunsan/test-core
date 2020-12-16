using System.Collections.Generic;
using System.Threading.Tasks;
using YukonTest.Dtos.TimeTableHandle;
using YukonTest.Models;

namespace YukonTest.Services.SchoolServices
{
    public interface ITimeTableService
    {
        Task<ServiceResponse<List<GetTeachersDto>>> GetAllTeachers();
        Task<ServiceResponse<GetTeachersDto>> GetTeacherById(int id);
        Task<ServiceResponse<GetTeachersDto>> UpdateTeacher(UpdateTeacherDto req);
    }
}