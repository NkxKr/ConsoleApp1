using ConsoleApp1;

namespace ConsoleApp1Tests
{
    internal class TypeTests
    {
        [Test]
        public void TEST1()
        {
            //arrange
            var employee1 = GetEmployee("Kamil");
            var employee2 = GetEmployee("Michał");

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
        [Test]
        public void TEST2()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;
            int number3 = 2;
            //assert
            Assert.AreEqual(number1, number2);
            Assert.AreNotEqual(number1, number3);
        }
    }
}
