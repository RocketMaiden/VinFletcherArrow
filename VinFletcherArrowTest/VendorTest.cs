using System;
using VinFletcherArrow;

namespace VinFletcherArrowTest
{

    public class VendorTest
    {
        [Fact]
        public void VendorCreated()
        {
            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 70),
                new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 80)
            };
            Vendor vendor1 = new Vendor(vendor1_arrows);

            Assert.True(vendor1 != null);
        }

        [Fact]
        public void MatchCheck()
        {
            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 100),
                new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 70)
            };
            Vendor vendor1 = new Vendor(vendor1_arrows);

            Assert.True(Vendor.Match(vendor1.arrows[0], ArrowheadType.Obsidian, Fletching.Plastic, 60));
        }

        [Fact]
        public void CheckCost()
        {
            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 100),
                new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 75)
            };
            Vendor vendor1 = new Vendor(vendor1_arrows);

            Assert.True(vendor1.GetCost(new Arrow(ArrowheadType.Obsidian, Fletching.Plastic, 60)) == 18.0f);
        }

        [Fact]
        public void GetSomeArrows()
        {
            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 75),
                new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 100)
            };
            Vendor vendor1 = new Vendor(vendor1_arrows);

            Assert.True(vendor1.GetArrow(ArrowheadType.Obsidian, Fletching.Plastic, 60) != null);
            Assert.True(vendor1.GetArrow(ArrowheadType.Obsidian, Fletching.Turkey, 75) != null);
            Assert.True(vendor1.GetArrow(ArrowheadType.Obsidian, Fletching.Goose, 100) != null);
        }

        [Fact]
        public void NotGettingArrows()
        {
            Arrow[] vendor1_arrows = new Arrow[] {
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 60),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 75),
                new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 100)
            };
            Vendor vendor1 = new Vendor(vendor1_arrows);

            Assert.True(vendor1.GetArrow(ArrowheadType.Obsidian, Fletching.Plastic, 65) == null);
        }
    }
}
