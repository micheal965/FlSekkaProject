using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Int.Core.Entities;

public partial class CarPhoto
{
    public int Id { get; set; }

    public string imageUrl { get; set; }
    public string publicId { get; set; }
    [ForeignKey("CIdNavigation")]
    public int carId { get; set; }
    public virtual Car car { get; set; }
}
