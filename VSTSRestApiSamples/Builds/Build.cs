using System;
using System.Net.Http;
using System.Net.Http.Headers;
using VstsRestApiSamples.ViewModels.Builds;

namespace VstsRestApiSamples.Builds
{
    public class Build
    {
        readonly IConfiguration _configuration;
        readonly string _credentials;

        public Build(IConfiguration configuration)
        {
            _configuration = configuration;
            _credentials = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", _configuration.PersonalAccessToken)));
        }

        public GetListOfBuildsResponse.Definitions GetListOfBuilds(string project, int buildDefinition)
        {
            GetListOfBuildsResponse.Definitions viewModel = new GetListOfBuildsResponse.Definitions();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_configuration.UriString);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _credentials);

                HttpResponseMessage response = client.GetAsync($"/DefaultCollection/{project}/_apis/build/builds?definitions={buildDefinition}&api-version=2.0").Result;

                if (response.IsSuccessStatusCode)
                {
                    viewModel = response.Content.ReadAsAsync<GetListOfBuildsResponse.Definitions>().Result;
                }

                viewModel.HttpStatusCode = response.StatusCode;

                return viewModel;
            }
        }

    }
}
