using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <summary>
    /// Strongly-types a string as a type namespaced type name.
    /// </summary>
    [StrongTypeMarker]
    public interface INamespacedTypeName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}