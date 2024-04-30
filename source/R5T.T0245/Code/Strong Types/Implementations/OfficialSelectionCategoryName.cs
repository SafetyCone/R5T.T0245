using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <inheritdoc cref="IOfficialSelectionCategoryName"/>
    [StrongTypeImplementationMarker]
    public class OfficialSelectionCategoryName : TypedBase<string>, IStrongTypeMarker,
        IOfficialSelectionCategoryName
    {
        public OfficialSelectionCategoryName(string value)
            : base(value)
        {
        }
    }
}