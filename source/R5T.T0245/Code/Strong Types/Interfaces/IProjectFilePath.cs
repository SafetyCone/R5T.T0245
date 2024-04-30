using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0245
{
    /// <summary>
    /// Strongly-types a string as a project file path.
    /// <para>
    /// Note that this is leaf strong type, and does not make any assumption about being a Visual Studio project file path,
    /// not does it inherit from any strong type implying that the path is rooted.
    /// It's just a project file path for when you need a project file path.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectFilePath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}