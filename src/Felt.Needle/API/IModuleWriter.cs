using System.IO;
using Mono.Cecil;

namespace Felt.Needle.API
{
	/// <summary>
	///     Writes modified module definitions to streams and files/
	/// </summary>
	public interface IModuleWriter
	{
		/// <summary>
		///		Writes a module to the specified file.
		/// </summary>
		/// <param name="module">The module to write.</param>
		/// <param name="fileName">The file to write to.</param>
		void Write(ModuleDefinition module, string fileName);

		///  <summary>
		/// 		Writes a module to the specified file.
		///  </summary>
		///  <param name="module">The module to write.</param>
		///  <param name="fileName">The file to write to.</param>
		///  <param name="parameters">The writer parameters.</param>
		void Write(ModuleDefinition module, string fileName, WriterParameters parameters);

		/// <summary>
		///		Writes a module to the module's image.
		/// </summary>
		/// <param name="module">The module to write.</param>
		void Write(ModuleDefinition module);

		///  <summary>
		/// 		Writes a module to the module's image.
		///  </summary>
		///  <param name="module">The module to write.</param>
		///  <param name="parameters">The writer parameters.</param>
		void Write(ModuleDefinition module, WriterParameters parameters);

		///  <summary>
		/// 		Writes a module to the stream.
		///  </summary>
		///  <param name="module">The module to write.</param>
		///  <param name="stream">The stream to write to.</param>
		void Write(ModuleDefinition module, Stream stream);

		///  <summary>
		/// 		Writes a module to the stream.
		///  </summary>
		///  <param name="module">The module to write.</param>
		///  <param name="stream">The stream to write to.</param>
		///  <param name="parameters">The writer parameters.</param>
		void Write(ModuleDefinition module, Stream stream, WriterParameters parameters);
	}
}