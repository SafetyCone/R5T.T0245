using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.T0245.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToApplicationName(string)"/>
        public static IApplicationName ToApplicationName(this string value)
            => Instances.StringOperator_Extensions.ToApplicationName(value);

        /// <inheritdoc cref="IStringOperator.ToApplicationNames(IEnumerable{string})"/>
        public static IEnumerable<IApplicationName> ToApplicationNames(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToApplicationNames(values);

        /// <inheritdoc cref="IStringOperator.ToDirectoryName(string)"/>
        public static IDirectoryName ToDirectoryName(this string value)
            => Instances.StringOperator_Extensions.ToDirectoryName(value);

        /// <inheritdoc cref="IStringOperator.ToDirectoryNames(IEnumerable{string})"/>
        public static IEnumerable<IDirectoryName> ToDirectoryNames(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToDirectoryNames(values);

        /// <inheritdoc cref="IStringOperator.ToDirectoryPath(string)"/>
        public static IDirectoryPath ToDirectoryPath(this string value)
            => Instances.StringOperator_Extensions.ToDirectoryPath(value);

        /// <inheritdoc cref="IStringOperator.ToDirectoryPaths(IEnumerable{string})"/>
        public static IEnumerable<IDirectoryPath> ToDirectoryPaths(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToDirectoryPaths(values);

        /// <inheritdoc cref="IStringOperator.ToFileExtension(string)"/>
        [Obsolete("See R5T.T0252.IFileExtension")]
        public static IFileExtension ToFileExtension(this string value)
            => Instances.StringOperator_Extensions.ToFileExtension(value);

        /// <inheritdoc cref="IStringOperator.ToFileExtensions(IEnumerable{string})"/>
        [Obsolete("See R5T.T0252.IFileExtension")]
        public static IEnumerable<IFileExtension> ToFileExtensions(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToFileExtensions(values);

        /// <inheritdoc cref="IStringOperator.ToFileName(string)"/>
        public static IFileName ToFileName(this string value)
            => Instances.StringOperator_Extensions.ToFileName(value);

        /// <inheritdoc cref="IStringOperator.ToFileNames(IEnumerable{string})"/>
        public static IEnumerable<IFileName> ToFileNames(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToFileNames(values);

        /// <inheritdoc cref="IStringOperator.ToFilePath(string)"/>
        [Obsolete("See R5T.T0252.IFilePath")]
        public static IFilePath ToFilePath(this string value)
            => Instances.StringOperator_Extensions.ToFilePath(value);

        /// <inheritdoc cref="IStringOperator.ToFilePaths(IEnumerable{string})"/>
        [Obsolete("See R5T.T0252.IFilePath")]
        public static IEnumerable<IFilePath> ToFilePaths(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToFilePaths(values);

        /// <inheritdoc cref="IStringOperator.ToFilePaths(IEnumerable{string})"/>
        [Obsolete("See R5T.T0252.IFilePath")]
        public static Task<IFilePath[]> ToFilePaths(this Task<string[]> gettingValues)
            => Instances.StringOperator_Extensions.ToFilePaths(gettingValues);

        /// <inheritdoc cref="IStringOperator.ToNamespacedTypeName(string)"/>
        public static INamespacedTypeName ToNamespacedTypeName(this string value)
            => Instances.StringOperator_Extensions.ToNamespacedTypeName(value);

        /// <inheritdoc cref="IStringOperator.ToNamespacedTypeNames(IEnumerable{string})"/>
        public static IEnumerable<INamespacedTypeName> ToNamespacedTypeNames(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToNamespacedTypeNames(values);

        /// <inheritdoc cref="IStringOperator.ToOfficialSelectionCategoryName(string)"/>
        public static IOfficialSelectionCategoryName ToOfficialSelectionCategoryName(this string value)
            => Instances.StringOperator_Extensions.ToOfficialSelectionCategoryName(value);

        /// <inheritdoc cref="IStringOperator.ToOfficialSelectionCategoryNames(IEnumerable{string})"/>
        public static IEnumerable<IOfficialSelectionCategoryName> ToOfficialSelectionCategoryNames(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToOfficialSelectionCategoryNames(values);

        /// <inheritdoc cref="IStringOperator.ToOwnedRepositoryName(string)"/>
        public static IOwnedRepositoryName ToOwnedRepositoryName(this string value)
            => Instances.StringOperator_Extensions.ToOwnedRepositoryName(value);

        /// <inheritdoc cref="IStringOperator.ToOwnedRepositoryNames(IEnumerable{string})"/>
        public static IEnumerable<IOwnedRepositoryName> ToOwnedRepositoryNames(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToOwnedRepositoryNames(values);

        /// <inheritdoc cref="IStringOperator.ToProjectFilePath(string)"/>
        public static IProjectFilePath ToProjectFilePath(this string value)
            => Instances.StringOperator_Extensions.ToProjectFilePath(value);

        /// <inheritdoc cref="IStringOperator.ToProjectFilePaths(IEnumerable{string})"/>
        public static IEnumerable<IProjectFilePath> ToProjectFilePaths(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToProjectFilePaths(values);

        /// <inheritdoc cref="IStringOperator.ToSignatureString(string)"/>
        public static ISignatureString ToSignatureString(this string value)
            => Instances.StringOperator_Extensions.ToSignatureString(value);

        /// <inheritdoc cref="IStringOperator.ToSignatureStrings(IEnumerable{string})"/>
        public static IEnumerable<ISignatureString> ToSignatureStrings(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToSignatureStrings(values);
    }
}
