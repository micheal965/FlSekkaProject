using System;
using System.Collections.Generic;

namespace Int.Core.Entities;

public partial class Car
{
    public int CId { get; set; }

    public string? Description { get; set; }

    public string Location { get; set; } = null!;

    public int? CPlateNumber { get; set; }

    public int? CCode { get; set; }

    public int? BCode { get; set; }

    public virtual AdminMnageCar? AdminMnageCar { get; set; }

    public virtual Brand? BCodeNavigation { get; set; }

    public virtual Color? CCodeNavigation { get; set; }

    public virtual ICollection<CarPhoto> CarPhotos { get; set; } = new List<CarPhoto>();

    public virtual SearchCar? SearchCar { get; set; }

    public virtual ICollection<User> USsns { get; set; } = new List<User>();
}
