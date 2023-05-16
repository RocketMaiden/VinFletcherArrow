using VinFletcherArrow;

namespace VinFletcherArrowTest
{   

    public class ArrowTest
    {
        [Fact]
        public void Test1()
        {
            Arrow arrow = new Arrow(ArrowheadType.Steel, Fletching.Plastic, 5);

            Assert.True(arrow.arrowHead == ArrowheadType.Steel);
            Assert.True(arrow.fletching == Fletching.Plastic);
            Assert.True(arrow.length == 5);
        }
    }
}