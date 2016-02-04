using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SA
{
    public static class MySqlAccess
    {
        public static string ConnectingString = "Server=xxxx;Port=xxxx;Database=xxxx;Uid=xxxx;Pwd=xxxx;";

        public static DataSet ExecuteQuery(string query)
        {
            var dataSet = new DataSet();
            using (var connection = new MySqlConnection(ConnectingString))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }
        public static DataSet ExecuteStoredProcedure(string procedureName)
        {
            var dataSet = new DataSet();
            using (var connection = new MySqlConnection(ConnectingString))
            {
                connection.Open();
                var command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }

        public static DataSet GetItemListFromSP(int categoryId)
        {
            var procedureName = "sp_getItemList";
            var dataSet = new DataSet();
            using (var connection = new MySqlConnection(ConnectingString))
            {
                connection.Open();
                var command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter { ParameterName = "category_id", Value = categoryId });
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }

        public static DataSet GetItemFeatureFromSP(int itemId)
        {
            var procedureName = "sp_getFeatureList";
            var dataSet = new DataSet();
            using (var connection = new MySqlConnection(ConnectingString))
            {
                connection.Open();
                var command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter { ParameterName = "in_item_id", Value = itemId });
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }

        public static DataSet GetFeatureReviewList(int itemId, int featureId)
        {
            var dataSet = new DataSet();
            using (var connection = new MySqlConnection(ConnectingString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT `review_text` FROM `review` WHERE `item_ref_id` = "+ itemId + " AND `feature_ref_id` = "+featureId, connection);
                command.CommandType = CommandType.Text;
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }
    }
}