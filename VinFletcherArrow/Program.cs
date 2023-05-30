using VinFletcherArrow;

Console.WriteLine("Let's create the arrow");
Console.WriteLine("Chose your arrowhead type - press 1 for steel, 2 for wood, 3 for obsidian");
int arrowhead;
int fletching;
float length;
int howMuchArrowsToBuy;

int.TryParse(Console.ReadLine(), out arrowhead);
arrowhead--;
Console.WriteLine("Chose your fletching type - press 1 for plastic, 2 for turkey feathers, 3 for goose feathers");
int.TryParse(Console.ReadLine(), out fletching);
fletching--;
Console.WriteLine("Enter your shaft in cm, it can be between 60 and 100 cm");
float.TryParse(Console.ReadLine(), out length);
Console.WriteLine("Enter how much arrows do you want to buy");
int.TryParse(Console.ReadLine(), out  howMuchArrowsToBuy);

if ((arrowhead < 0 ||
    arrowhead > 2 ||
    fletching < 0 ||
    fletching > 2 ||
    length < 60.0f || 
    length > 100.0f))
{
    Console.WriteLine("Your input data is incorrect, try again");
    return;
}

Player player = new Player(35.0f);

Arrow desiredArrow = new Arrow(arrowhead, fletching, length);

Arrow[] vendor1_arrows = new Arrow[] { 
    new Arrow (ArrowheadType.Obsidian,  Fletching.Plastic, 60),
    new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 70),
    new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 75)
 };
Vendor vendor1 = new Vendor(vendor1_arrows);

Arrow[] vendor2_arrows = new Arrow[] { new Arrow(ArrowheadType.Steel, Fletching.Turkey, 100),
                                       new Arrow(ArrowheadType.Wood, Fletching.Goose, 100),
                                       new Arrow(ArrowheadType.Wood, Fletching.Goose, 90),
                                       new Arrow(ArrowheadType.Wood, Fletching.Plastic, 65)};
Vendor vendor2 = new Vendor(vendor2_arrows);

Console.WriteLine("Asking vendor1 if he has an arrow you wish");
AskVendor(vendor1, desiredArrow, player, howMuchArrowsToBuy);

Console.WriteLine("Asking vendor2 if he has an arrow you wish");
AskVendor(vendor2, desiredArrow, player, howMuchArrowsToBuy);


Console.ReadLine();

static void AskVendor(Vendor vendor, Arrow arrow, Player player, int howMuchArrowsToBuy)
{
    Arrow? vendorArrow = vendor.GetArrow(arrow.arrowHead, arrow.fletching, arrow.length);

    if (vendorArrow != null)
    {
        Console.WriteLine($"Here is the arrow you want: {vendorArrow}");
        Console.WriteLine($"It will cost you {vendor.GetCost(arrow)}");
        player.BuyArrow(vendor, arrow.arrowHead, arrow.fletching, arrow.length, howMuchArrowsToBuy);
    }
    else
    {
        Console.WriteLine("I don't have such an arrow");
    }
}