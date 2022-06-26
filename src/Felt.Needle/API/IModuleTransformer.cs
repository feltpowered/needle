using System.Collections.Generic;
using Mono.Cecil;

namespace Felt.Needle.API
{
    /// <summary>
    ///     Transforms given modules using provided plugins.
    /// </summary>
    public interface IModuleTransformer
    {
        /// <summary>
        ///     Transforms a module using the provided plugins.
        /// </summary>
        /// <param name="module">The module to transform.</param>
        void TransformModule(ModuleDefinition module);

        /// <summary>
        ///     Registers a plugin to this transformer.
        /// </summary>
        /// <param name="plugin">The plugin instance to register.</param>
        void AddPlugin(ICecilPlugin plugin);

        /// <summary>
        ///     Registers a collection of plugins to this transformer.
        /// </summary>
        /// <param name="plugins">The plugin instances to register.</param>
        void AddPlugins(IEnumerable<ICecilPlugin> plugins);

        /// <summary>
        ///     Registers an array of plugins to this transformer.
        /// </summary>
        /// <param name="plugins">The plugin instances to register.</param>
        void AddPlugins(params ICecilPlugin[] plugins);

        /// <summary>
        ///     Retrieves an enumerable collection of all plugins.
        /// </summary>
        /// <returns>An enumerable collection of every plugin registered to this transformer.</returns>
        IEnumerable<ICecilPlugin> GetPlugins();
    }
}