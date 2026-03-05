using System;
using System.ComponentModel;

InventoryItem[] items =
{
    new InventoryItem("검", 3.5, 1500),
    new InventoryItem("방패", 5.0, 1200),
    new InventoryItem("포션", 0.3, 50),
    new InventoryItem("활", 1.8, 1300),
    new InventoryItem("투구", 2.0, 800),
};


double total_weight = 0;
int total_price = 0;
int max_price_item_index = 0;
int min_weight_item_index = 0;
int max_price = int.MinValue;
double min_weight = int.MaxValue;

Console.WriteLine("=== 인벤토리 목록 ===");
for (int i = 0; i < items.Length; i++)
{
    items[i].PrintInfo();
    total_weight += items[i].Weight;
    total_price += items[i].Price;
    if (items[i].Weight < min_weight)
    {
        min_weight = items[i].Weight;
        min_weight_item_index = i;
    }
    if (items[i].Price > max_price)
    {
        max_price = items[i].Price;
        max_price_item_index = i;
    }
}

Console.WriteLine("\n=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게: {total_weight:F1}kg");
Console.WriteLine($"전체 가격: {total_price}골드");
Console.WriteLine($"평균 가격: {total_price / items.Length}골드");
Console.WriteLine($"가장 비싼 아이템: {items[max_price_item_index].Name}");
Console.WriteLine($"가장 가벼운 아이템: {items[min_weight_item_index].Name}");