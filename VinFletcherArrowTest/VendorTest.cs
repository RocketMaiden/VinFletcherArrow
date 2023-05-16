using VinFletcherArrow;

namespace VinFletcherArrowTest
{

    public class VendorTest
    {
        [Fact]
        public void VendorCreated()
        {
            Arrow[] vendor1_arrows = new Arrow[] { new Arrow (ArrowheadType.Obsidian,  Fletching.Plastic, length = 5),
                                                     new Arrow (ArrowheadType.Obsidian, Fletching.Turkey, length = 10),
                                                        new Arrow(ArrowheadType.Obsidian, Fletching.Goose, length = 10)};
            Vendor vendor1 = new Vendor(vendor1_arrows);

            Assert.True(vendor1 != null);
            
        }
    }
}
