namespace ConsoleApp1.Test
{
    public class Tests
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
        public void ScoreEmployee2()
        {
            //arrange
            var employee = new Employee("Przemek", "Mazur", 33);
            employee.AddScore(0);
            employee.AddScore(1);
            employee.AddScore(2);
            employee.AddScore(3);
            employee.AddScore(4);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(10, result);
        }
        [Test] 
        public void ScoreEmployee3() 
        { 
            //arrange
            var employee = new Employee("Karolina", "mazur", 30);
            employee.AddScore(0);
            employee.AddScore(2);
            employee.AddScore(4);
            employee.AddScore(6);
            employee.AddScore(8);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(20, result);
        }
        [Test]
        public void ScoreEmployee4()
        {
            //arrange
            var employee = new Employee("Roman", "D¹b", 19);
            employee.AddScore(1);
            employee.AddScore(3);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(9);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(25, result);
        }
        [Test]
        public void ScoreEmployee5() 
        {
            //arrange
            var employee = new Employee("Marcin", "Drogoœ", 43);
            employee.AddScore(-5);
            employee.AddScore(2);
            employee.AddScore(-3);
            employee.AddScore(8);
            employee.AddScore(6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual (8, result);
        }
    }
}