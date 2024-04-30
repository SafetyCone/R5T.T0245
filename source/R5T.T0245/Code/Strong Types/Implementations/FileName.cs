using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="IFileName"/>
    [StrongTypeImplementationMarker]
    public class FileName : TypedBase<string>, IStrongTypeMarker,
        IFileName
    {
        public FileName(string value)
            : base(value)
        {
        }
    }
}