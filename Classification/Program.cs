using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libsvm;
using DataAccess;

namespace Classification
{
    class Program
    {
        static void Main(string[] args)
        {
            // reading the data
            const string dataFilePath = @"E:\training data\testdata.manual.2009.06.14.csv";
            var dataTable = DataTable.New.ReadCsv(dataFilePath);
            var dataTablePhones = dataTable.Rows.Select(row => row).ToList(); //.Where(row => row["Tweet"].ToString().Contains("Phone")).ToList();

            List<string> x = dataTablePhones.Select(row => row["Tweet"]).ToList();
            double[] y = dataTablePhones.Select(row => double.Parse(row["Sentiment"])).ToArray();

            // creating vocabulary
            var vocabulary = x.SelectMany(GetWords).Distinct().OrderBy(word => word).ToList();

            // generating the problem
            var problemBuilder = new  TextClassificationProblemBuilder();
            var problem = problemBuilder.CreateProblem(x, y, vocabulary.ToList());

            //creating and training SVM model
            const int C = 1;
            var model = new C_SVC(problem, KernelHelper.LinearKernel(), C);

            // prediction
            string userInput;
            var _predictionDictionary = new Dictionary<int, string> { { 0, "Bad" }, { 4, "Good" }, {2, "Neutral"} };
            do
            {
                userInput = Console.ReadLine();
                var newX = TextClassificationProblemBuilder.CreateNode(userInput, vocabulary);

                var predictedY = model.Predict(newX);
                Console.WriteLine("{0}", _predictionDictionary[(int)predictedY]);
                Console.WriteLine(new string('=', 50));
            } while (userInput != "quit");

        }

        private static IEnumerable<string> GetWords(string x)
        {
            return x.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        
    }
}
