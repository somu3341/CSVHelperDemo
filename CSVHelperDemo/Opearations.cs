using CsvHelper;
using Newtonsoft.Json;
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
        public static void ImplementCSVToJson()
        {
            List<Model> records = new List<Model>();
            string importFilePath = @"D:\BridgeLabs\CSVHelperDemo\CSVHelperDemo\CSVFile.csv";
            string exportFilePath = @"D:\BridgeLabs\CSVHelperDemo\CSVHelperDemo\JsonFile.json";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Model>().ToList();
                Console.WriteLine("Reading CSV File");
                foreach (var item in records)
                {
                    Console.WriteLine(item.name + "\n" + item.email + "\n" + item.phone + "\n" + item.country);
                }
            }
            var data = JsonConvert.SerializeObject(records);
            File.WriteAllText(exportFilePath, data);
        }
        public static void ImplementJsonToCSV()
        {
            string importFilePath = @"D:\BridgeLabs\CSVHelperDemo\CSVHelperDemo\JsonFile.json";
            string exportFilePath = @"D:\BridgeLabs\CSVHelperDemo\CSVHelperDemo\CSVFile2.csv";
            List<Model> records = JsonConvert.DeserializeObject<List<Model>>(File.ReadAllText(importFilePath));
            using (var writer = new StreamWriter(exportFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }
    }
}
