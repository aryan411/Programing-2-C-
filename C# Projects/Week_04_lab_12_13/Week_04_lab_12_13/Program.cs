using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Web.Script.Serialization;

namespace Week_04_lab_12_13
{
    class Program
    {
        public static void complexDriver()
        {
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);
            Console.WriteLine($"{c0}");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine($"({c1}) + ({c2}) = {c1 + c2}");
            Console.WriteLine($"({c1}) - ({c2}) = {c1 - c2}");
            Console.WriteLine($"({c1}) * ({c2}) = {c1 * c2}");
            Console.WriteLine($"- ({c1}) = {-c1}");
            Complex c3 = c1 + c2;
            Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({ c3.Argument:f2})");
            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");
        }
        public static void atomsDriver()
        {
            List<Atom> atoms = Atom.GetAtoms();
            // Display all the items in the collection elements
            Console.WriteLine("Display all the items in the collection elements");
            foreach (var atom in atoms)
            {
                Console.WriteLine(atom.ToString());
            }

            // Serialize the first item using xml format and save to a suitable file
            Console.WriteLine("\n\nSerialize the first item using xml format and save to a suitable file");
            TextWriter writer = new StreamWriter("atomXml2.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Atom));
            serializer.Serialize(writer, atoms[0]);
            writer.Close();

            // Read the above file and display the item
            Console.WriteLine("\n\nRead the above file and display the item");
            string xmldata = File.ReadAllText("atomXml2.xml");
            Console.WriteLine(xmldata);

            // Serialize the first item using json format and save to a suitable file
            Console.WriteLine("\n\nSerialize the first item using json format and save to a suitable file");
            TextWriter writerJ = new StreamWriter("atomJson.json");
            writerJ.Write(new JavaScriptSerializer().Serialize(atoms[0]));
            writerJ.Close();

            // Read the above file and display the item
            Console.WriteLine("\n\nRead the above file and display the item");
            string jsonData = File.ReadAllText("atomJson.json");
            Console.WriteLine(jsonData);

            // Serialize the entire collection using json format and save to a suitable file
            Console.WriteLine("\n\nSerialize the entire collection using json format and save to a suitable file");
            Atom.WriteJson(atoms,"atomsListJson.json");

            // Read the above file and display all the items
            Console.WriteLine("\n\nRead the above file and display all the items");
            string jsonListData = File.ReadAllText("atomsListJson.json");
            Console.WriteLine(jsonListData);
        }
        static void Main(string[] args)
        {
            // complex class driver function
            complexDriver();

            // atom class driver function
            atomsDriver();
        }

    }
}
