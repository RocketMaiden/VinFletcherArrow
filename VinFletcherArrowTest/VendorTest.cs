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
            
        }
    }
}
