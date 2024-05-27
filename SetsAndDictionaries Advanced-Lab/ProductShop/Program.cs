using System;
using System.Diagnostics;

Dictionary<string, Dictionary<string, double>> shops = new();
//SortedDictionary<string, Dictionary<string, double>> shops = new();
string input;
while ((input = Console.ReadLine()) != "Revision")
{

    string[] shopInfo = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shopName = shopInfo[0];
    string product = shopInfo[1];
    double price = double.Parse(shopInfo[2]);
    if (!shops.ContainsKey(shopName))//ако не съществува
    {
        shops.Add(shopName, new Dictionary<string, double>());//добави нов магазин
    }
    //ако има магазин с това име добави продука и цената му
    shops[shopName].Add(product, price);
}
foreach (var shop in shops.OrderBy(x => x.Key))// ako e SortedDic тук не го сортираме
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var productInfo in shop.Value)
    {
        Console.WriteLine($"Product: {productInfo.Key}, Price: {productInfo.Value}");
    }

}

