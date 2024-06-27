﻿using System;
using System.Collections.Generic;

namespace ProductsMinimalAPIBlazorClient_1165395.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
