using Felt.Needle.API;
using Mono.Cecil;

namespace Felt.Needle
{
    public class StandardModuleTransformer : IModuleTransformer
    {
        protected readonly List<ICecilPlugin> Plugins = new();

        public virtual void TransformModule(ModuleDefinition module)
        {
            foreach (ICecilPlugin plugin in Plugins)
                plugin.TransformModule(module);
        }

        public virtual void AddPlugin(ICecilPlugin plugin) => Plugins.Add(plugin);

        public virtual void AddPlugins(IEnumerable<ICecilPlugin> plugins) => Plugins.AddRange(plugins);

        public virtual void AddPlugins(params ICecilPlugin[] plugins) =>
            AddPlugins((IEnumerable<ICecilPlugin>) plugins);

        public virtual IEnumerable<ICecilPlugin> GetPlugins() => Plugins;
    }
}