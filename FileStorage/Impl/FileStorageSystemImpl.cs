//using Azure.Storage.Blobs;
//using Azure.Storage.Blobs.Models;
//using Common.Models;
//using Common.Utilities;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;

namespace ExternalSystems.FileStorage.Impl
{
	[ExcludeFromCodeCoverage]
	// We cannot UNIT TEST the LIVE system but through the InMemory_XXX_Impl we do test HOW we use it
	public class FileStorageSystemImpl : IFileStorageSystem
	{
		//private BlobContainerClient _blobContainerClient;

		//private async Task<BlobContainerClient> GetBlobContainerClientAsync()
		//{
		//	if (_blobContainerClient == null)
		//	{
		//		_blobContainerClient = new BlobContainerClient(_appSettings.FileStorage_ConnectionString, _appSettings.AppName);
		//		await _blobContainerClient.CreateIfNotExistsAsync();
		//	}

		//	return _blobContainerClient;
		//}

		//private async Task<BlobClient> GetBlobClientAsync(string path)
		//{
		//	Validate.IfNullOrWhitespace(path).Throw(path, path => new ArgumentNullException(nameof(path)));

		//	var containerClient = await GetBlobContainerClientAsync();
		//	return containerClient.GetBlobClient(path.Trim());
		//}

		//public async Task WriteFileAsync(string path, string contentType, Stream stream)
		//{
		//	Validate.IfNullOrWhitespace(path).Throw(path, path => new ArgumentNullException(nameof(path)));
		//	Validate.IfNullOrWhitespace(contentType).Throw(contentType, contentType => new ArgumentNullException(nameof(contentType)));
		//	Validate.IfNullOrWhitespace(stream).Throw(stream, stream => new ArgumentNullException(nameof(stream)));

		//	stream.Reset();
		//	path = path.Trim();
		//	contentType = contentType.Trim();

		//	var blobClient = await GetBlobClientAsync(path);

		//	await blobClient.UploadAsync(stream, true);
		//	await blobClient.SetHttpHeadersAsync(new BlobHttpHeaders { ContentType = contentType });

		//	stream.Reset();
		//}

		//public async Task<(string ContentType, Stream Stream)> ReadFileAsync(string path)
		//{
		//	Validate.IfNullOrWhitespace(path).Throw(path, path => new ArgumentNullException(nameof(path)));

		//	var blobClient = await GetBlobClientAsync(path);
		//	var response = await blobClient.DownloadAsync();
		//	return (response.Value.ContentType, response.Value.Content);
		//}

		//public async Task DeleteFileAsync(string path)
		//{
		//	Validate.IfNullOrWhitespace(path).Throw(path, path => new ArgumentNullException(nameof(path)));

		//	var blobClient = await GetBlobClientAsync(path);
		//	await blobClient.DeleteIfExistsAsync();
		//}

		//public async Task<bool> FileExistsAsync(string path)
		//{
		//	Validate.IfNullOrWhitespace(path).Throw(path, path => new ArgumentNullException(nameof(path)));

		//	var blobClient = await GetBlobClientAsync(path);
		//	return await blobClient.ExistsAsync();
		//}
	}
}
