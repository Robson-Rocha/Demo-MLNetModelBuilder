using System;
using Microsoft.ML;
using Demo.MLNetModelBuilder.Model.DataModels;

namespace Demo.MLNetModelBuilder.DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MLContext mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            var input = new ModelInput();
            input.Message = "You won a free waffle! Click https://waffle4.us/offer to get your special offer!";

            // Try model on sample data
            ModelOutput result = predEngine.Predict(input);

            Console.WriteLine($"The message '{input.Message}' was predicted to be {(result.Prediction ? "SPAM" : "HAM")}");
            Console.Read();
        }
    }
}
