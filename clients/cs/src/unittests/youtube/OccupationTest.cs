using NUnit.Framework;
using Google.GData.Client.UnitTests;
using Google.GData.YouTube;

namespace Google.GData.Client.UnitTests.YouTube
{
    
    
    /// <summary>
    ///This is a test class for OccupationTest and is intended
    ///to contain all OccupationTest Unit Tests
    ///</summary>
    [TestFixture]
[Category("YouTube")]
 
    public class OccupationTest
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
        ///A test for Occupation Constructor
        ///</summary>
        [Test]
        public void OccupationConstructorTest1()
        {
            Occupation target = new Occupation();
            Assert.IsNull(target.Value,  "Object value should be null after construction");
        }

        /// <summary>
        ///A test for Occupation Constructor
        ///</summary>
        [Test]
        public void OccupationConstructorTest()
        {
            string initValue = "secret test string";
            Occupation target = new Occupation(initValue);
            Assert.AreEqual(target.Value, initValue, "Object value should be identical after construction");
        }
    }
}
