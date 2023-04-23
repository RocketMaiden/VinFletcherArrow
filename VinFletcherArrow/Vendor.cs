namespace VinFletcherArrow
{
    class Vendor
    {
        private List<Arrow> arrowList = new List<Arrow>();

        private void CreateArrows()
        {
            foreach (ArrowheadType arrowheadType in Enum.GetValues(typeof(ArrowheadType)))
            {
                foreach (Fletching fletching in Enum.GetValues(typeof(Fletching)))
                {
                    Arrow arrow = new Arrow(arrowheadType, fletching);
                    arrowList.Add(arrow);
                }
            }
        }

        public Vendor()
        {
            CreateArrows();
        }

        public float GetCost(Arrow arrow)
        {
            float cost = 0;
            float arrowCost;
            float fletching;
            //float shaftPrice;
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

            //shaftPrice = arrow.shaft * 0.05f;

            //cost += shaftPrice;

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
