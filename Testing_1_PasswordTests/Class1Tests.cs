using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing_1_Password;

namespace PasswordTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassword_AllCriteria()
        {
            string password = "Password1!";
            int actualScore = PasswordChecker.CheckPassword(password);
            Assert.AreEqual(5, actualScore);
        }

        [TestMethod]
        public void TestPassword_NoDigits()
        {
            string password = "Password!";
            int actualScore = PasswordChecker.CheckPassword(password);
            Assert.AreEqual(5, actualScore);
        }

        [TestMethod]
        public void TestPassword_NoUppercase()
        {
            string password = "password1!";
            int actualScore = PasswordChecker.CheckPassword(password);
            Assert.AreEqual(5, actualScore);
        }

        [TestMethod]
        public void TestPassword_NoSpecialCharacters()
        {
            string password = "Password1";
            int actualScore = PasswordChecker.CheckPassword(password);
            Assert.AreEqual(3, actualScore);
        }

        [TestMethod]
        public void TestPassword_TooShort()
        {
            string password = "Pwd1!";
            int actualScore = PasswordChecker.CheckPassword(password);
            Assert.AreEqual(2, actualScore);
        }

        [TestMethod]
        public void TestPassword_NoCriteriaMet()
        {
            string password = "abc";
            int actualScore = PasswordChecker.CheckPassword(password);
            Assert.AreEqual(2, actualScore);
        }
    }
}