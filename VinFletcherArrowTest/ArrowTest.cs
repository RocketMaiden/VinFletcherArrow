using VinFletcherArrow;

namespace VinFletcherArrowTest
{

    public class ArrowTest
    {
        [Fact]
        public void ArrowCreated()
        {
            Arrow arrow = new Arrow(ArrowheadType.Steel, Fletching.Plastic, 65);

            Assert.True(arrow != null);
            Assert.True(arrow.arrowHead == ArrowheadType.Steel);
            Assert.True(arrow.fletching == Fletching.Plastic);
            Assert.True(arrow.length == 65);
        }
    }
}