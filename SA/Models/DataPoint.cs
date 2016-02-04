using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA.Models
{
    public class DataPoint
    {
        public string label { get; set; }
        public int y { get; set; }
        public int id { get; set; }
        public double cost { get; set; }
        public double sentimentValue { get; set; }

        // TEST DATA
        //public static List<DataPoint> GetDataPoints(int categoryId, Sentiment sentiment)
        //{
        //    var points = new List<DataPoint>();

        //    if (categoryId == 1)
        //    {
        //        switch (sentiment)
        //        {
        //            case Sentiment.Happy:
        //                points.Add(new DataPoint { label = "HTC One M8", y = 1233, id = 2, cost = 535.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Samsung Galaxy S6", y = 2456, id = 1, cost = 679.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Nokia Lumia Icon", y = 123, id = 3, cost = 499.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "HTC One M9", y = 133, id = 4, cost = 661.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Motorola Moto X", y = 212, id = 5, cost = 499.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "iPhone 6", y = 2982, id = 6, cost = 689.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "iPhone 6 Plus", y = 231, id = 7, cost = 949.74, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "ZTE Zmax", y = 123, id = 8, cost = 299.99, sentimentValue = 20 });
        //                break;
        //            case Sentiment.Sad:
        //                points.Add(new DataPoint { label = "HTC One M8", y = 2113, id = 2, cost = 535.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Samsung Galaxy S6", y = 246, id = 1, cost = 679.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Nokia Lumia Icon", y = 137, id = 3, cost = 499.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "HTC One M9", y = 113, id = 4, cost = 661.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Motorola Moto X", y = 12, id = 5, cost = 499.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "iPhone 6", y = 292, id = 6, cost = 689.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "iPhone 6 Plus", y = 123, id = 7, cost = 949.74, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "ZTE Zmax", y = 123, id = 8, cost = 299.99, sentimentValue = 20 });
        //                break;
        //            case Sentiment.Neutral:
        //                points.Add(new DataPoint { label = "HTC One M8", y = 123, id = 2, cost = 535.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Samsung Galaxy S6", y = 456, id = 1, cost = 679.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Nokia Lumia Icon", y = 23, id = 3, cost = 499.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "HTC One M9", y = 13, id = 4, cost = 661.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "Motorola Moto X", y = 12, id = 5, cost = 499.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "iPhone 6", y = 292, id = 6, cost = 689.99, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "iPhone 6 Plus", y = 31, id = 7, cost = 949.74, sentimentValue = 20 });
        //                points.Add(new DataPoint { label = "ZTE Zmax", y = 323, id = 8, cost = 299.99, sentimentValue = 20 });
        //                break;
        //        }
                
        //    }

        //    else if (categoryId == 2)
        //    {
        //        switch (sentiment)
        //        {
        //            case Sentiment.Happy:
        //                points.Add(new DataPoint {  id = 2, y = 2304, cost = 254.86, sentimentValue = 0, label = "Toshiba Satellite" });
        //                points.Add(new DataPoint {  id = 3, y = 2340, cost = 949.99, sentimentValue = 0, label = "MacBook Air" });
        //                points.Add(new DataPoint {  id = 4, y = 330, cost = 292.76, sentimentValue = 0, label = "Acer Aspire" });
        //                points.Add(new DataPoint {  id = 5, y = 230, cost = 899.99, sentimentValue = 0, label = "Lenovo Z70" });
        //                points.Add(new DataPoint {  id = 1, y = 560, cost = 339.99, sentimentValue = 0, label = "Dell Inspiron" });
        //                points.Add(new DataPoint {  id = 6, y = 450, cost = 173.99, sentimentValue = 0, label = "Acer Chrome Book" });
        //                points.Add(new DataPoint {  id = 7, y = 34, cost = 1216.27, sentimentValue = 0, label = "ASUS ROG" });
        //                break;
        //            case Sentiment.Sad:
        //                points.Add(new DataPoint {  id = 2, y = 234, cost = 254.86, sentimentValue = 0, label = "Toshiba Satellite" });
        //                points.Add(new DataPoint {  id = 3, y = 340, cost = 949.99, sentimentValue = 0, label = "MacBook Air" });
        //                points.Add(new DataPoint {  id = 4, y = 330, cost = 292.76, sentimentValue = 0, label = "Acer Aspire" });
        //                points.Add(new DataPoint {  id = 5, y = 530, cost = 899.99, sentimentValue = 0, label = "Lenovo Z70" });
        //                points.Add(new DataPoint {  id = 1, y = 502, cost = 339.99, sentimentValue = 0, label = "Dell Inspiron" });
        //                points.Add(new DataPoint {  id = 6, y = 150, cost = 173.99, sentimentValue = 0, label = "Acer Chrome Book" });
        //                points.Add(new DataPoint {  id = 7, y = 13, cost = 1216.27, sentimentValue = 0, label = "ASUS ROG" });
        //                break;
        //            case Sentiment.Neutral:
        //                points.Add(new DataPoint {  id = 2, y = 304, cost = 254.86, sentimentValue = 0, label = "Toshiba Satellite" });
        //                points.Add(new DataPoint {  id = 3, y = 340, cost = 949.99, sentimentValue = 0, label = "MacBook Air" });
        //                points.Add(new DataPoint {  id = 4, y = 30, cost = 292.76, sentimentValue = 0, label = "Acer Aspire" });
        //                points.Add(new DataPoint {  id = 5, y = 30, cost = 899.99, sentimentValue = 0, label = "Lenovo Z70" });
        //                points.Add(new DataPoint {  id = 1, y = 60, cost = 339.99, sentimentValue = 0, label = "Dell Inspiron" });
        //                points.Add(new DataPoint {  id = 6, y = 50, cost = 173.99, sentimentValue = 0, label = "Acer Chrome Book" });
        //                points.Add(new DataPoint {  id = 7, y = 4, cost = 1216.27, sentimentValue = 0, label = "ASUS ROG" });
        //                break;
        //        }
        //    }

        //    else if (categoryId == 3)
        //    {
        //        switch (sentiment)
        //        {
        //            case Sentiment.Happy:
        //                points.Add(new DataPoint { y = 230, id = 2, cost = 59.00, sentimentValue = 0, label = "Mortal Kombat X" });
        //                points.Add(new DataPoint { y = 202, id = 1, cost = 27.68, sentimentValue = 0, label = "Middle Earth: Shadow of Mordor" });
        //                points.Add(new DataPoint { y = 2230, id = 3, cost = 51.99, sentimentValue = 0, label = "Grand Theft Auto V" });
        //                points.Add(new DataPoint { y = 230, id = 4, cost = 59.74, sentimentValue = 0, label = "Bloodborne" });
        //                break;
        //            case Sentiment.Sad:
        //                points.Add(new DataPoint { y = 83, id = 2, cost = 59.00, sentimentValue = 0, label = "Mortal Kombat X" });
        //                points.Add(new DataPoint { y = 122, id = 1, cost = 27.68, sentimentValue = 0, label = "Middle Earth: Shadow of Mordor" });
        //                points.Add(new DataPoint { y = 345, id = 3, cost = 51.99, sentimentValue = 0, label = "Grand Theft Auto V" });
        //                points.Add(new DataPoint { y = 230, id = 4, cost = 59.74, sentimentValue = 0, label = "Bloodborne" });
        //                break;
        //            case Sentiment.Neutral:
        //                points.Add(new DataPoint { y = 20, id = 2, cost = 59.00, sentimentValue = 0, label = "Mortal Kombat X" });
        //                points.Add(new DataPoint { y = 102, id = 1, cost = 27.68, sentimentValue = 0, label = "Middle Earth: Shadow of Mordor" });
        //                points.Add(new DataPoint { y = 230, id = 3, cost = 51.99, sentimentValue = 0, label = "Grand Theft Auto V" });
        //                points.Add(new DataPoint { y = 30, id = 4, cost = 59.74, sentimentValue = 0, label = "Bloodborne" });
        //                break;
        //        }
        //    }

        //    else if (categoryId == 4)
        //    {
        //        switch (sentiment)
        //        {
        //            case Sentiment.Happy:
        //                points.Add(new DataPoint { y = 63, id = 1, cost = 179.95, sentimentValue = 0, label = "Yamaha RX-V377" });
        //                points.Add(new DataPoint { y = 8, id = 2, cost = 199.00, sentimentValue = 0, label = "SONOS PLAY:1" });
        //                points.Add(new DataPoint { y = 56, id = 3, cost = 299.00, sentimentValue = 0, label = "Onkyo TX-NR626" });
        //                points.Add(new DataPoint { y = 45, id = 4, cost = 379.00, sentimentValue = 0, label = "Yamaha RX-V675" });
        //                points.Add(new DataPoint { y = 29, id = 5, cost = 99.99, sentimentValue = 0, label = "Polk Audio PSW10" });
        //                break;
        //            case Sentiment.Sad:
        //                points.Add(new DataPoint { y = 12, id = 1, cost = 179.95, sentimentValue = 0, label = "Yamaha RX-V377" });
        //                points.Add(new DataPoint { y = 10, id = 2, cost = 199.00, sentimentValue = 0, label = "SONOS PLAY:1" });
        //                points.Add(new DataPoint { y = 31, id = 3, cost = 299.00, sentimentValue = 0, label = "Onkyo TX-NR626" });
        //                points.Add(new DataPoint { y = 8, id = 4, cost = 379.00, sentimentValue = 0, label = "Yamaha RX-V675" });
        //                points.Add(new DataPoint { y = 17, id = 5, cost = 99.99, sentimentValue = 0, label = "Polk Audio PSW10" });
        //                break;
        //            case Sentiment.Neutral:
        //                points.Add(new DataPoint { y = 24, id = 1, cost = 179.95, sentimentValue = 0, label = "Yamaha RX-V377" });
        //                points.Add(new DataPoint { y = 27, id = 2, cost = 199.00, sentimentValue = 0, label = "SONOS PLAY:1" });
        //                points.Add(new DataPoint { y = 10, id = 3, cost = 299.00, sentimentValue = 0, label = "Onkyo TX-NR626" });
        //                points.Add(new DataPoint { y = 16, id = 4, cost = 379.00, sentimentValue = 0, label = "Yamaha RX-V675" });
        //                points.Add(new DataPoint { y = 50, id = 5, cost = 99.99, sentimentValue = 0, label = "Polk Audio PSW10" });
        //                break;
        //        }
        //    }

        //    else if (categoryId == 5)
        //    {
        //        switch (sentiment)
        //        {
        //            case Sentiment.Happy:
        //                points.Add(new DataPoint { y = 10, id = 1, cost = 67.99, sentimentValue = 0, label = "Nikon Coolpix S2800" });
        //                points.Add(new DataPoint { y = 41, id = 2, cost = 78.99, sentimentValue = 0, label = "Sony W800/B" });
        //                points.Add(new DataPoint { y = 27, id = 3, cost = 199, sentimentValue = 0, label = "Canon PowerShot SX520" });
        //                points.Add(new DataPoint { y = 50, id = 4, cost = 410.89, sentimentValue = 0, label = "Canon EOS Rebel T5 EF-S" });
        //                points.Add(new DataPoint { y = 18, id = 5, cost = 154.2, sentimentValue = 0, label = "Fujifilm XP70" });
        //                points.Add(new DataPoint { y = 39, id = 6, cost = 154.95, sentimentValue = 0, label = "Nikon COOLPIX L830" });
        //                break;
        //            case Sentiment.Sad:
        //                points.Add(new DataPoint { y = 10, id = 1, cost = 67.99, sentimentValue = 0, label = "Nikon Coolpix S2800" });
        //                points.Add(new DataPoint { y = 13, id = 2, cost = 78.99, sentimentValue = 0, label = "Sony W800/B" });
        //                points.Add(new DataPoint { y = 7, id = 3, cost = 199, sentimentValue = 0, label = "Canon PowerShot SX520" });
        //                points.Add(new DataPoint { y = 15, id = 4, cost = 410.89, sentimentValue = 0, label = "Canon EOS Rebel T5 EF-S" });
        //                points.Add(new DataPoint { y = 12, id = 5, cost = 154.2, sentimentValue = 0, label = "Fujifilm XP70" });
        //                points.Add(new DataPoint { y = 5, id = 6, cost = 154.95, sentimentValue = 0, label = "Nikon COOLPIX L830" });
        //                break;
        //            case Sentiment.Neutral:
        //                points.Add(new DataPoint { y = 12, id = 1, cost = 67.99, sentimentValue = 0, label = "Nikon Coolpix S2800" });
        //                points.Add(new DataPoint { y = 56, id = 2, cost = 78.99, sentimentValue = 0, label = "Sony W800/B" });
        //                points.Add(new DataPoint { y = 9, id = 3, cost = 199, sentimentValue = 0, label = "Canon PowerShot SX520" });
        //                points.Add(new DataPoint { y = 67, id = 4, cost = 410.89, sentimentValue = 0, label = "Canon EOS Rebel T5 EF-S" });
        //                points.Add(new DataPoint { y = 6, id = 5, cost = 154.2, sentimentValue = 0, label = "Fujifilm XP70" });
        //                points.Add(new DataPoint { y = 12, id = 6, cost = 154.95, sentimentValue = 0, label = "Nikon COOLPIX L830" });
        //                break;
        //        }
        //    }

        //    else if (categoryId == 6)
        //    {
        //        switch (sentiment)
        //        {
        //            case Sentiment.Happy:
        //                points.Add(new DataPoint { y = 0, id = 0, cost = 0, sentimentValue = 0, label = "" });
        //                break;
        //            case Sentiment.Sad:
        //                points.Add(new DataPoint { y = 0, id = 0, cost = 0, sentimentValue = 0, label = "" });
        //                break;
        //            case Sentiment.Neutral:
        //                points.Add(new DataPoint { y = 0, id = 0, cost = 0, sentimentValue = 0, label = "" });
        //                break;
        //        }
        //    }
        //    return points;
        //}
    }

    public enum Sentiment {Happy, Neutral, Sad}
}