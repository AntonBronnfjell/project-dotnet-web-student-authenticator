using System;
using System.Collections.Generic;

namespace StudentsAuthenticationSystem.Models;

public partial class Career
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
}
