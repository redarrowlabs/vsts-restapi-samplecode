using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VstsRestApiSamples.Artifacts;

namespace VstsRestApiSamples.Tests.Artifacts
{
    [TestClass]
    public class ArtifactTest
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
        public void Artifact_GetListOfArtifacts_Success()
        {
            // arrange
            Artifact request = new Artifact(_configuration);

            // act
            var response = request.GetListOfArtifacts(_configuration.Project, _configuration.Build);

            // assert
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);

            request = null;
        }
    }
}
