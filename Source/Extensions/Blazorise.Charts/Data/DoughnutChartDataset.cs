﻿#region Using directives
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
#endregion

namespace Blazorise.Charts
{
    [DataContract]
    public class DoughnutChartDataset<T> : PieChartDataset<T>
    {
        public DoughnutChartDataset()
            : base()
        {
            Type = "doughnut";
        }
    }
}
