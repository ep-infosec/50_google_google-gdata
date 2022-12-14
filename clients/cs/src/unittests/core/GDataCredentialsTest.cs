using Google.GData.Client;
using NUnit.Framework;
using Google.GData.Client.UnitTests;

    
    

using System.Net;

namespace Google.GData.Client.UnitTests.Core
{
    
    
    /// <summary>
    ///This is a test class for GDataCredentialsTest and is intended
    ///to contain all GDataCredentialsTest Unit Tests
    ///</summary>
    [TestFixture][Category("CoreClient")]
    public class GDataCredentialsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Username
        ///</summary>
        [Test]
        public void UsernameTest()
        {
            string username = "TestValue"; // TODO: Initialize to an appropriate value
            string password = "TestValue"; // TODO: Initialize to an appropriate value
            GDataCredentials target = new GDataCredentials(username, password); // TODO: Initialize to an appropriate value
            string expected = "TestValue";            
            string actual;
            target.Username = expected;
            actual = target.Username;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///A test for NetworkCredential
        ///</summary>
        [Test]
        public void NetworkCredentialTest()
        {
            string username = "TestValue"; // TODO: Initialize to an appropriate value
            string password = "TestValue"; // TODO: Initialize to an appropriate value
            GDataCredentials target = new GDataCredentials(username, password); // TODO: Initialize to an appropriate value
            ICredentials actual;
            actual = target.NetworkCredential;
            Assert.IsNotNull(actual);
        }
    }
}
