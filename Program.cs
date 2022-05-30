using Challenge16JsonSerializer.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Challenge16JsonSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var membersToJson = new Members()
            {
                name = "Bruce Wayne",
                age = 37,
                secretIdentity = "Batman",
                powers = new List<string>() {"Intelligence","Batarang" },
            };
            string jsonString = JsonSerializer.Serialize(membersToJson);
            Console.WriteLine(jsonString);
            var squadTojson = new SquadTeam()
            {
                squadName = "Liga de la Justicia",
                homeTown = "New York",
                formed = 5,
                secretBase = "base lunar atalaya",
                active = false,
                members = new List<Members>(),
            };
            squadTojson.members.Add(membersToJson);
            string squadConvertJson = JsonSerializer.Serialize(squadTojson);
            Console.WriteLine(squadConvertJson);
        }
    }
}
