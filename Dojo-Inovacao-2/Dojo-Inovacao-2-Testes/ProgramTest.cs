using Dojo_Inovacao_2;
using NUnit.Framework;

namespace Dojo_Inovacao_2_Testes
{
    [TestFixture]
    [Category("Program")]
    public class ProgramTest
    {
        CalculoFeliz calculoFeliz;

        [SetUp]
        public void Setup()
        {
            calculoFeliz = new CalculoFeliz();
        }

        [Test]
        public void SeNumero_7_Eh_Feliz()
        {
            var resultado = calculoFeliz.NumeroEhFeliz(7);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void SeNumero_0_Eh_Infeliz()
        {
            var resultado = calculoFeliz.NumeroEhFeliz(0);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void SeNumero_1_Eh_Feliz()
        {
            var resultado = calculoFeliz.NumeroEhFeliz(1);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void SeNumero_50_Eh_Infeliz()
        {
            var resultado = calculoFeliz.NumeroEhFeliz(50);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void SeNumero_5_Eh_InFeliz()
        {
            var resultado = calculoFeliz.NumeroEhFeliz(5);
            Assert.IsFalse(resultado);
        }
    }
}
