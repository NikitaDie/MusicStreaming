﻿using System;
using System.Collections.Generic;

namespace Cinema.Core.Models;

public partial class Pricelist
{
    public Guid Id { get; set; }

    public Guid SessionId { get; set; }

    public Guid StatusId { get; set; }

    public decimal Price { get; set; }

    public virtual Session Session { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}