using System;
using System.Collections.Generic;

namespace Hotel;

public partial class TelephonCall
{
    public int CallId { get; set; }

    public int CallNumId { get; set; }

    public DateTime CallDate { get; set; }

    public string CallNum { get; set; } = null!;

    public virtual Guest CallNumNavigation { get; set; } = null!;
}
