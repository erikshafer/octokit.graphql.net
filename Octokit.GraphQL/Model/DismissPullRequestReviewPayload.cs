namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of DismissPullRequestReview
    /// </summary>
    public class DismissPullRequestReviewPayload : QueryableValue<DismissPullRequestReviewPayload>
    {
        internal DismissPullRequestReviewPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The dismissed pull request review.
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `pullRequestReview` will change from `PullRequestReview!` to `PullRequestReview`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public PullRequestReview PullRequestReview => this.CreateProperty(x => x.PullRequestReview, Octokit.GraphQL.Model.PullRequestReview.Create);

        internal static DismissPullRequestReviewPayload Create(Expression expression)
        {
            return new DismissPullRequestReviewPayload(expression);
        }
    }
}