using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="IProjectFilePath"/>
    [StrongTypeImplementationMarker]
    public class ProjectFilePath : TypedBase<string>, IStrongTypeMarker,
        IProjectFilePath
    {
        public ProjectFilePath(string value)
            : base(value)
        {
        }
    }
}