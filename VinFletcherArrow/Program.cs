using VinFletcherArrow;

Console.WriteLine("Let's create the arrow");
Console.WriteLine("Chose your arrowhead type - press 1 for steel, 2 for wood, 3 for obsidian");
int arrowhead;
int fletching;
//int shaft;
int.TryParse(Console.ReadLine(), out arrowhead);
Console.WriteLine("Chose your fletching type - press 1 for plastic, 2 for turkey feathers, 3 for goose feathers");
int.TryParse(Console.ReadLine(),out fletching);
//Console.WriteLine("Enter your shaft in cm");
//int.TryParse(Console.ReadLine(), out  shaft);

Arrow arrow = new Arrow(arrowhead, fletching);
Vendor vendor = new Vendor();


Console.ReadLine();



}




