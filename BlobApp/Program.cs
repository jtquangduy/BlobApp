using Azure.Storage.Blobs;
//using Azure.Storage.Blobs.Models;


string connectionString = "DefaultEndpointsProtocol=https;AccountName=jtappstore;AccountKey=hTeY0UshDRhr+vvDDtvnyaB3mp24zGKyas2G8s+MbCGvrIzgCRUhrrjWDKA1YYafmjk2+K5IHp1D+AStAim0Hg==;EndpointSuffix=core.windows.net";
string containerName = "scripts";
string blobName = "script.sql";
string filepath = "D:\\Study\\mysql\\script.sql";

//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

BlobContainerClient blobServiceClient = new BlobContainerClient(connectionString,containerName);

BlobClient blobClient = blobServiceClient.GetBlobClient(blobName);
await blobClient.UploadAsync(filepath, true);
Console.WriteLine("Upload the blob");

//Console.WriteLine("Creating the container");

//await blobServiceClient.CreateBlobContainerAsync(containerName,PublicAccessType.Blob);

//Console.WriteLine("Container creation complete");