using System;
using System.Collections.Generic;

namespace StudentsAuthenticationSystem.Models;

public partial class Assignment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int CareerId { get; set; }

    public virtual Career Career { get; set; } = null!;
}
