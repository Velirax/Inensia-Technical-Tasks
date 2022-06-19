using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"..\..\..\input.txt";
            var people = new List<Person>();

            var serializer = new JsonSerializer();
            using (var re = File.OpenText(filename))
            using (var reader = new JsonTextReader(re))
            {
                var entries = serializer.Deserialize<Person[]>(reader);
                people = entries
                    .Select(x => x)
                    .ToList();
            }
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine();
        }
    }
}
