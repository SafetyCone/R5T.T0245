using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="IOwnedRepositoryName"/>
    [StrongTypeImplementationMarker]
    public class OwnedRepositoryName : TypedBase<string>, IStrongTypeMarker,
        IOwnedRepositoryName
    {
        public OwnedRepositoryName(string value)
            : base(value)
        {
        }
    }
}