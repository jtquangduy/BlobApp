using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=jtappstore;AccountKey=hTeY0UshDRhr+vvDDtvnyaB3mp24zGKyas2G8s+MbCGvrIzgCRUhrrjWDKA1YYafmjk2+K5IHp1D+AStAim0Hg==;EndpointSuffix=core.windows.net";
string containerName = "data";
string blobName = "script.sql";
string filePath = "D:\\Study\\script.sql";

BlobClient blobClient =new BlobClient(connectionString, containerName,blobName);

await blobClient.DownloadToAsync(filePath);

Console.WriteLine("The blob is downloaded");