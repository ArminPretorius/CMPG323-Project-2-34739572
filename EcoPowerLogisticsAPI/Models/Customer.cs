using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EcoPowerLogisticsAPI.Models;

[Authorize]
public partial class Customer
{
    public short CustomerId { get; set; }

    public string? CustomerTitle { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerSurname { get; set; }

    public string? CellPhone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
