using System;
using System.Collections.Generic;

namespace Hotel;

public partial class Addictive
{
    public int AddId { get; set; }

    public string AddName { get; set; } = null!;

    public int AddPrice { get; set; }

    public virtual ICollection<UsedAddictive> UsedAddictives { get; set; } = new List<UsedAddictive>();
}
