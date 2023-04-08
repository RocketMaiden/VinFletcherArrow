using VinFletcherArrow;

Console.WriteLine("Let's create the arrow");
Console.WriteLine("Chose your arrowhead type - press 1 for steel, 2 for wood, 3 for obsidian");
int arrowhead;
int fletching;
int shaft;
int.TryParse(Console.ReadLine(), out arrowhead);
Console.WriteLine("Chose your fletching type - press 1 for plastic, 2 for turkey feathers, 3 for goose feathers");
int.TryParse(Console.ReadLine(),out fletching);
Console.WriteLine("Enter your shaft in cm");
int.TryParse(Console.ReadLine(), out  shaft);

Arrow arrow = new Arrow(arrowhead, fletching, shaft);

Console.WriteLine(GetCost(arrow));
Console.ReadLine();


float GetCost(Arrow arrow)
{
     float cost = 0;
     float arrowCost;
     float fletching;
     float shaftPrice;
     arrowCost = arrow.arrowHead switch
    {
        (ArrowheadType.Steel) => 10.0f,
        (ArrowheadType.Wood) => 3.0f,
        (ArrowheadType.Obsidian) => 5.0f
    };

    cost += arrowCost;

    fletching = arrow.fletching switch
    {
        (Fletching.Plastic) => 10.0f,
        (Fletching.Turkey) => 5.0f,
        (Fletching.Goose) => 3.0f,
    };

    cost += fletching;

    shaftPrice = arrow.shaft * 0.05f;

    cost += shaftPrice;

    return cost;
}




