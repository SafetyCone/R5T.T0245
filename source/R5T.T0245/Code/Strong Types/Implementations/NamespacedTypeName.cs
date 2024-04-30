using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="INamespacedTypeName"/>
    [StrongTypeImplementationMarker]
    public class NamespacedTypeName : TypedBase<string>, IStrongTypeMarker,
        INamespacedTypeName
    {
        public NamespacedTypeName(string value)
            : base(value)
        {
        }
    }
}