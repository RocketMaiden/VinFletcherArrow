using VinFletcherArrow;

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

if (!(arrowhead > 0 ||
    arrowhead < 2 ||
    fletching > 0 ||
    fletching < 2 ||
    length == 5 ||
    length == 10 ||
    length == 15))
{
    Console.WriteLine("Your input data is incorrect, try again");
    return;
}

Player player = new Player(35.0f);

Arrow desiredArrow = new Arrow(arrowhead, fletching, length);

Arrow[] vendor1_arrows = new Arrow[] { 
    new Arrow (ArrowheadType.Obsidian,  Fletching.Plastic, 5),
    new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 10),
    new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 10)
 };
Vendor vendor1 = new Vendor(vendor1_arrows);

Arrow[] vendor2_arrows = new Arrow[] { new Arrow(ArrowheadType.Steel, Fletching.Turkey, 5),
                                       new Arrow(ArrowheadType.Wood, Fletching.Goose, 5),
                                       new Arrow(ArrowheadType.Wood, Fletching.Goose, 10),
                                       new Arrow(ArrowheadType.Wood, Fletching.Plastic, 15)};
Vendor vendor2 = new Vendor(vendor2_arrows);

Console.WriteLine("Asking vendor1 if he has an arrow you wish");
AskVendor(vendor1, desiredArrow, player);

Console.WriteLine("Asking vendor2 if he has an arrow you wish");
AskVendor(vendor2, desiredArrow, player);


Console.ReadLine();

static void AskVendor(Vendor vendor, Arrow arrow, Player player)
{
    Arrow? vendorArrow = vendor.GetArrow(arrow.arrowHead, arrow.fletching, arrow.length);

    if (vendorArrow != null)
    {
        Console.WriteLine($"Here is the arrow you want: {vendorArrow}");
        Console.WriteLine($"It will cost you {vendor.GetCost(arrow)}");
        player.BuyArrow(vendor, arrow.arrowHead, arrow.fletching, arrow.length);
    }
    else
    {
        Console.WriteLine("I don't have such an arrow");
    }
}