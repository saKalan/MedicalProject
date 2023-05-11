using System;
using System.Collections.Generic;

namespace AppCore.Entity;

public class Appointment
{
    public int Id { get; set; }

    public int DoctorId { get; set; }

    public int PatientId { get; set; }

    public DateTime TimeFrom { get; set; }

    public DateTime TimeTo { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
