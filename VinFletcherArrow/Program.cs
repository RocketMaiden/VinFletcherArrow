using VinFletcherArrow;

Console.WriteLine("Let's create the arrow");
Console.WriteLine("Chose your arrowhead type - press 1 for steel, 2 for wood, 3 for obsidian");
int arrowhead;
int fletching;
int length;
int.TryParse(Console.ReadLine(), out arrowhead);
arrowhead--;
Console.WriteLine("Chose your fletching type - press 1 for plastic, 2 for turkey feathers, 3 for goose feathers");
int.TryParse(Console.ReadLine(),out fletching);
fletching--;
Console.WriteLine("Enter your shaft in cm");
int.TryParse(Console.ReadLine(), out  length);

Arrow arrow = new Arrow(arrowhead, fletching, length);
Vendor vendor = new Vendor();

Console.WriteLine($"The arrow you wish will cost you {vendor.GetCost(arrow)}");

Arrow purchasedArrow = vendor.GetArrow(arrow.arrowHead, arrow.fletching);

Console.WriteLine($"Here is your purchased arrow: {purchasedArrow.arrowHead}, {purchasedArrow.fletching}");

Console.ReadLine();