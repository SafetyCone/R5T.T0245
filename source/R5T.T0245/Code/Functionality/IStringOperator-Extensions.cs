using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using R5T.T0132;


namespace R5T.T0245.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IApplicationName"/>
        public IApplicationName ToApplicationName(string value)
        {
            var output = new ApplicationName(value);
            return output;
        }

        /// <inheritdoc cref="IApplicationName"/>
        public IEnumerable<IApplicationName> ToApplicationNames(IEnumerable<string> values)
            => values
            .Select(this.ToApplicationName)
            ;

        /// <inheritdoc cref="IDirectoryName"/>
        public IDirectoryName ToDirectoryName(string value)
        {
            var output = new DirectoryName(value);
            return output;
        }

        /// <inheritdoc cref="IDirectoryName"/>
        public IEnumerable<IDirectoryName> ToDirectoryNames(IEnumerable<string> values)
            => values
            .Select(this.ToDirectoryName)
            ;

        /// <inheritdoc cref="IDirectoryPath"/>
        public IDirectoryPath ToDirectoryPath(string value)
        {
            var output = new DirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IDirectoryPath"/>
        public IEnumerable<IDirectoryPath> ToDirectoryPaths(IEnumerable<string> values)
            => values
            .Select(this.ToDirectoryPath)
            ;

        /// <inheritdoc cref="IFileExtension"/>
        [Obsolete("See R5T.T0252.IFileExtension")]
        public IFileExtension ToFileExtension(string value)
        {
            var output = new FileExtension(value);
            return output;
        }

        /// <inheritdoc cref="IFileExtension"/>
        [Obsolete("See R5T.T0252.IFileExtension")]
        public IEnumerable<IFileExtension> ToFileExtensions(IEnumerable<string> values)
            => values
            .Select(this.ToFileExtension)
            ;

        /// <inheritdoc cref="IFileName"/>
        public IFileName ToFileName(string value)
        {
            var output = new FileName(value);
            return output;
        }

        /// <inheritdoc cref="IFileName"/>
        public IEnumerable<IFileName> ToFileNames(IEnumerable<string> values)
            => values
            .Select(this.ToFileName)
            ;

        /// <inheritdoc cref="IFilePath"/>
        [Obsolete("See R5T.T0252.IFilePath")]
        public IFilePath ToFilePath(string value)
        {
            var output = new FilePath(value);
            return output;
        }

        /// <inheritdoc cref="IFilePath"/>
        [Obsolete("See R5T.T0252.IFilePath")]
        public IEnumerable<IFilePath> ToFilePaths(IEnumerable<string> values)
            => values
            .Select(this.ToFilePath)
            ;

        /// <inheritdoc cref="IFilePath"/>
        [Obsolete("See R5T.T0252.IFilePath")]
        public async Task<IFilePath[]> ToFilePaths(Task<string[]> gettingValues)
            => (await gettingValues)
            .Select(this.ToFilePath)
            .ToArray()
            ;

        /// <inheritdoc cref="INamespacedTypeName"/>
        public INamespacedTypeName ToNamespacedTypeName(string value)
        {
            var output = new NamespacedTypeName(value);
            return output;
        }

        /// <inheritdoc cref="INamespacedTypeName"/>
        public IEnumerable<INamespacedTypeName> ToNamespacedTypeNames(IEnumerable<string> values)
            => values
            .Select(this.ToNamespacedTypeName)
            ;

        /// <inheritdoc cref="IOfficialSelectionCategoryName"/>
        public IOfficialSelectionCategoryName ToOfficialSelectionCategoryName(string value)
        {
            var output = new OfficialSelectionCategoryName(value);
            return output;
        }

        /// <inheritdoc cref="IOfficialSelectionCategoryName"/>
        public IEnumerable<IOfficialSelectionCategoryName> ToOfficialSelectionCategoryNames(IEnumerable<string> values)
            => values
            .Select(this.ToOfficialSelectionCategoryName)
            ;

        /// <inheritdoc cref="IOwnedRepositoryName"/>
        public IOwnedRepositoryName ToOwnedRepositoryName(string value)
        {
            var output = new OwnedRepositoryName(value);
            return output;
        }

        /// <inheritdoc cref="IOwnedRepositoryName"/>
        public IEnumerable<IOwnedRepositoryName> ToOwnedRepositoryNames(IEnumerable<string> values)
            => values
            .Select(this.ToOwnedRepositoryName)
            ;

        /// <inheritdoc cref="IProjectFilePath"/>
        public IProjectFilePath ToProjectFilePath(string value)
        {
            var output = new ProjectFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IProjectFilePath"/>
        public IEnumerable<IProjectFilePath> ToProjectFilePaths(IEnumerable<string> values)
            => values
            .Select(this.ToProjectFilePath)
            ;

        /// <inheritdoc cref="ISignatureString"/>
        public ISignatureString ToSignatureString(string value)
        {
            var output = new SignatureString(value);
            return output;
        }

        /// <inheritdoc cref="ISignatureString"/>
        public IEnumerable<ISignatureString> ToSignatureStrings(IEnumerable<string> values)
            => values
            .Select(this.ToSignatureString)
            ;
    }
}
