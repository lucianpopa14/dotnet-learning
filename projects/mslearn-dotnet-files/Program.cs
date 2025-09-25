using Newtonsoft.Json;

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalsDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalsDir);

var salesFiles = FindFiles(storesDirectory);

var salesTotal = CalculateSalesTotals(salesFiles);

File.AppendAllText(Path.Combine(salesTotalsDir, "totals.txt"), salesTotal.ToString() + "\n");

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);

        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }
    return salesFiles;
}
double CalculateSalesTotals(IEnumerable<string> salesFiles)
{
    double total = 0;
    foreach (var file in salesFiles)
    {
        string salesJson = File.ReadAllText(file);
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);
        total += data?.Total ?? 0;
    }

    return total;
}

record SalesData(double Total);