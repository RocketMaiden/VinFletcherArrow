﻿namespace VinFletcherArrow
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
        public int length;

        public Arrow(int arrowHead, int fletching, int length)
        {
            this.arrowHead = (ArrowheadType)arrowHead;
            this.fletching = (Fletching)fletching;
            this.length = length;
        }

        public Arrow (ArrowheadType arrowHead, Fletching fletching, int length)
        {
            this.arrowHead = arrowHead;
            this.fletching = fletching;
            this.length = length;
        }
    }
}
