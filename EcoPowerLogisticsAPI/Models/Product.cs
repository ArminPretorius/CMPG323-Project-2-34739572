﻿using System;
using System.Collections.Generic;

namespace EcoPowerLogisticsAPI.Models;

public partial class Product
{
    public short ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductDescription { get; set; }

    public int? UnitsInStock { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}