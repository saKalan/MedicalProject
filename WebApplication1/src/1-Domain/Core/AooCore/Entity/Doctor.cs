﻿using System;
using System.Collections.Generic;

namespace AppCore.Entity;

public class Doctor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Family { get; set; } = null!;

    public int SpecialtyId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<DoctorTimeDuration> DoctorTimeDurations { get; set; } = new List<DoctorTimeDuration>();

    public virtual Specialty Specialty { get; set; } = null!;
}
