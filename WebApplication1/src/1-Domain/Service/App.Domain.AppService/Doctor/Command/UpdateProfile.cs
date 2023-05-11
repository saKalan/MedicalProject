using AppCore.AppService.Doctor.Command;
using AppCore.DataAccess;
using AppCore.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Doctor.Command
{
    public class UpdateProfile : IUpdateProfile
    {
        private readonly IDoctorRepository _doctorRepository;

        public UpdateProfile(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task PostExecute(DoctorEditProfileDto dto, CancellationToken cancellationToken)
        {
            _doctorRepository.Edit(dto, cancellationToken);
        }

        public async Task<DoctorEditProfileDto> GetExecute(int id, CancellationToken cancellationToken)
        {
            DoctorEditProfileDto dto = await _doctorRepository.GetDoctorBy(id, cancellationToken);

            return dto;
        }


    }
}
