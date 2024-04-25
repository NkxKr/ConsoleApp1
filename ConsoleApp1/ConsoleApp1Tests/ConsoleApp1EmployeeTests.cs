using ConsoleApp1;

namespace ConsoleApp1Tests
{
    public class ConsoleApp1EmployeeTests
    {
        [Test]
        public void ScoreEmployee1()
        {
            //arrange
            var employee = new Employee("Nikodem", "Krawiec", 21);
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);
            employee.AddScore(7);
            employee.AddScore(6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(40, result);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}