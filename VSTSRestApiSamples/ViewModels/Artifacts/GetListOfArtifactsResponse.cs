namespace VstsRestApiSamples.ViewModels.Artifacts
{
    public class GetListOfArtifactsResponse
    {
        public class Definitions : BaseViewModel
        {
            public int count { get; set; }
            public Value[] value { get; set; }
        }
        public class Value
        {
            public int id { get; set; }
            public string name { get; set; }
            public Resource resource { get; set; }
        }

        public class Resource
        {
            public string type { get; set; }
            public string data { get; set; }
            public Properties properties { get; set; }
            public string url { get; set; }
            public string downloadUrl { get; set; }
        }

        public class Properties
        {
            public string localpath { get; set; }
        }
    }
}
