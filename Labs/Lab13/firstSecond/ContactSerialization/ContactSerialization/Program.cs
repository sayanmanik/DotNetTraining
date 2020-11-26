using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

//using System.Runtime.Serialization.Formatters.Soap;


namespace ContactSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            AddContacts(contacts);
            SerializeBin(contacts);
            Console.WriteLine("De serialize binary file---------->>>>>>>>>>>>");
            DeSerializeBin();
            XMLCustomSerialization(contacts);
            Console.WriteLine("De serialization xml file---------->>>>>>>>>>>>");
            XMLCustomDeSerialization();
            JSONCustomSerialization(contacts);
            Console.WriteLine("De serialization Json file----------->>>>>>>>>>");
            JSONCustomDeSerialization();
        }

        private static void AddContacts(List<Contact> contacts)
        {
            contacts.Add(new Contact(contactName: "Sayan", contactNo: 9876, cellNo:"123A"));
            contacts.Add(new Contact(contactName: "Manik", contactNo: 90045, cellNo: "789L"));
            contacts.Add(new Contact(contactName: "Piku", contactNo: 9937, cellNo: "456P"));
            contacts.Add(new Contact(contactName: "Manik", contactNo: 9876, cellNo: "321A"));
        }

        private static void SerializeBin(List<Contact> contacts)
        {
            try
            {
                using (Stream stream = File.Open("C:\\Users\\TestUser\\Desktop\\data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, contacts);

                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }


        private static void DeSerializeBin()
        {
            try
            {
                using (Stream stream = File.Open("C:\\Users\\TestUser\\Desktop\\data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var contacts = (List<Contact>)bin.Deserialize(stream);
                    foreach (Contact contact in contacts)
                    {
                        Console.WriteLine("{0}, {1}, {2}",
                            contact.ContactNo, contact.ContactName, contact.CellNo);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void XMLCustomSerialization(List<Contact> contacts)
        {
            try
            {
                 
                using(FileStream stream = new FileStream("C:\\Users\\TestUser\\Desktop\\data.xml",FileMode.OpenOrCreate,FileAccess.ReadWrite))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
                    serializer.Serialize(stream,contacts);
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void XMLCustomDeSerialization(){
            try{
                using(Stream stream = new FileStream("C:\\Users\\TestUser\\Desktop\\data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite)){

                    XmlSerializer deSerializer = new XmlSerializer(typeof(List<Contact>));

                    var contacts =(List<Contact>) deSerializer.Deserialize(stream);

                    foreach(Contact contact in contacts)
                    {
                         Console.WriteLine("{0}, {1}, {2}",
                            contact.ContactNo, contact.ContactName, contact.CellNo);
                    }
                }
            }catch(IOException e){
                Console.WriteLine(e.Message);
            }
        }

        private static void JSONCustomSerialization(List<Contact> contacts)
        {
            try
            {
            using (Stream stream = new FileStream("C:\\Users\\TestUser\\Desktop\\data.json",FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Contact>));
                serializer.WriteObject(stream, contacts);

            }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void JSONCustomDeSerialization()
        {
            using (Stream stream = new FileStream("C:\\Users\\TestUser\\Desktop\\data.json", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Contact>));
                List<Contact> contacts = (List<Contact>)serializer.ReadObject(stream);

                foreach(Contact c in contacts)
                {
                    Console.WriteLine(c.ContactNo+","+c.ContactName+","+c.CellNo);
                }

            }
        }
    }
}
