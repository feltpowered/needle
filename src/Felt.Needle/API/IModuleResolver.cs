using Mono.Cecil;

namespace Felt.Needle.API
{
    /// <summary>
    ///     Resolves and creates module definitions.
    /// </summary>
    public interface IModuleResolver
    {
        /// <summary>
        ///     Resolves a module definition from the path with default reader parameters.
        /// </summary>
        /// <param name="path">The path to read from.</param>
        /// <returns>The resolved module definition.</returns>
        ModuleDefinition? ResolveFromPath(string path);

        /// <summary>
        ///     Resolves a module definition from the path with default reader parameters.
        /// </summary>
        /// <param name="path">The path to read from.</param>
        /// <param name="parameters">The reader parameters.</param>
        /// <returns>The resolved module definition.</returns>
        ModuleDefinition? ResolveFromPath(string path, ReaderParameters parameters);

        /// <summary>
        ///     Resolves a module definition from the stream with default reader parameters.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        /// <returns>The resolved module definition.</returns>
        ModuleDefinition? ResolveFromStream(Stream stream);

        /// <summary>
        ///     Resolves a module definition from the stream with default reader parameters.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        /// <param name="parameters">The reader parameters.</param>
        /// <returns>The resolved module definition.</returns>
        ModuleDefinition? ResolveFromStream(Stream stream, ReaderParameters parameters);

        /// <summary>
        ///     Resolves a module definition from the path with default reader parameters.
        /// </summary>
        /// <param name="name">The module definition's name.</param>
        /// <param name="kind">The module definition type.</param>
        /// <returns>The created module definition.</returns>
        ModuleDefinition CreateModule(string name, ModuleKind kind);

        /// <summary>
        ///     Resolves a module definition from the path with default reader parameters.
        /// </summary>
        /// <param name="name">The module definition's name.</param>
        /// <param name="parameters">The module definition's parameters.</param>
        /// <returns>The created module definition.</returns>
        ModuleDefinition CreateModule(string name, ModuleParameters parameters);
    }
}