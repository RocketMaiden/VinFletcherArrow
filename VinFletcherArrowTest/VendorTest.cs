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
                new Arrow (ArrowheadType.Obsidian, Fletching.Plastic, 5),
                new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, 10),
                new Arrow(ArrowheadType.Obsidian, Fletching.Goose, 10)
            };
            Vendor vendor1 = new Vendor(vendor1_arrows);

            Assert.True(vendor1 != null);
            Assert.True(Vendor.Equals(vendor1.arrows[0], ArrowheadType.Obsidian, Fletching.Plastic, 5));

            //but why it works with == null not with != null
            Assert.True(vendor1.GetArrow(ArrowheadType.Obsidian, Fletching.Plastic, 5) == null);
            Assert.True(vendor1.GetArrow(ArrowheadType.Obsidian, Fletching.Turkey, 10) == null);
            Assert.True(vendor1.GetArrow(ArrowheadType.Obsidian, Fletching.Goose, 10) == null);

            Assert.True(vendor1.GetCost(new Arrow(ArrowheadType.Obsidian, Fletching.Plastic, 5)) == 17.5f);
        }
    }
}
