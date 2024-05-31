using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="IFilePath"/>
    [StrongTypeImplementationMarker]
    [Obsolete("See R5T.T0252.IFilePath")]
    public class FilePath : TypedBase<string>, IStrongTypeMarker,
        IFilePath
    {
        public FilePath(string value)
            : base(value)
        {
        }
    }
}