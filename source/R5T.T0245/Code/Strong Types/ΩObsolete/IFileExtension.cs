using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <summary>
    /// Strongly-types a string as a file-extension.
    /// </summary>
    [StrongTypeMarker]
    [Obsolete("See R5T.T0252.IFileExtension")]
    public interface IFileExtension : IStrongTypeMarker,
        ITyped<string>
    {
    }
}