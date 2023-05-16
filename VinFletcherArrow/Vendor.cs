namespace VinFletcherArrow
{
    public class Vendor
    {
        Arrow[] arrows; 
        
        public Vendor(Arrow[] arrows)
        {
            this.arrows = arrows;
        }

        public float GetCost(Arrow arrow)
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

            shaftPrice = arrow.length switch
            {
                5 => 2.5f,
                10 => 5.0f,
                15 => 7.5f,
            };

            cost += shaftPrice;

            return cost;
        }


        public Arrow? GetArrow(ArrowheadType arrowheadType, Fletching fletching, int length)
        {
            for (int i = 0; i < arrows.Length; i++)
            {
                //TODO move to Equals method
                if (arrows[i].arrowHead == arrowheadType && arrows[i].fletching == fletching && arrows[i].length == length)
                {
                    return arrows[i];
                }
            }
            return null;
        }


        //TODO write tests for Equals
    }
}
