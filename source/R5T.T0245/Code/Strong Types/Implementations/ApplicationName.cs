using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="IApplicationName"/>
    [StrongTypeImplementationMarker]
    public class ApplicationName : TypedBase<string>, IStrongTypeMarker,
        IApplicationName
    {
        public ApplicationName(string value)
            : base(value)
        {
        }
    }
}