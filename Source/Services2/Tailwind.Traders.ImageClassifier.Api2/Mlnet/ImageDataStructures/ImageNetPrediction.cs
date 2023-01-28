using Microsoft.ML.Data;

namespace Tailwind.Traders.ImageClassifier.Api2.Mlnet.ImageDataStructures
{
    public class ImageNetPrediction
    {

        [ColumnName(TensorFlowModelSettings.outputTensorName)]
        public float[] PredictedLabels;

    }
}
