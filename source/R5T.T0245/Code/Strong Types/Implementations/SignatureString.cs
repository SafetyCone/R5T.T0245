using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="ISignatureString"/>
    [StrongTypeImplementationMarker]
    public class SignatureString : TypedBase<string>, IStrongTypeMarker,
        ISignatureString
    {
        public SignatureString(string value)
            : base(value)
        {
        }
    }
}