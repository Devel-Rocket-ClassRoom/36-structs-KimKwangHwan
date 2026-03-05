using System;
using System.Collections.Generic;
using System.Text;

struct InventoryItem
{
    public string Name;
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
    {
        Name = name; Weight = weight; Price = price;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} - 무게: {Weight}kg, 가격: {Price}골드");
    }
}