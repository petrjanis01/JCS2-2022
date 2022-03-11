using System;

namespace JCS2.DataFiles.NetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //XmlHelper.ReadDemoXmlFile();
            //XmlHelper.WriteDemoXmlFile();

            //XmlHelper.SerializePerson();
            //XmlHelper.DeserializePerson();

            JsonHelper.SerializePerson();
            JsonHelper.DeserializePerson();

            Console.ReadKey();
        }
    }
}
