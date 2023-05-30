namespace VinFletcherArrow
{
    public class Vendor
    {
        public Arrow[] arrows; 
        
        public Vendor(Arrow[] arrows)
        {
            this.arrows = arrows;
        }

        public float GetCost(Arrow? arrow)
        {
            float cost = 0;
            float arrowCost;
            float fletching;
            float shaftPrice;

            if(arrow == null)
            {
                return 0;
            }
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

            shaftPrice = arrow.length * 0.05f;

            cost += shaftPrice;

            return cost;
        }

        public Arrow? GetArrow(ArrowheadType arrowheadType, Fletching fletching, float length)
        {
            for (int i = 0; i < arrows.Length; i++)
            {
                if (Match(arrows[i], arrowheadType, fletching, length))
                {
                    return arrows[i];
                }
            }
            return null;
        }

        public static bool Match(Arrow desiredArrow, ArrowheadType arrowheadType, Fletching fletching, float length)
        {
            return (desiredArrow.arrowHead == arrowheadType && desiredArrow.fletching == fletching && desiredArrow.length == length);
        }
    }
}
