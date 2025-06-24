using System;
using System.IO;
using System.Xml.Serialization;

namespace MamaChecker
{
    public  class MamaTestRunner
    {
        public T[] Deserialize<T>(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));
            T[] result = (T[])serializer.Deserialize(stream);
            return result;
        }
    }
}