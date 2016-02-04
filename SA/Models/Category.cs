using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA.Models
{
    public class Category
    {
        public int id { get; set; }
        
        public string label { get; set; }

        public int y { get; set; }

        //public static List<Category> GetCategoryList()
        //{
        //    var categoryList = new List<Category>();
        //    categoryList.Add(new Category { id = 1, y = DataPoint.GetDataPoints(1, Sentiment.Happy).Count(), label = "Phones" });
        //    categoryList.Add(new Category { id = 2, y = DataPoint.GetDataPoints(2, Sentiment.Happy).Count(), label = "Laptops" });
        //    categoryList.Add(new Category { id = 3, y = DataPoint.GetDataPoints(3, Sentiment.Happy).Count(), label = "PS4-Games" });
        //    categoryList.Add(new Category { id = 4, y = DataPoint.GetDataPoints(4, Sentiment.Happy).Count(), label = "Home Theatres" });
        //    categoryList.Add(new Category { id = 5, y = DataPoint.GetDataPoints(5, Sentiment.Happy).Count(), label = "Camera" });
        //    return categoryList;
        //}
    }
}