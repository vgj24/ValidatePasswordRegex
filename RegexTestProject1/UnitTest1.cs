using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexAssgn;
using System;

namespace RegexTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        #region to validate First Name
        [TestMethod]
        //Validating First Name
        [DataRow("Vrushali", "Vrushali")]
        [DataRow("Vru","Vru")]
       // [DataRow("v","v")]//causes exception and goes to try catch in test case and gives message
        [DataRow("v",null)]
        [DataRow("Vru01",null)]

        public void ValidateFIrstNameTestCase(string assume,string expected)
        {
            try
            {
                var actual= RegexPasswordPgm.ValidateFirstname(assume);
                Assert.AreEqual(expected, actual);
            }
            catch(RegexCustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        #endregion
        #region validate LAst NAme
        //Validating Last Name
        [DataRow("Muley","Muley")]
        [DataRow("mul","mul")]
        [DataRow("m",null)]
        [DataRow("Mul01",null)]
        public void ValidateLastNameTestCase(string assume,string expected)
        {
            try
            {
                var actual = RegexPasswordPgm.ValidateLastname(assume);
                Assert.AreEqual(expected, actual);
            }
            catch(RegexCustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        #endregion
        #region validate email id test case
        //Vlaidating Emailid/
        [TestMethod]
    [DataRow ("abc@gmail.com","abc@gmail.com")]
    [DataRow ("abc@yahoo.com", "abc@yahoo.com")]
    [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
    [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
    [DataRow("abc11@yahoo.com", "abc11@yahoo.com")]
    [DataRow("abc_100@abc.net", "abc_100@abc.net")]
    [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
    [DataRow("abc@1.com", "abc@1.com")]
    [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
    [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
   // [DataRow("abc","abc")] fials the tesst and catch exception
    public void ValidateEmailidTestCase(string assume,string expected)
        {
            try
            {
                var actual = RegexPasswordPgm.ValidateEmail(assume);
                Assert.AreEqual(expected, actual);
            }
            catch(RegexCustomException actual)
            {
                Assert.AreEqual(expected,actual.message);
            }
        }
        #endregion
        [TestMethod]
        #region validate mobile number
        [DataRow("92 9850330078","92 9850330078")]
        [DataRow("91 8723142376","91 8723142376")]
        [DataRow("91 7588850732","91 7588850732")]
        [DataRow("919842905050", null)]
        [DataRow("919842905", null)]
        [DataRow("91 984290", null)]
        [DataRow("91 984290505000000",null)]
        public void ValdateMobileNumberTestCase(string assume,string expected)
        {
            try
            {
                var actual = RegexPasswordPgm.ValidateMobileNumber(assume);
                Assert.AreEqual(expected,actual);
            }
            catch(RegexCustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        #endregion
        [TestMethod]
        #region valdate password test case
        [DataRow("Vrush@123", "Vrush@123")]
        [DataRow("Vrush#alii123", "Vrush#alii123")]
        [DataRow("Vrush@alii1S", "Vrush@alii1S")]
        [DataRow("@Vrushli129", "@Vrushli129")]
        [DataRow("Vru-shali123", "Vru-shali123")]
        [DataRow("vrushali123)@1234", null)]
        [DataRow("Vru@Sha", null)]
        [DataRow("vru123", null)]
        [DataRow("vru@123", null)]
        [DataRow("@vru#12sha", null)]
        [DataRow(")vrush12", null)]
        [DataRow(")vruSh12", null)]
        [DataRow("Vru-@", null)]
        [DataRow("VruSU@s", null)]
        public void ValidatePasswordTestCase(string assume,string expected)
        {
            try
            {
                var actual = RegexPasswordPgm.ValidatePassword(assume);
                Assert.AreEqual(expected, actual);
            }
            catch(RegexCustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        #endregion

        [TestMethod]
        public void Object_Creation_RegexPasswordPgm()
        {
            object expected = new RegexPasswordPgm();
            UsingRegistrationFactory factory = new UsingRegistrationFactory();
            Object actual = factory.CreateRegexPassword("RegexAssgn.RegexPasswordPgm", "RegexPasswordPgm");
            expected.Equals(actual);
        }
        [TestMethod]
        public void Test_Parameterised_Constructor()
        {
            object expected = new RegexPasswordPgm("Regex Progrm Message");
            UsingRegistrationFactory factory = new UsingRegistrationFactory();
            object actual =factory.CreateRegexPasswordParameterisedConstructor("RegexAssgn.RegexPasswordPgm", "RegexPasswordPgm", "Regex Progrm Message");
            expected.Equals(actual);
        }
    }
}