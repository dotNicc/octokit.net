namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Actions API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/actions/">Actions API documentation</a> for more information.
    /// </remarks>
    public interface IActionsClient
    {
        /// <summary>
        /// Client for the WorkflowRuns API
        /// </summary>
        IWorkflowRunsClient WorkflowRuns { get; }
    }
}
