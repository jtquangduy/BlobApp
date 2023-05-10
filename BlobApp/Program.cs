using Azure.Storage.Blobs;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=jtappstore;AccountKey=hTeY0UshDRhr+vvDDtvnyaB3mp24zGKyas2G8s+MbCGvrIzgCRUhrrjWDKA1YYafmjk2+K5IHp1D+AStAim0Hg==;EndpointSuffix=core.windows.net";
string containerName = "scripts";

BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

Console.WriteLine("Creating the container");

await blobServiceClient.CreateBlobContainerAsync(containerName);

Console.WriteLine("Container creation complete");