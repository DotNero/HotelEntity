using System;
using System.Collections.Generic;

namespace Hotel;

public partial class Apartment
{
    public int ApId { get; set; }

    public int ApNumber { get; set; }

    public int ApCategotyId { get; set; }

    public int ApCapacity { get; set; }

    public virtual AppCategory ApCategoty { get; set; } = null!;

    public virtual ICollection<Guest> Guests { get; set; } = new List<Guest>();
}
