using Microsoft.VisualStudio.TestTools.UnitTesting;
using VstsRestApiSamples.BuildDefinitions;
using System.Net;

namespace VstsRestApiSamples.Tests.BuildDefinitions
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
        public void BuildDefintions_GetListOfBuildDefinitions_Success()
        {
            // arrange
            BuildDefinition request = new BuildDefinition(_configuration);

            // act
            var response = request.GetListOfBuildDefinitions(_configuration.Project);

            // assert
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);

            request = null;
        }
    }
}
