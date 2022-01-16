namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Actions API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/actions/">Actions API documentation</a> for more information.
    /// </remarks>
    public class ActionsClient: ApiClient, IActionsClient
    {
        /// <summary>
        /// Client for the WorkflowRuns API
        /// </summary>
        public IWorkflowRunsClient WorkflowRuns { get; }
        
        /// <summary>
        /// Instantiate a new GitHub Actions API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public ActionsClient(IApiConnection apiConnection) : base(apiConnection)
        {
            WorkflowRuns = new WorkflowRunsClient(apiConnection);
        }
    }
}
