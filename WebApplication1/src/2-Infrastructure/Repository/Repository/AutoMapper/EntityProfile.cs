using AppCore.Dto;
using AppCore.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AutoMapper
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<Doctor, DoctorEditProfileDto>();
            CreateMap<Doctor, DoctorRegisterDto>();
            
        }

    }
}
