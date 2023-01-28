using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tailwind.Traders.ImageClassifier.Api2.Mlnet.ImageDataStructures;

namespace Tailwind.Traders.ImageClassifier.Api2
{
    public interface IImageScoringService
    {
        ImagePredictedLabelWithProbability Score(ImageInputData imageName);
        void Init();

        string ImagesFolder { get; }
    }
}
