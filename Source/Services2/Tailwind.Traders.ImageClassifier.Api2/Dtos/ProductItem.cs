﻿namespace Tailwind.Traders.ImageClassifier.Api2.Dtos
{
    public class ProductItem
    {
        public ProductItem(string label, decimal prob)
        {
            Label = label;
            Probability = prob;
        }
        public string Label { get; }
        public decimal Probability { get; }
    }
}
