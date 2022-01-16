using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Octokit.Tests.Integration.Clients
{
    public class WorkflowRunsClientTests
    {
        public class TheGetAllForRepositoryMethod
        {
            [IntegrationTest]
            public async Task CanListWorkflowRuns()
            {
                var github = Helper.GetAuthenticatedClient();
                var workflowRuns = await github.Actions.WorkflowRuns.GetAllForRepository("croesusfin", "conquest-integration");

                Assert.NotEmpty(workflowRuns.WorkflowRuns);
            }
        }
    }
}
