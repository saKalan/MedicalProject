using AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Dto
{
    public class DoctorEditProfileDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Family { get; set; } = null!;

        public int SpecialtyId { get; set; }

        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
