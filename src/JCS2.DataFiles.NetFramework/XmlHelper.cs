using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using JCS2.DataFiles.Data;

namespace JCS2.DataFiles.NetFramework
{
    public static class XmlHelper
    {
        public static void ReadDemoXmlFile()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "demo.xml");

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList nodeList = doc.GetElementsByTagName("item");
            foreach (XmlNode node in nodeList)
            {
                Console.WriteLine(node.Name);

                Console.WriteLine("Data:");
                foreach (XmlNode child in node.ChildNodes)
                {
                    Console.Write(child.Name);
                    Console.WriteLine(child.InnerText);
                }

                Console.WriteLine("Atributy: ");
                foreach (XmlAttribute att in node.Attributes)
                {
                    Console.Write(att.Name + ": ");
                    Console.WriteLine(att.InnerText);
                }
            }
        }

        public static void WriteDemoXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement item = doc.CreateElement("item");
            item.SetAttribute("att1", "some value");
            item.SetAttribute("att2", "another value");

            XmlElement number = doc.CreateElement("number");
            number.InnerText = 8876.ToString();
            item.AppendChild(number);

            XmlElement str = doc.CreateElement("str");
            str.InnerText = "Yet another string";
            item.AppendChild(str);

            doc.AppendChild(item);

            var outputPat = Path.Combine(AppContext.BaseDirectory, "out.xml");
            XmlTextWriter xmlTextWriter = new XmlTextWriter(outputPat, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            doc.WriteContentTo(xmlTextWriter);

            xmlTextWriter.Close();
        }

        public static void SerializePerson()
        {
            var person = new Person { FirstName = "Petr", LastName = "Janis", Age = 24 };

            var personPath = Path.Combine(AppContext.BaseDirectory, "person.xml");
            TextWriter tw = new StreamWriter(personPath);
            XmlSerializer sr = new XmlSerializer(typeof(Person));
            sr.Serialize(tw, person);
            tw.Close();
        }

        public static void DeserializePerson()
        {
            var personPath = Path.Combine(AppContext.BaseDirectory, "person.xml");

            FileStream f = new FileStream(personPath, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            Person item = (Person)serializer.Deserialize(f);
            Console.WriteLine(item);

            f.Close();
        }
    }
}
