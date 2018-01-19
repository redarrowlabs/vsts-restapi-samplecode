
namespace VstsRestApiSamples
{
    public interface IConfiguration
    {        
        string PersonalAccessToken { get; set; }
        string Project { get; set; }
        string MoveToProject { get; set; }
        string UriString { get; set; }        
        string Query { get; set; }
        string Identity { get; set; }
        string WorkItemIds { get; set; }
        string WorkItemId { get; set; }
        string ProcessId { get; set; }
        string PickListId { get; set; }
        string QueryId { get; set; }
        string FilePath { get; set; }
        string GitRepositoryId { get; set; }
        string GitTargetVersionBranch { get; set; }
        string GitBaseVersionBranch { get; set; }
        int BuildDefinition { get; set; }
        int Build { get; set; }
    }
}
