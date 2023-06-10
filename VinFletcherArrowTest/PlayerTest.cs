using System;
using VinFletcherArrow;

namespace VinFletcherArrowTest
{
    public class PlayerTest
    {
        [Fact]
        public void BuyOneArrowHaveMoney()
        {
            Player player = new Player(30.0f);

            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 70),
                new Arrow (ArrowheadType.Obsidian, Fletching.Goose, 80)
            };
            Vendor vendor = new Vendor(vendor1_arrows);

            player.BuyArrow(vendor, ArrowheadType.Obsidian, Fletching.Plastic, 60, 1);

            Arrow[] playerArrows = player.ShowArrows();
            int countOfArrows = player.ShowCountOfArrows();

            Assert.True(playerArrows[countOfArrows - 1] != null);
            for(int i = countOfArrows; i < playerArrows.Length; i++)
            {
                Assert.True(playerArrows[i] == null);
            }
            
            Assert.True(playerArrows[0].arrowHead == ArrowheadType.Obsidian
                        && playerArrows[0].fletching == Fletching.Plastic
                        && playerArrows[0].length == 60);
        }

        [Fact]
        public void QuiverIsSmall()
        {
            Player player = new Player(100.0f);

            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 70),
                new Arrow (ArrowheadType.Obsidian, Fletching.Goose, 80)
            };
            Vendor vendor = new Vendor(vendor1_arrows);

            player.BuyArrow(vendor, ArrowheadType.Obsidian, Fletching.Plastic, 60, 12);

            Arrow[] playerArrows = player.ShowArrows();
            int countOfArrows = player.ShowCountOfArrows();

            for (int i = 0; i < playerArrows.Length; i++)
            {
                Assert.True(playerArrows[i] == null);
            }

            Assert.True(countOfArrows == 0);

        }

        [Fact]
        public void CantBuyNotEnoughMoney()
        {
            Player player = new Player(1.0f);

            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 70),
                new Arrow (ArrowheadType.Obsidian, Fletching.Goose, 80)
            };
            Vendor vendor = new Vendor(vendor1_arrows);

            player.BuyArrow(vendor, ArrowheadType.Obsidian, Fletching.Plastic, 60, 1);

            Arrow[] playerArrows = player.ShowArrows();
            int countOfArrows = player.ShowCountOfArrows();

            for (int i = 0; i < playerArrows.Length; i++)
            {
                Assert.True(playerArrows[i] == null);
            }
            Assert.True(countOfArrows == 0);

        }

        [Fact]
        public void BuySeveralTimes()
        {
            Player player = new Player(100.0f);

            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 70),
                new Arrow (ArrowheadType.Obsidian, Fletching.Goose, 80)
            };
            Vendor vendor = new Vendor(vendor1_arrows);

            player.BuyArrow(vendor, ArrowheadType.Obsidian, Fletching.Plastic, 60, 2);
            player.BuyArrow(vendor, ArrowheadType.Obsidian, Fletching.Turkey, 70, 1);

            Arrow[] playerArrows = player.ShowArrows();
            int countOfArrows = player.ShowCountOfArrows();
            
            for (int i = 0; i < countOfArrows - 1; i++)
            {
                Assert.True(playerArrows[i] != null);
            }

            for (int i = countOfArrows; i < playerArrows.Length; i++)
            {
                Assert.True(playerArrows[i] == null);
            }

            Assert.True(countOfArrows == 3);
        }
    }
}
