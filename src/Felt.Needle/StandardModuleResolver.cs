using System.IO;
using Felt.Needle.API;
using Mono.Cecil;

namespace Felt.Needle
{
    public class StandardModuleResolver : IModuleResolver
    {
        public virtual ModuleDefinition? ResolveFromPath(string path) =>
            ResolveFromPath(path, new ReaderParameters(ReadingMode.Deferred));

        public virtual ModuleDefinition? ResolveFromPath(string path, ReaderParameters parameters) =>
            ModuleDefinition.ReadModule(path, parameters);

        public virtual ModuleDefinition? ResolveFromStream(Stream stream) =>
            ResolveFromStream(stream, new ReaderParameters(ReadingMode.Deferred));

        public virtual ModuleDefinition? ResolveFromStream(Stream stream, ReaderParameters parameters) =>
            ModuleDefinition.ReadModule(stream, parameters);

        public virtual ModuleDefinition CreateModule(string name, ModuleKind kind) =>
            CreateModule(name, new ModuleParameters {Kind = kind});

        public virtual ModuleDefinition CreateModule(string name, ModuleParameters parameters) =>
            ModuleDefinition.CreateModule(name, parameters);
    }
}