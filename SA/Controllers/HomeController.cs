using SA.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SA.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetDataPoints(string categoryId, string itemId)
        {
            PointType type;

            type = itemId != null ? PointType.Feature : PointType.Item;
            var cId = int.Parse(categoryId);
            var iId = itemId != null ? int.Parse(itemId) : 0;

            var data = GetDataPoints(type, cId, iId);
            var positive = data.Select(d => d).Where(d => d.sentimentValue > 0).ToList();
            var neutral = data.Select(d => d).Where(d => d.sentimentValue == 0).ToList();
            var negative = data.Select(d => d).Where(d => d.sentimentValue < 0).ToList();

            //test data
            //var positive = CreateDummyPoints(type, cId, iId, Sentiment.Happy);
            //var neutral = CreateDummyPoints(type, cId, iId, Sentiment.Neutral);
            //var negative = CreateDummyPoints(type, cId, iId, Sentiment.Sad);

            //assigning sentiment value
            var temp = new List<List<DataPoint>>();
            temp.Add(positive);
            temp.Add(neutral);
            temp.Add(negative);
            return Json(temp);
        }

        [HttpPost]
        public ActionResult GetCategories(string id)
        {
            return Json(GetCategoryList());
        }

        [HttpPost]
        public ActionResult GetReviews(string itemId, string featureId)
        {
            var iId = int.Parse(itemId);
            var fId = int.Parse(featureId);

            return Json(GetReviewList(iId, fId));
        }

        [HttpPost]
        public ActionResult GetItemScatterChart(string categoryId)
        {
            var cId = int.Parse(categoryId);
            return Json(GetScatterPoints(cId));
        }

        private List<string> GetReviewList(int itemId, int featureId)
        {

            var reviewDataSet = MySqlAccess.GetFeatureReviewList(itemId,featureId);
            var reviewList = new List<string>();
            foreach (DataRow row in reviewDataSet.Tables[0].Rows)
            {
                reviewList.Add(row.ItemArray[0] == null ? string.Empty: row.ItemArray[0].ToString());
            }

            //test data
            //var review = string.Empty;
            //for (var j = 0; j < 10; j++)
            //{
            //    for (var i = 0; i < 140; i++)
            //        review += (char)rand.Next(48, 122);
            //    reviewList.Add(review);
            //    review = string.Empty;
            //}
            return reviewList;
        }

        private List<Category> GetCategoryList()
        {
            var query = @"select category_ref_id, category_name, count(*) productCount 
                        from item 
                        join category on category_id =category_ref_id 
                        group by category_ref_id";
            var categoryDataSet = MySqlAccess.ExecuteQuery(query);

            var categoryList = new List<Category>();
            foreach (DataRow row in categoryDataSet.Tables[0].Rows)
                categoryList.Add(new Category { id = (int)row.ItemArray[0], label = row.ItemArray[1].ToString(), y = Convert.ToInt32(row.ItemArray[2].ToString()) });
 
            //Test data
            //categoryList = Category.GetCategoryList();
            return categoryList;
        }


        private List<DataPoint> GetDataPoints(PointType type, int categoryId, int itemId)
        {
            var points = new List<DataPoint>();
            var tempLabel = string.Empty;
            switch (type)
            {
                case PointType.Item:
                    var itemDataSet = MySqlAccess.GetItemListFromSP(categoryId);
                    foreach (DataRow row in itemDataSet.Tables[0].Rows)
                    {
                        points.Add(new DataPoint { label = row.ItemArray[1].ToString(), y = Convert.ToInt32(row.ItemArray[3].ToString()), id = (int)row.ItemArray[0], sentimentValue = Convert.ToInt32(row.ItemArray[2].ToString()) });
                    }
                    break;
                case PointType.Feature:
                    var featureDataSet = MySqlAccess.GetItemFeatureFromSP(itemId);
                    foreach (DataRow row in featureDataSet.Tables[0].Rows)
                    {
                        points.Add(new DataPoint { label = row.ItemArray[2].ToString(), y = Convert.ToInt32(row.ItemArray[4].ToString()), id = (int)row.ItemArray[1], sentimentValue = Convert.ToInt32(row.ItemArray[3].ToString()) });
                    }
                    break;
            }
            return points;
        }

        private List<ScatterDataPoint> GetScatterPoints(int categoryId)
        {
            //var points = ScatterDataPoint.GetScatterDataPoints(categoryId);
            var query = string.Format(@"SELECT item.item_name, review.item_ref_id, item.item_cost, (
                         newt.SumPositiveSentiment / COUNT( sentiment )
                         ) AS SentimentValue
                         FROM review
                         JOIN item ON item.item_id = review.item_ref_id
                         JOIN (
                         SELECT item_ref_id, COUNT( sentiment ) AS SumPositiveSentiment
                         FROM review
                         JOIN item ON item.item_id = item_ref_id
                         WHERE sentiment >0
                         GROUP BY item_ref_id
                         )newt ON newt.item_ref_id = review.item_ref_id
                         WHERE sentiment <>0 and item.category_ref_id = {0}
                         GROUP BY item_ref_id", categoryId);

            var dataSet = MySqlAccess.ExecuteQuery(query);
            var points = new List<ScatterDataPoint>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                points.Add(new ScatterDataPoint { label = row.ItemArray[0].ToString(), y = Convert.ToDouble(row.ItemArray[3].ToString()), x = Convert.ToDouble(row.ItemArray[2]) });
            }
            return points;
        }
        enum PointType { Category, Item, Feature}

        Random rand = new Random();
        //private List<DataPoint> CreateDummyPoints(PointType type, int categoryId, int itemId, Sentiment sentiment)
        //{
        //    var points = new List<DataPoint>();
        //    var tempLabel = string.Empty;
        //    switch (type)
        //    {
        //        case PointType.Item:
        //            points = DataPoint.GetDataPoints(categoryId, sentiment);
        //            break;
        //        case PointType.Feature:
        //            if (categoryId == 1)
        //                points.Add(new DataPoint { label = "Camera", y = rand.Next(0, 250), id = 1 });
        //            if (categoryId < 4)
        //                points.Add(new DataPoint { label = "Display", y = rand.Next(0, 250), id = 2 });
        //            if (categoryId == 1 || categoryId == 2)
        //                points.Add(new DataPoint { label = "Battery", y = rand.Next(0, 250), id = 3 });
        //            if (categoryId == 1)
        //                points.Add(new DataPoint { label = "Touch", y = rand.Next(0, 250), id = 4 });
        //            if (categoryId == 3)
        //                points.Add(new DataPoint { label = "Graphics", y = rand.Next(0, 250), id = 5 });
        //            if (categoryId < 4)
        //                points.Add(new DataPoint { label = "Speed", y = rand.Next(0, 250), id = 6 });
        //            if (categoryId < 4)
        //                points.Add(new DataPoint { label = "Sound", y = rand.Next(0, 250), id = 7 });
        //            points.Add(new DataPoint { label = "Cost", y = rand.Next(0, 250), id = 8 });
        //            if (categoryId == 5)
        //                points.Add(new DataPoint { label = "Picture Quality", y = rand.Next(0, 250), id = 9 });
        //            if (categoryId == 4)
        //                points.Add(new DataPoint { label = "Sound Quality", y = rand.Next(0, 250), id = 9 });
        //                break;
        //    }
        //    return points;
        //}
    }
}
