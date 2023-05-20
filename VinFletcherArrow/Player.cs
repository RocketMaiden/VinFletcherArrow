namespace VinFletcherArrow
{
    public class Player
    {
        float gold;
        Arrow[] arrows;
        int countOfArrows;

        public Player(float gold)
        {
            this.gold = gold;
            arrows = new Arrow[10];
            countOfArrows = 0;
        }

        public void BuyArrow(Vendor vendor, ArrowheadType arrowheadType, Fletching fletching, int length)
        {
            Arrow? desiredArrow = vendor.GetArrow(arrowheadType, fletching, length);
            float arrowCost = vendor.GetCost(desiredArrow);

            if ((arrowCost < gold) && (desiredArrow != null))
            {
                arrows[countOfArrows] = desiredArrow;
                countOfArrows++;
                gold -= arrowCost;
            }
        }
    }
}
