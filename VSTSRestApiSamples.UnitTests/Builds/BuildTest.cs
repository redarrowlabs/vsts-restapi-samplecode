using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VstsRestApiSamples.Builds;

namespace VstsRestApiSamples.Tests.Builds
{
    [TestClass]
    public class BuildTest
    {
        private IConfiguration _configuration = new Configuration();

        [TestInitialize]
        public void TestInitialize()
        {
            InitHelper.GetConfiguration(_configuration);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _configuration = null;
        }

        [TestMethod, TestCategory("REST API")]
        public void Build_GetListOfBuilds_Success()
        {
            // arrange
            Build request = new Build(_configuration);

            // act
            var response = request.GetListOfBuilds(_configuration.Project, _configuration.BuildDefinition);

            // assert
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);

            request = null;
        }
    }
}
