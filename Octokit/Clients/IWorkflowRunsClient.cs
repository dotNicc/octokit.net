using System.Threading.Tasks;
using Octokit.Models.Response;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's WorkflowRuns API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/actions/workflow-runs/">WorkflowRuns API documentation</a> for more information.
    /// </remarks>
    public interface IWorkflowRunsClient
    {
        /// <summary>
        /// Gets all the workflow runs for a given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/actions/workflow-runs/#list-workflow-runs-for-a-repository
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name);
    }
}
