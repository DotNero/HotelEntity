using System;
using System.Collections.Generic;

namespace Hotel;

public partial class UsedAddictive
{
    public int UAddId { get; set; }

    public int AddId { get; set; }

    public int GId { get; set; }

    public virtual Addictive Add { get; set; } = null!;

    public virtual Guest GIdNavigation { get; set; } = null!;
}
