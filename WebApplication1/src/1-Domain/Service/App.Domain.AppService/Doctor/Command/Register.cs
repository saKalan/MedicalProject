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
    public class Register : IRegister
    {
        private readonly IDoctorRepository _doctorRepository;

        public Register(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public void Execute(DoctorRegisterDto dto, CancellationToken cancellationToken)
        {
            _doctorRepository.Register(dto, cancellationToken);
        }
    }
}
