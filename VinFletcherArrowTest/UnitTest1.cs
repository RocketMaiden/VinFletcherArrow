using VinFletcherArrow;

namespace VinFletcherArrowTest
{
    

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Arrow arrow = new Arrow(ArrowheadType.Obsidian, Fletching.Goose);
            Assert.True(arrow.fletching == Fletching.Goose);
        }
    }
}