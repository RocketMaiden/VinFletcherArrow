namespace VinFletcherArrow
{
    public enum ArrowheadType
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum Fletching
    {
        Plastic,
        Turkey,
        Goose
    }
    
    public class Arrow
    {
        public ArrowheadType arrowHead;
        public Fletching fletching;
        //public float shaft;

        public Arrow(int arrowHead, int fletching)
        {
            this.arrowHead = (ArrowheadType)arrowHead;
            this.fletching = (Fletching)fletching;
            //this.shaft = shaft;
        }

        public Arrow (ArrowheadType arrowHead, Fletching fletching)
        {
            this.arrowHead = arrowHead;
            this.fletching = fletching;
        }
    }
}
