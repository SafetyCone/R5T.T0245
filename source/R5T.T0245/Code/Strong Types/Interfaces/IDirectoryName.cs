using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <summary>
    /// Strongly-types a string as the name of a directory.
    /// This is the official leaf strong-type for directory names.
    /// </summary>
    [StrongTypeMarker]
    public interface IDirectoryName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}