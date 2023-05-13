using System;
using System.Collections.Generic;

namespace Hotel;

public partial class AppCategory
{
    public int CatgId { get; set; }

    public string CatgName { get; set; } = null!;

    public int PrcOnePr { get; set; }

    public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
}
