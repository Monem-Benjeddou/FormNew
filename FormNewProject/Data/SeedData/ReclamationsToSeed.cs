using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using FormNewProject.Data.Entities;

namespace FormNewProject.Data.SeedData
{
    public static class ReclamationsToSeed
    {
        public static List<Reclamation> SeedReclamationsFromCsv(string csvFilePath)
        {
            using var reader = new StreamReader(csvFilePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null,
                Delimiter = ";"
            });
            csv.Context.RegisterClassMap<ReclamationMap>(); 

            return csv.GetRecords<Reclamation>().ToList();
        }
    }
}