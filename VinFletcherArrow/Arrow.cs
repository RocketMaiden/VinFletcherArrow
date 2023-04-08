namespace VinFletcherArrow
{
    enum ArrowheadType
    {
        Steel,
        Wood,
        Obsidian
    }

    enum Fletching
    {
        Plastic,
        Turkey,
        Goose
    }
    
    class Arrow
    {
        public ArrowheadType arrowHead;
        public Fletching fletching;
        public float shaft;

        public Arrow(int arrowHead, int fletching, int shaft)
        {
            this.arrowHead = (ArrowheadType)arrowHead;
            this.fletching = (Fletching)fletching;
            this.shaft = shaft;
        }
    }
}
