namespace XslTransformationToHTML
{
    using System;
    using System.Xml.Xsl;

    public class StartUp
    {
        private static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../StyleSheet.xslt");
            xslt.Transform("../../../catalogue.xml", "../../catalogue.html");

            Console.WriteLine("Newly created catalogue.html by using StyleSheet.xslt is at this Console app folder(XslTransformationToHML)!");
        }
    }
}
