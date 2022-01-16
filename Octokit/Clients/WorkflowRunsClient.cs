using System.Linq;
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
    public class WorkflowRunsClient: ApiClient, IWorkflowRunsClient
    {
        public WorkflowRunsClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        /// <summary>
        /// Gets all the workflow runs for a given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/actions/workflow-runs/#list-workflow-runs-for-a-repository
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        [ManualRoute("GET", "/repos/{owner}/{repo}/actions/runs")]
        public Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAllForRepository(owner, name, ApiOptions.None);
        }
        
        /// <summary>
        /// Gets all the workflow runs for a given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/actions/workflow-runs/#list-workflow-runs-for-a-repository
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options to change the API response</param>
        [ManualRoute("GET", "/repos/{owner}/{repo}/actions/runs")]
        public async Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            var results = await ApiConnection.GetAll<WorkflowRunsResponse>(ApiUrls.WorkflowRuns(owner, name), options).ConfigureAwait(false);

            return new WorkflowRunsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.WorkflowRuns).ToList());
        }
    }
}
