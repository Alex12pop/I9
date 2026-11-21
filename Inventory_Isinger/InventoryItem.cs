public class InventoryItem
{
    public string Name;
    public string Category;
    public int Quantity;
    public decimal Price;
    public bool IsAvailable;

    public InventoryItem(string name, string category, int quantity, decimal price, bool isAvailable)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        Price = price;
        IsAvailable = isAvailable;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Наименование: {Name}");
        Console.WriteLine($"Категория: {Category}");
        Console.WriteLine($"Количество: {Quantity} шт.");
        Console.WriteLine($"Цена за единицу: {Price:F2} руб.");
        Console.WriteLine($"Доступен: {(IsAvailable ? "да" : "нет")}");
        Console.WriteLine($"Стоимость позиции: {Quantity * Price:F2} руб.");
    }
}
