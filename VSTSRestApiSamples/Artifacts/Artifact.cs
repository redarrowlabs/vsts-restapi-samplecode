using System;
using System.Net.Http;
using System.Net.Http.Headers;
using VstsRestApiSamples.ViewModels.Artifacts;

namespace VstsRestApiSamples.Artifacts
{
    public class Artifact
    {
        readonly IConfiguration _configuration;
        readonly string _credentials;

        public Artifact(IConfiguration configuration)
        {
            _configuration = configuration;
            _credentials = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", _configuration.PersonalAccessToken)));
        }

        public GetListOfArtifactsResponse.Definitions GetListOfArtifacts(string project, int buildNumber)
        {
            GetListOfArtifactsResponse.Definitions viewModel = new GetListOfArtifactsResponse.Definitions();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_configuration.UriString);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _credentials);

                HttpResponseMessage response = client.GetAsync($"/DefaultCollection/{project}/_apis/build/builds/{buildNumber}/artifacts?api-version=2.0").Result;

                if (response.IsSuccessStatusCode)
                {
                    viewModel = response.Content.ReadAsAsync<GetListOfArtifactsResponse.Definitions>().Result;
                }

                viewModel.HttpStatusCode = response.StatusCode;

                return viewModel;
            }
        }


    }
}
