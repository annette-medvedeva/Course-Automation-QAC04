using ConsoleApp;
using System.Threading.Tasks;

namespace TestProjectNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] inputNumbers = { 11, -21, 64, 59, 11, 0, -7, 53, -31, 1 };
            int[] expectedOutput = { 11,11, 53, 59, 64 };

            var result = Task1.SelectNumberPositive(inputNumbers).ToArray();
            Assert.AreEqual(expectedOutput.Length, result.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }

        [Test]
        public void Test2()
        {
            int[] inputNumbers = { 11, 23, 60, 57, 62, 17, 42, 34, 123 };
            int[] expectedOutput = { 60, 62, 42, 34 };
            var result = Task2.EvenNumbers(inputNumbers).ToArray();

            Assert.AreEqual(expectedOutput.Length, result.Length);
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }

        [Test]
        public void Test3()
        {
            string input = "automation";
            string expectedOutput = "noitamotua";
            string result = Task3.Revers(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test4()
        {
            List<string> inputNames = new List<string> { "Alexa", "Kirill", "Jonas", "Alina", "Andrey", "Danila", "Nick", "Amer", "Chastity", "Khristina", "Amelia" };
            List<string> expectedOutput = new List<string> { "Ilexa", "Ilina", "Indrey", "Imer", "Imelia" };
            var result = Task4.ModifyNames(inputNames);
            Assert.AreEqual(expectedOutput.Count, result.Count);
            for (int i = 0; i < expectedOutput.Count; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }

        [Test]
        public void Test5()
        {
            List<string> firstNames = new List<string> { "Igor", "Vasya", "Alex" };
            List<string> secondNames = new List<string> { "Nikita", "Yura", "Sergey" };
            List<string> expectedOutput = new List<string> { "Sergey", "Alex", "Igor" };

            var result = Task5.FilterAndReverseNames(firstNames, secondNames).ToList();
            Assert.AreEqual(expectedOutput.Count, result.Count);
            for (int i = 0; i < expectedOutput.Count; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }

        
    }
}