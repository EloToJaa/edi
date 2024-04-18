﻿using Edi.Download;
using Edi.Generator;
using indice.Edi;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Edi;

internal class Program
{
    static void Main(string[] args)
    {
        CheckParse();
        //GenerateCode();
        //DownloadMessages();
    }

    private static void DownloadMessages()
    {
        var downloader = new Downloader();
        downloader.Download();
        //downloader.DownloadMessageSpecification("D97A", "INVOIC");
    }

    private static void CheckParse()
    {
        string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "edi");
        string filePath = Path.Combine(dirPath, "ORDERS_2024_281.c2e (1).sent");
        string fileContents = File.ReadAllText(filePath);

        var segments = fileContents.Split("'").Select(s => s.Trim());
        string unhSegment = segments.Where(s => s.StartsWith("UNH")).First();
        var elements = unhSegment.Split("+");
        string versionElement = elements[2];
        var values = versionElement.Split(":");

        string messageName = values[0];
        string versionNumber = values[1] + values[2];

        //object? interchange = InterchangeFactory.Create(messageName);
        //var interchange = default(Interchange<ORDERS>);

        var type = InterchangeFactory.CreateType(messageName);

        if (type is null) return;

        var grammar = EdiGrammar.NewEdiFact();
        using var stream = new StreamReader(filePath);

        //interchange = new EdiSerializer().Deserialize<Interchange<ORDERS>>(stream, grammar);
        object? interchange = new EdiSerializer().Deserialize(stream, grammar, type);

        string json = JsonSerializer.Serialize(interchange, new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        });

        File.WriteAllText(Path.Combine(dirPath, "out.json"), Regex.Unescape(json));
    }

    private static void GenerateCode()
    {
        var generator = new GeneratorService();

        generator.Generate();
    }
}
