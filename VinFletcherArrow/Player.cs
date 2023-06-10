namespace VinFletcherArrow
{
    public class Player
    {
        const int capacity = 10;
        float gold;
        Arrow[] arrows;
        int countOfArrows;

        public Player(float gold)
        {
            this.gold = gold;
            arrows = new Arrow[capacity];
            countOfArrows = 0;
        }

        public void BuyArrow(Vendor vendor, ArrowheadType arrowheadType, Fletching fletching, int length, int howMuch)
        {
            Arrow? desiredArrow = vendor.GetArrow(arrowheadType, fletching, length);
            float arrowCost = vendor.GetCost(desiredArrow);
            float totalSum = arrowCost * howMuch;

            if ((totalSum < gold) && (desiredArrow != null) && ((countOfArrows + howMuch) <= capacity))
            {
                for (int i = 0; i < howMuch; i++)
                {
                    arrows[countOfArrows] = desiredArrow;
                    countOfArrows++;
                }
                gold -= totalSum;
            }
        }

        public Arrow[] ShowArrows()
        {
            return arrows;
        }

        public int ShowCountOfArrows()
        {
            return countOfArrows;
        }
    }
}
