using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <summary>
    /// Strongly-types a string as the name of an owned repository (a repository name that includes the name of the repository's owner).
    /// </summary>
    [StrongTypeMarker]
    public interface IOwnedRepositoryName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}