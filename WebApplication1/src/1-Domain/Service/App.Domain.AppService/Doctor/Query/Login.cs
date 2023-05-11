using AppCore.AppService.Doctor.Query;
using AppCore.DataAccess;
using AppCore.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Doctor.Query
{
    public class Login : ILogin
    {

        private readonly IDoctorRepository _doctorRepository;

        public Login(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<bool> Execute(DoctorLoginDto dto, CancellationToken cancellationToken)
        {
            DoctorOutputDto? newDto = await (await _doctorRepository.GetDoctorBy(dto.UserName, dto.Password, cancellationToken));
            if (newDto == null)
                return false;
            return true;

        }
    }
}
