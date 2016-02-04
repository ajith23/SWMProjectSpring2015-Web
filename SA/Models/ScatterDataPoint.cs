using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA.Models
{
    public class ScatterDataPoint
    {
        public double x { get; set; } //cost
        public double y { get; set; } //sentiment value
        public double z { get; set; } //sentiment value
        public string label { get; set; }
        public double popularity { get; set; }

        //public static List<ScatterDataPoint> GetScatterDataPoints(int categoryId)
        //{
        //    var points = new List<ScatterDataPoint>();
        //    var tempHappy = DataPoint.GetDataPoints(categoryId, Sentiment.Happy);
        //    var tempSad = DataPoint.GetDataPoints(categoryId, Sentiment.Sad);
        //    var tempNeutral = DataPoint.GetDataPoints(categoryId, Sentiment.Neutral);
        //    var totalReviewCount = tempHappy.Select(t => t.y).Sum() + tempSad.Select(t => t.y).Sum() + tempNeutral.Select(t => t.y).Sum();
        //    var index = 0;
        //    foreach (var item in tempHappy)
        //    {
        //        points.Add(new ScatterDataPoint
        //        {
        //            label = item.label,
        //            y = Math.Round(item.y / (double)(item.y + tempSad[index].y), 2),
        //            x = item.cost,
        //            z = item.y + tempSad[index].y + tempNeutral[index].y,
        //            popularity = Math.Round(((item.y + tempSad[index].y + tempNeutral[index].y) / (double)totalReviewCount) * 100, 2)
        //        });
        //        index++;
        //    }
        //    return points;
        //}
    }
}