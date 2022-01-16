using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit.Models.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowRun
    {
        /// <summary>
        /// The Id of the workflow run
        /// </summary>
        public long Id { get; protected set; }
        
        /// <summary>
        /// Name of the workflow run
        /// </summary>
        public string Name { get; protected set; }
        
        /// <summary>
        /// The SHA of the commit the workflow run is associated with
        /// </summary>
        public string HeadSha { get; protected set; }
        
        /// <summary>
        /// The workflow run status
        /// </summary>
        public StringEnum<CheckStatus> Status { get; protected set; }
        
        /// <summary>
        /// The final conclusion of the run
        /// </summary>
        public StringEnum<CheckConclusion> Conclusion { get; protected set; }
        
        /// <summary>
        /// Id of the workflow this run is associated with
        /// </summary>
        public long WorkflowId { get; protected set; }
        
        /// <summary>
        /// Id of the check suite this run is associated with
        /// </summary>
        public long CheckSuiteId { get; protected set; }
        
        /// <summary>
        /// The time the run was created
        /// </summary>
        public DateTimeOffset CreatedAt { get; protected set; }
        
        /// <summary>
        /// The last time the run was updated
        /// </summary>
        public DateTimeOffset UpdatedAt { get; protected set; }
        
        /// <summary>
        /// Which workflow run attempt is this run
        /// </summary>
        public int RunAttempt { get; protected set; }
        
        /// <summary>
        /// Time at which the run was started
        /// </summary>
        public DateTimeOffset RunStartedAt { get; protected set; }
        
        /// <summary>
        /// The commit this workflow run is associated with
        /// </summary>
        public Commit HeadCommit { get; protected set; }

        public WorkflowRun() { }
        
        public WorkflowRun(long id, string name, string headSha, CheckStatus status, CheckConclusion conclusion, long workflowId, long checkSuiteId, DateTimeOffset createdAt, DateTimeOffset updatedAt, int runAttempt, DateTimeOffset runStartedAt, Commit headCommit, Repository repository, Repository headRepository)
        {
            Id = id;
            Name = name;
            HeadSha = headSha;
            Status = status;
            Conclusion = conclusion;
            WorkflowId = workflowId;
            CheckSuiteId = checkSuiteId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            RunAttempt = runAttempt;
            RunStartedAt = runStartedAt;
            HeadCommit = headCommit;
        }
        
        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, $"Name: {Name}, Status: {Status}, Conclusion: {Conclusion}");
    }
}
