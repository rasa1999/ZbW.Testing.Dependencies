using NUnit.Framework;
using ZbW.Testing.Dependencies.Lib.UnitTests.Fakes;

namespace ZbW.Testing.Dependencies.Lib.UnitTests
{
    [TestFixture]
    public class PersistanceServiceTests
    {
        private const string VALID_PATH = @"C:\temp";

        [Test]
        public void IsFileValid_InvalidFormat_CheckFailed()
        {
            // arrange
            var fileAnalyzerStub = new FileAnalyzerStub(false, true);
            var persistanceService = new PersistanceService(fileAnalyzerStub);

            // act
            var result = persistanceService.IsFileValid(VALID_PATH);

            // assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsFileValid_NotAuthorized_CheckFailed()
        {
            // arrange
            var fileAnalyzerStub = new FileAnalyzerStub(true, false);
            var persistanceService = new PersistanceService(fileAnalyzerStub);

            // act
            var result = persistanceService.IsFileValid(VALID_PATH);

            // assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsFileValid_Valid_CheckSuccess()
        {
            // arrange
            var fileAnalyzerStub = new FileAnalyzerStub(true, true);
            var persistanceService = new PersistanceService(fileAnalyzerStub);

            // act
            var result = persistanceService.IsFileValid(VALID_PATH);

            // assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsFileValid_Valid_FileAnalyzerCalled()
        {
            // arrange
            var fileAnalyzerMock = new FileAnalyzerMock();
            var persistanceService = new PersistanceService(fileAnalyzerMock);

            // act
            persistanceService.IsFileValid(VALID_PATH);

            // assert
            Assert.That(fileAnalyzerMock.CheckFormatCalled, Is.True);
            Assert.That(fileAnalyzerMock.CheckExistsCalled, Is.True);
        }
    }
}