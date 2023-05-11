using System;
using System.Collections.Generic;

namespace AppCore.Entity;

public class DoctorTimeDuration
{
    public int Id { get; set; }

    public DateTime TimeFrom { get; set; }

    public DateTime? TimeTo { get; set; } 

    public TimeSpan TimeDuration { get; set; } = new TimeSpan(0, 30, 0);

    public int DoctorId { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;
}
