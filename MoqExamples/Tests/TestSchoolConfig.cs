using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqExamples.Domain;

namespace MoqExamples.Tests
{
    [TestClass]
    public class TestSchoolConfig
    {
        [TestMethod]
        public void TestGetValue()
        {
            var mockConfig = new Mock<ISchoolConfig>();
            mockConfig.Setup(m => m.GetValue(It.Is<string>(s1 => s1 == "Config1")))
                .Returns((string v) => "First");
            mockConfig.Setup(m => m.GetValue(It.Is<string>(s2 => s2 == "Config2")))
                .Returns((string v) => "Second");

            School s = new School(mockConfig.Object);
            var result = s.GetConfigValue("Config1");
            Assert.AreEqual(result, "First");

            result = s.GetConfigValue("Config2");
            Assert.AreEqual(result, "Second");
        }
    }
}
