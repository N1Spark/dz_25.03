using System;
using System.Collections.Generic;

namespace SQL_в_Entity_Framework_Core;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Calories { get; set; }

    public string? Type { get; set; }

    public string? Color { get; set; }
    public override string ToString()
    {
        return $"Название: {Name}, Тип: {Type}, Цвет: {Color}, Калорий: {Calories}";
    }
}
