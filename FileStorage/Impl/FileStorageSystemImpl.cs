using Azure.Storage.Blobs;
using System.IO;
using System.Threading.Tasks;

namespace ExternalSystems.FileStorage
{
	public class FileStorageSystemImpl : IFileStorageSystem
	{
		private BlobContainerClient _blobContainerClient;

		private async Task<BlobContainerClient> GetBlobContainerClientAsync()
		{
			if (_blobContainerClient == null)
			{
				var connectionString = "";
				var containerName = "";

				_blobContainerClient = new BlobContainerClient(connectionString, containerName);
				await _blobContainerClient.CreateIfNotExistsAsync();
			}

			return _blobContainerClient;
		}

		private async Task<BlobClient> GetBlobClientAsync(string path)
		{
			var containerClient = await GetBlobContainerClientAsync();
			return containerClient.GetBlobClient(path.Trim());
		}

		public async Task<(string ContentType, Stream Stream)> ReadFileAsync(string path)
		{
			var blobClient = await GetBlobClientAsync(path);
			var response = await blobClient.DownloadAsync();
			return (response.Value.ContentType, response.Value.Content);
		}
	}
}
