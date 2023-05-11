using AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Dto
{
    public class DoctorLoginDto
    {

        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

    }
}
