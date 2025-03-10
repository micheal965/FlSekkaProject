using System;
using System.Collections.Generic;

namespace Int.Core.Entities;

public partial class CarPhoto
{
    public int PhotoId { get; set; }

    public int CId { get; set; }

    public byte[] Photo { get; set; } = null!;
    public string PhotoUrl { get; set; } = string.Empty;


    public virtual Car CIdNavigation { get; set; } = null!;
}
