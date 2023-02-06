using NUnit.Framework;

namespace ZbW.Testing.Dependencies.Lib.Test
{
    [TestFixture]
    public class FileNameGeneratorTest
    {
        [Test]
        public void Generate_GenerateString_ReturnRaphael19990314000000dotpdf()
        {
            var stub = new DateTimeGeneratorStub(1999, 3, 14, 0, 0, 0);
            var sut = new FileNameGenerator(stub);

            var expected = sut.ReturnFileName("Raphael", "pdf");

            Assert.That(expected, Is.EqualTo("Raphael19990314000000.pdf"));
        }
    }
}
