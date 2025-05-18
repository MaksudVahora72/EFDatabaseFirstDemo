using System;
using System.Collections.Generic;

namespace EFDatabaseFirstDemo.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDesciption { get; set; }

    public decimal? ProductRate { get; set; }
}
