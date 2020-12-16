using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YukonTest.Domain;
using YukonTest.Dtos.TimeTableHandle;
using YukonTest.Models;

namespace YukonTest.Services.SchoolServices
{
    public class TimeTableService : ITimeTableService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TimeTableService(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetTeachersDto>>> GetAllTeachers()
        {
            ServiceResponse<List<GetTeachersDto>> serviceResponse = new ServiceResponse<List<GetTeachersDto>>();
            try
            {
                serviceResponse.Data = (_context.Teachers.Select(a => _mapper.Map<GetTeachersDto>(a))).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetTeachersDto>> GetTeacherById(int id)
        {
            ServiceResponse<GetTeachersDto> serviceResponse = new ServiceResponse<GetTeachersDto>();
            try
            {
                serviceResponse.Data = _mapper.Map<GetTeachersDto>(_context.Teachers.FirstOrDefault(a => a.TeacherID == id));
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetTeachersDto>> UpdateTeacher(UpdateTeacherDto req)
        {
            ServiceResponse<GetTeachersDto> serviceResaponse = new ServiceResponse<GetTeachersDto>();
            try
            {
                Teacher teacher = _context.Teachers.FirstOrDefault(a => a.TeacherID == req.TeacherID);
                teacher.Leave = req.Leave;
                _context.SaveChanges();
                serviceResaponse.Data = _mapper.Map<GetTeachersDto>(teacher);
            }
            catch (Exception ex)
            {
                serviceResaponse.Success = false;
                serviceResaponse.Message = ex.Message;
            }
            return serviceResaponse;
        }
    }
}