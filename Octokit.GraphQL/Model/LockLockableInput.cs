namespace Octokit.GraphQL.Model
{
    using System;
    using System.Linq;

    /// <summary>
    /// Autogenerated input type of LockLockable
    /// </summary>
    public class LockLockableInput
    {
        public string ClientMutationId { get; set; }

        public string LockableId { get; set; }

        public LockReason? LockReason { get; set; }
    }
}