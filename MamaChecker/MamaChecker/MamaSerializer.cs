using System;
using System.IO;
using System.Xml.Serialization;


namespace MamaChecker
{
    public  class MamaSerializer
    {
       
        public Stream Serialize<T>(T[] items)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));

            MemoryStream stream = new MemoryStream();
            serializer.Serialize(stream, items);
            stream.Position = 0;

            return stream;
        }

    }
}