using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDDPractica;
namespace TDDPracticaTest
{
    [TestFixture]
   public class DivisoresTest
    {

        private Divisores divisores { get; set; }
        
        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            divisores = new Divisores();
        }

        [Test]
        public void Test_Numero_1()
        {
            var resp = divisores.Score(1);

            Assert.AreEqual("1", resp);
        }
        [Test]
        public void Test_Numero_2()
        {
            var resp = divisores.Score(2);

            Assert.AreEqual("2", resp);
        }

        [Test]
        public void Test_Numero_3()
        {
            var resp = divisores.Score(3);

            Assert.AreEqual("Fizz", resp);
        }

        [Test]
        public void Test_Numero_5()
        {
            var resp = divisores.Score(5);

            Assert.AreEqual("Buzz", resp);
        }
        [Test]
        public void Test_Numero_6()
        {
            var resp = divisores.Score(6);

            Assert.AreEqual("Fizz", resp);
        }
        [Test]
        public void Test_Numero_9()
        {
            var resp = divisores.Score(9);

            Assert.AreEqual("Fizz", resp);
        }
        [Test]
        public void Test_Numero_12()
        {
            var resp = divisores.Score(12);

            Assert.AreEqual("Fizz", resp);
        }
        [Test]
        public void Test_Numero_10()
        {
            var resp = divisores.Score(10);

            Assert.AreEqual("Buzz", resp);
        }
        [Test]
        public void Test_Numero_20()
        {
            var resp = divisores.Score(20);

            Assert.AreEqual("Buzz", resp);
        }
        [Test]
        public void Test_Numero_25()
        {
            var resp = divisores.Score(25);

            Assert.AreEqual("Buzz", resp);
        }

        [Test]
        public void Test_numero_15()
        {
            var resp = divisores.Score(15);

            Assert.AreEqual("FizzBuzz", resp);
        }
        [Test]
        public void Test_numero_30()
        {
            var resp = divisores.Score(30);

            Assert.AreEqual("FizzBuzz", resp);
        }
        [Test]
        public void Test_numero_45()
        {
            var resp = divisores.Score(45);

            Assert.AreEqual("FizzBuzz", resp);
        }


    }
}
 
