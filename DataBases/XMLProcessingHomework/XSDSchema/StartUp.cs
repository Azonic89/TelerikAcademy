namespace XSDSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class StartUp
    {
        private static void Main()
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../catalogue.xsd");

            XDocument doc = XDocument.Load("../../../catalogue.xml");
            XDocument invalidDoc = XDocument.Load("../../invalidCatalogue.xml");

            PrintValidationResults(doc, schema, "catalogue.xml");
            PrintValidationResults(invalidDoc, schema, "invalidCatalogue.xml");
        }

        private static void PrintValidationResults(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine($"{file} * {ev.Message}");
            });
        }
    }
}
