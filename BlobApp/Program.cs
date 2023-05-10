using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=jtappstore;AccountKey=hTeY0UshDRhr+vvDDtvnyaB3mp24zGKyas2G8s+MbCGvrIzgCRUhrrjWDKA1YYafmjk2+K5IHp1D+AStAim0Hg==;EndpointSuffix=core.windows.net";
string containerName = "data";

await GetMetaData();

async Task SetBlobMetaData()
{
    string blobName = "script.sql";

    BlobClient blobClient = new BlobClient(connectionString,containerName, blobName);

    IDictionary<string,string> metaData = new Dictionary<string,string>();
    metaData.Add("Department", "Logistics");
    metaData.Add("Application", "AppA");

    await blobClient.SetMetadataAsync(metaData);

    Console.WriteLine("Metadata added");
}

async Task GetMetaData()
{
    string blobName = "script.sql";
    BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);
    BlobProperties blobProperties = await blobClient.GetPropertiesAsync();
    foreach (var metaData in blobProperties.Metadata)
    {
        Console.WriteLine("The key is {0}", metaData.Key);
        Console.WriteLine("The value is {0}", metaData.Value);
    }
}