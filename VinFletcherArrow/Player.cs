﻿namespace VinFletcherArrow
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

        public void BuyArrow(Vendor vendor, ArrowheadType arrowheadType, Fletching fletching, float length, int howMuch)
        {
            Arrow? desiredArrow = vendor.GetArrow(arrowheadType, fletching, length);
            float arrowCost = vendor.GetCost(desiredArrow);
            float totalSum = arrowCost * howMuch;

            if ((totalSum < gold) && (desiredArrow != null))
            {
                arrows[countOfArrows] = desiredArrow;
                countOfArrows++;
                gold -= arrowCost;
            }
        }
    }
}
