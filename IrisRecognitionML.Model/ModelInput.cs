// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace IrisRecognitionML.Model
{
    public class ModelInput
    {
        [ColumnName("sepal_length"), LoadColumn(0)]
        public float Sepal_length { get; set; }


        [ColumnName("sepal_width"), LoadColumn(1)]
        public float Sepal_width { get; set; }


        [ColumnName("petal_length"), LoadColumn(2)]
        public float Petal_length { get; set; }


        [ColumnName("petal_width"), LoadColumn(3)]
        public float Petal_width { get; set; }


        [ColumnName("variety"), LoadColumn(4)]
        public string Variety { get; set; }


    }
}
