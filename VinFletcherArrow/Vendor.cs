namespace VinFletcherArrow
{
    class Vendor
    {
        //private List<Arrow> arrowList = new List<Arrow>();

        /*private void CreateArrows()
        {
            foreach (ArrowheadType arrowheadType in Enum.GetValues(typeof(ArrowheadType)))
            {
                foreach (Fletching fletching in Enum.GetValues(typeof(Fletching)))
                {
                    Arrow arrow = new Arrow(arrowheadType, fletching, 10);
                    arrowList.Add(arrow);
                }
            }
        }*/

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

        public Arrow GetArrow(ArrowheadType arrowheadType, Fletching fletching)
        {
            List<Arrow> arrowsWithHeads = arrowList.FindAll(head => head.arrowHead == arrowheadType);
            Arrow perfectArrow = arrowsWithHeads.Find(fl => fl.fletching == fletching);
            return perfectArrow;
        }
    }
}
