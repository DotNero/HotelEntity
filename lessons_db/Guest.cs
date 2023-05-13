using System;
using System.Collections.Generic;

namespace Hotel;

/// <summary>
/// Info about guests and keys
/// </summary>
public partial class Guest
{
    /// <summary>
    /// Guest&apos;s id
    /// </summary>
    public int GId { get; set; }

    public int ApId { get; set; }

    public int GTelNumId { get; set; }

    public DateOnly InTime { get; set; }

    public DateOnly OutTime { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public virtual Apartment Ap { get; set; } = null!;

    public virtual ICollection<TelephonCall> TelephonCalls { get; set; } = new List<TelephonCall>();

    public virtual ICollection<UsedAddictive> UsedAddictives { get; set; } = new List<UsedAddictive>();
}
