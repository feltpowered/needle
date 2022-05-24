using Felt.Needle.API;
using Mono.Cecil;

namespace Felt.Needle
{
    public class StandardModuleHandler : IModuleHandler
    {
        public virtual IModuleResolver ModuleResolver { get; }

        public virtual IModuleWriter ModuleWriter { get; }

        public virtual IModuleTransformer ModuleTransformer { get; }

        public StandardModuleHandler(
            IModuleResolver moduleResolver,
            IModuleWriter moduleWriter,
            IModuleTransformer moduleTransformer
        )
        {
            ModuleResolver = moduleResolver;
            ModuleWriter = moduleWriter;
            ModuleTransformer = moduleTransformer;
        }

        public virtual void TransformModule(ModuleDefinition module) => ModuleTransformer.TransformModule(module);
    }
}