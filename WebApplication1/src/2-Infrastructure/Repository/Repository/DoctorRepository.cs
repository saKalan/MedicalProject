using AppCore.DataAccess;
using AppCore.Dto;
using AppCore.Entity;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SqlDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly MedicalDbContext _appDbContext;
        private readonly IMapper _mapper;

        public DoctorRepository(MedicalDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task Register(DoctorRegisterDto dto, CancellationToken cancellationToken)
        {
            Doctor entity = _mapper.Map<Doctor>(dto);
            _appDbContext.Doctors.Add(entity);
            await _appDbContext.SaveChangesAsync(cancellationToken);
        }


        public async Task<DoctorOutputDto>? GetDoctorBy(string userName, string password, CancellationToken cancellationToken)
        {
            DoctorOutputDto? dto = _mapper.Map<DoctorOutputDto>(await _appDbContext.Doctors.FirstOrDefaultAsync(d => d.Password == password && d.UserName == userName));
            return dto;
        }

        public async Task<DoctorEditProfileDto>? GetDoctorBy(int id, CancellationToken cancellationToken)
        {
            DoctorEditProfileDto? dto = _mapper.Map<DoctorEditProfileDto>(await _appDbContext.Doctors.FirstOrDefaultAsync(d => d.Id == id));

            return dto;
        }


        public async Task Edit(DoctorEditProfileDto dto, CancellationToken cancellationToken)
        {
            Doctor entity = _mapper.Map<Doctor>(dto);
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
