using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <summary>
    /// Strongly-types a string as the path of a file.
    /// </summary>
    [StrongTypeMarker]
    [Obsolete("See R5T.T0252.IFilePath")]
    public interface IFilePath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}