﻿namespace Ogani.DAL.DataContext.Entities;

public class Category : BaseEntity
{
    public required string Name { get; set; }
    public required string ImageUrl { get; set; }
    public List<ProductCategory>? ProductCategories { get; set; }
}
