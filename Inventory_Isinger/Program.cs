

List<InventoryItem> items = new()
{
    new InventoryItem("Ноутбук Lenovo", "Электроника", 2, 74999.90m, true),
    new InventoryItem("Мышь Logitech", "Периферия", 5, 2499.00m, true),
    new InventoryItem("Клавиатура механическая", "Периферия", 3, 5990.50m, false)
};

Console.WriteLine("УЧЁТ ИНВЕНТАРЯ");
Console.WriteLine($"Автор: Изингер Алексей | Группа: ИСП-242");
Console.WriteLine();

for (int i = 0; i < items.Count; i++)
{
    Console.WriteLine($"Позиция {i + 1}");
    items[i].PrintInfo();
    Console.WriteLine();
}


items[1].Quantity = 4;

Console.WriteLine("ПОСЛЕ ИЗМЕНЕНИЯ КОЛИЧЕСТВА МЫШЕЙ");
foreach (InventoryItem item in items)
{
    Console.WriteLine($"{item.Name}: {item.Quantity} шт.");
}
