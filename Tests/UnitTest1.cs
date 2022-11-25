using Xunit.Sdk;
using Library.Models;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateAccountWithNegativeBalance()
        {
            _ = new Account() { Card = new() { Number = "654778214", Pin = "366548"}, Balance = -500};
        }
    }
}