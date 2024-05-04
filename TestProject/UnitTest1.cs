using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using TpgrphDZ;

namespace TextTransformerTests
{
    [TestClass]
    public class Form1Tests
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
        }

        [TestMethod]
        public void TEdit()
        {
            string result = form.TEdit("ранг матрицы");
            Assert.AreEqual("рaнг мaтрицы", result);
        }

        [TestMethod]
        public void Defisy()
        {
            string result = form.Defis("1- 3 - 4 -6");
            Assert.AreEqual("1-3-4-6", result);
        }
        [TestMethod]
        public void Stepen()
        {
            string result = form.Stepen("2^2");
            Assert.AreEqual("2²", result);
        }

        [TestMethod]
        public void ExtraSpaces()
        {
            string result = form.ExtraSpaces("тут    проверим       пробелы ");
            Assert.AreEqual("тут проверим пробелы", result);
        }
        [TestMethod]
        public void LetterD()
        {
            string result = form.LetterD("я просто друг для той");
            Assert.AreEqual("я просто Друг Для той", result);
        }

        [TestMethod]
        public void PlsMin()
        {
            string result = form.PlusMinus(" +-1");
            Assert.AreEqual(" ±1", result);
        }

        [TestMethod]
        public void PlsMin2()
        {
            string result = form.PlusMinus(" +,-1");
            Assert.AreEqual(" ±1", result);
        }

        [TestMethod]
        public void Stepen2()
        {
            string result = form.Stepen("2^3");
            Assert.AreEqual("2³", result);
        }

    }
}