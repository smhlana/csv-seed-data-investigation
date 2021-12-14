using System.IO;
using System.Threading.Tasks;

namespace ExternalSystems.FileStorage
{
	public interface IFileStorageSystem
	{
		public Task<(string ContentType, Stream Stream)> ReadFileAsync(string path);
	}
}
