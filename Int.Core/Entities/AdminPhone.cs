﻿using System;
using System.Collections.Generic;

namespace Int.Core.Entities;

public partial class AdminPhone
{
    public int ASsn { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public virtual Admin ASsnNavigation { get; set; } = null!;
}
