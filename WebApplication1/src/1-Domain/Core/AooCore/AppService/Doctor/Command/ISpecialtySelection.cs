using AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.AppService.Doctor.Command
{
    public interface ISpecialtySelection
    {
        void SpecialtySelect(int DoctorId, int specialtyId);
    }



}
