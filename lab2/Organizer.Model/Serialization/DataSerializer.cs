using KPZ_Lab2.Models;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace KPZ_Lab2.Serialization
{
    public static class DataSerializer
    {
        private static DataContractSerializer serializer = new(typeof(DataModel));

        public static void SerializeData(string fileName, DataModel data)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                using (XmlDictionaryWriter writer = XmlDictionaryWriter.CreateBinaryWriter(fileStream))
                {
                    serializer.WriteObject(writer, data);
                }
            }
        }

        public static DataModel DeserializeData(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                using (XmlDictionaryReader reader = XmlDictionaryReader.CreateBinaryReader(fileStream, XmlDictionaryReaderQuotas.Max))
                {
                    return (DataModel)serializer.ReadObject(reader);
                }
            }
        }
    }
}