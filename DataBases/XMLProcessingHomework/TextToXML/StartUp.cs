namespace TextToXML
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    using Utilities;

    public class StartUp
    {
        private static void Main()
        {
            var person = new Person();

            using (var reader = new StreamReader("../../person.txt"))
            {
                person.Name = reader.ReadLine();
                person.Address = reader.ReadLine();
                person.Phone = reader.ReadLine();
            }

            var personXmlElement = new XElement("person", 
                new XElement("name", person.Name),
                new XElement("address", person.Address),
                new XElement("phone", person.Phone));

            personXmlElement.Save("../../person.xml");

            Console.WriteLine("Produced person from txt to xml is at this Console App foder(TextToXML) names as person.xml!");
        }
    }
}
