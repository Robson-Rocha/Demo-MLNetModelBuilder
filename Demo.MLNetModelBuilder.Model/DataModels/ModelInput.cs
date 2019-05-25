//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace Demo.MLNetModelBuilder.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("IsSpam"), LoadColumn(0)]
        public bool IsSpam { get; set; }


        [ColumnName("Message"), LoadColumn(1)]
        public string Message { get; set; }


    }
}
