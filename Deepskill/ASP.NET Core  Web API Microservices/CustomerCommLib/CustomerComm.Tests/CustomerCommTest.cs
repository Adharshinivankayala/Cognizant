using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTest
    {
        private Mock<IMailSender> mockMailSender;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();

            mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);
        }

        [TestCase]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            CustomerCommLib.CustomerComm customerComm =
                new CustomerCommLib.CustomerComm(mockMailSender.Object);

            bool result = customerComm.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
}