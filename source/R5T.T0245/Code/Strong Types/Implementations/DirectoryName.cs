using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="IDirectoryName"/>
    [StrongTypeImplementationMarker]
    public class DirectoryName : TypedBase<string>, IStrongTypeMarker,
        IDirectoryName
    {
        public DirectoryName(string value)
            : base(value)
        {
        }
    }
}