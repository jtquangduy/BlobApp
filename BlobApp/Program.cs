using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=jtappstore;AccountKey=hTeY0UshDRhr+vvDDtvnyaB3mp24zGKyas2G8s+MbCGvrIzgCRUhrrjWDKA1YYafmjk2+K5IHp1D+AStAim0Hg==;EndpointSuffix=core.windows.net";
string containerName = "data";

BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);

await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync())
{
    Console.WriteLine("The Blob Name is {0}", blobItem.Name);
    Console.WriteLine("The Blob Size is {0}", blobItem.Properties.ContentLength);
}