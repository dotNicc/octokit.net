using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Octokit.Models.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowRunsResponse
    {
        public WorkflowRunsResponse() { }
        
        public WorkflowRunsResponse(int totalCount, IEnumerable<WorkflowRun> workflowRuns)
        {
            TotalCount = totalCount;
            WorkflowRuns = workflowRuns.ToList();
        }
        
        /// <summary>
        /// Number of runs retrieved
        /// </summary>
        public int TotalCount { get; protected set; }
        
        /// <summary>
        /// List of workflow runs
        /// </summary>
        public IReadOnlyList<WorkflowRun> WorkflowRuns { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, $"TotalCount: {TotalCount}");
    }
}
