﻿using VinFletcherArrow;

Console.WriteLine("Let's create the arrow");
Console.WriteLine("Chose your arrowhead type - press 1 for steel, 2 for wood, 3 for obsidian");
int arrowhead;
int fletching;
int length;
int.TryParse(Console.ReadLine(), out arrowhead);
arrowhead--;
Console.WriteLine("Chose your fletching type - press 1 for plastic, 2 for turkey feathers, 3 for goose feathers");
int.TryParse(Console.ReadLine(), out fletching);
fletching--;
Console.WriteLine("Enter your shaft in cm");
int.TryParse(Console.ReadLine(), out length);

Arrow desiredArrow = new Arrow(arrowhead, fletching, length);

Arrow[] vendor1_arrows = new Arrow[] { new Arrow (ArrowheadType.Obsidian,  Fletching.Plastic, length = 5),
                                       new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, length = 10),
                                       new Arrow(ArrowheadType.Obsidian, Fletching.Goose, length = 10)};
Vendor vendor1 = new Vendor(vendor1_arrows);

Arrow[] vendor2_arrows = new Arrow[] { new Arrow(ArrowheadType.Steel, Fletching.Turkey, length = 5),
                                       new Arrow(ArrowheadType.Wood, Fletching.Goose, length = 5),
                                       new Arrow(ArrowheadType.Wood, Fletching.Goose, length = 10),
                                       new Arrow(ArrowheadType.Wood, Fletching.Plastic, length = 15)};
Vendor vendor2 = new Vendor(vendor2_arrows);

Console.WriteLine("Asking vendor1 if he has an arrow you wish");
AskVendor(vendor1, desiredArrow);

Console.WriteLine("Asking vendor2 if he has an arrow you wish");
AskVendor(vendor2, desiredArrow);

Console.ReadLine();

static void AskVendor(Vendor vendor, Arrow arrow)
{
    if (vendor.GetArrow(arrow.arrowHead, arrow.fletching, arrow.length) != null)
    {
        Console.WriteLine($"Here is your arrow: {vendor.GetArrow(arrow.arrowHead, arrow.fletching, arrow.length)}");
        Console.WriteLine($"It will cost you {vendor.GetCost(arrow)}");
    }
    else
    {
        Console.WriteLine("I don't have such an arrow");
    }
}