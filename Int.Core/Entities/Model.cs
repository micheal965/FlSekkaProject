using System;
using System.Collections.Generic;

namespace Int.Core.Entities;

public partial class Model
{
    public int MCode { get; set; }

    public string MName { get; set; } = null!;

    public int? BCode { get; set; }

    public virtual Brand? BCodeNavigation { get; set; }
}
