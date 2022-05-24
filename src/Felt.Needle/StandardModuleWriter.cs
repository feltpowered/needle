using Felt.Needle.API;
using Mono.Cecil;

namespace Felt.Needle
{
    public class StandardModuleWriter : IModuleWriter
    {
        public void Write(ModuleDefinition module, string fileName) => Write(module, fileName, new WriterParameters());

        public void Write(ModuleDefinition module, string fileName, WriterParameters parameters) =>
            module.Write(fileName, parameters);

        public void Write(ModuleDefinition module) => Write(module, new WriterParameters());

        public void Write(ModuleDefinition module, WriterParameters parameters) => module.Write(parameters);

        public void Write(ModuleDefinition module, Stream stream) => Write(module, stream, new WriterParameters());

        public void Write(ModuleDefinition module, Stream stream, WriterParameters parameters) =>
            module.Write(stream, parameters);
    }
}