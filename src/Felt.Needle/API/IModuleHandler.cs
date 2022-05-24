using Mono.Cecil;

namespace Felt.Needle.API
{
    /// <summary>
    ///     Handles resolving, transforming, and writing modules.
    /// </summary>
    public interface IModuleHandler
    {
        /// <summary>
        ///     Resolves modules.
        /// </summary>
        IModuleResolver ModuleResolver { get; }

        /// <summary>
        ///     Writes modules.
        /// </summary>
        IModuleWriter ModuleWriter { get; }

        /// <summary>
        ///     Transforms modules.
        /// </summary>
        IModuleTransformer ModuleTransformer { get; }

        /// <summary>
        ///     Transforms a module.
        /// </summary>
        /// <param name="module">The module to transform.</param>
        void TransformModule(ModuleDefinition module);
    }
}