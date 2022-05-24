using Mono.Cecil;

namespace Felt.Needle.API
{
    /// <summary>
    ///     A plugin used to transform a module.
    /// </summary>
    public interface ICecilPlugin
    {
        /// <summary>
        ///     Transforms the given module.
        /// </summary>
        /// <param name="module">The module to transform.</param>
        void TransformModule(ModuleDefinition module);
    }
}