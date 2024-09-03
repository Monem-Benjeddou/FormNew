using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Globalization;
using FormNewProject.Data.Entities;

namespace FormNewProject.Data.SeedData
{
    public static class DefautsToSeed
    {
        public static List<Defaut> SeedDefaultsFromCsv(string csvFilePath)
        {
            using var reader = new StreamReader(csvFilePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null,
                Delimiter = ";"
            });
            var defaultsFromCsv = new List<Defaut>();
            while (csv.Read())
            {
                try
                {
                    var record = csv.GetRecord<Defaut>();
                    defaultsFromCsv.Add(record);
                }
                catch (TypeConverterException ex)
                {
                    // Handle the exception, for example, by logging it or skipping the invalid row
                    Console.WriteLine($"Skipping row {csv.Context.Parser.Row} due to conversion error: {ex.Message}");
                }
            }

            return defaultsFromCsv;
        }
    }
}