using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperDemo
{
    public class Opearations
    {
        public static void ImplementCSVHandling()
        {
            List<Model> records = new List<Model>();
            string importFilePath = @"D:\BridgeLabs\CSVHelperDemo\CSVHelperDemo\CSVFile.csv";
            string exportFilePath = @"D:\BridgeLabs\CSVHelperDemo\CSVHelperDemo\CSVFile1.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Model>().ToList();
                Console.WriteLine("Reading CSV File");
                foreach (var data in records)
                {
                    Console.WriteLine(data.name + "\n" + data.email + "\n" + data.phone + "\n" + data.country);
                }
            }
            using (var writer = new StreamWriter(exportFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }
    }
}
