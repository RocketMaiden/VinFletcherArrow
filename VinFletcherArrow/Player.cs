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

        public void BuyArrow(Vendor vendor, Arrow desiredArrow)
        {
            float arrowCost = vendor.GetCost(desiredArrow);

            if ((arrowCost < gold) && (vendor.GetArrow(desiredArrow.arrowHead, desiredArrow.fletching, desiredArrow.length) != null))
            {
                arrows[countOfArrows] = desiredArrow;
                countOfArrows++;
                gold -= arrowCost;
            }
        }
    }
}
