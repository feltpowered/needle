using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Felt.Needle.API;
using Mono.Cecil;
using NUnit.Framework;
using TypeAttributes = Mono.Cecil.TypeAttributes;

namespace Felt.Needle.Tests
{
    public static class ModuleLoadTest
    {
        [Test]
        public static void LoadSingleModuleTest()
        {
            LoadDummyModule(out IModuleHandler handler, out ModuleDefinition? module);

            if (module is null)
                throw new Exception("DummyProject.dll could not be loaded.");

            if (module.Types.Single(x => x.Name == "DummyClass") is null)
                throw new Exception("DummyClass not found in module.");
        }

        [Test]
        public static void ManipulateSingleModuleTest()
        {
            LoadDummyModule(out IModuleHandler handler, out ModuleDefinition? module);

            if (module is null)
                throw new Exception("DummyProject.dll could not be loaded.");

            module.Types.Add(new TypeDefinition(
                "DummyProject",
                "MyNewDummyClass",
                TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.Class,
                module.ImportReference(typeof(object))
            ));

            using MemoryStream stream = new();
            handler.ModuleWriter.Write(module, stream);
            module = handler.ModuleResolver.ResolveFromStream(stream);

            if (module is null)
                throw new Exception("Could not load new module from memory!");

            if (module.Types.Single(x => x.Namespace == "DummyProject" && x.Name == "MyNewDummyClass") is null)
                throw new Exception("Could not resolve type \"DummyProject.MyNewDummyClass\".");

            Assembly assembly = Assembly.Load(stream.ToArray());

            if (assembly.GetType("DummyProject.MyNewDummyClass") is null)
                throw new Exception("Could not resolve type \"DummyProject.MyNewDummyClass\" from loaded assembly!");
        }

        private static void LoadDummyModule(out IModuleHandler handler, out ModuleDefinition? module)
        {
            handler = new StandardModuleHandler(
                new StandardModuleResolver(),
                new StandardModuleWriter(),
                new StandardModuleTransformer()
            );
            
            module = handler.ModuleResolver.ResolveFromPath("DummyProject.dll");
        }
    }
}