using Code.Counter;
using NSubstitute;
using NUnit.Framework;

namespace Tests.EditMode
{
    public class StringProviderTests
    {
        [Test]
        public void Get_WhenCalled_ShouldReturnAString()
        {
            // Arrange
            var saverImpl = Substitute.For<ISaver>();
            saverImpl.Get(Arg.Any<string>()).Returns("Test");
            var stringSaver = new StringSaver("Billy", saverImpl);

            // Act
            stringSaver.GetString();

            // Assert
            saverImpl.Received().Get(Arg.Any<string>());
        }
    }
}
