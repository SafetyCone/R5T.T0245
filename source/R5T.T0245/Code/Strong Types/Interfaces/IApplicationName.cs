using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <summary>
    /// Strongly-types a string as the name of an application.
    /// </summary>
    [StrongTypeMarker]
    public interface IApplicationName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}