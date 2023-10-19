using Proxy;
namespace Testen
{
    public class ProxyTests
    {
        private IBackAccount _bankAccount;
        private string user1 = "User 1";
        [SetUp]
        public void Setup()
        {
            _bankAccount = new AccessProxy(new BankAccount(), user1);
        }

        [Test]
        public void OwnerCanCheckBalanceOwnBankAccount()
        {
            //act & assert
            Assert.DoesNotThrow(() => _bankAccount.CheckBalance(user1), "Access Denied");
        }

        [Test]
        public void UserCannotCheckBalanceOthersBankAccount()
        {
            // arrange
            string wrongUser = "Wrong user";
            // act & assert
            Assert.Throws<AccessDeniedException>(() => _bankAccount.CheckBalance(wrongUser), "Access Denied");
        }

        [Test]
        public void ProxyReturnsCorrectBalance()
        {
            // arrange
            double expected = BankAccount.DEFAULT_BALANCE;
            // act
            double actual = _bankAccount.CheckBalance(user1);
            // assert
            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}