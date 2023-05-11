using System;
using System.Collections.Generic;

namespace AppCore.Entity;

public class Specialty
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
