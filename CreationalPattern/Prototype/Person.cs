using System.Xml.Serialization;

namespace DesignPattern.CreationalPattern.Prototype
{
    [Serializable]
    public class Person: ICloneable
    {
    public string Name { get; set; }
    public Address Address { get; set; }
 
    public override string ToString()
    {
        var newLine = Environment.NewLine;
        var indent = "\t";
        var str = $"Name:{Name}{newLine}Address:{newLine}{indent}Province:{Address.Province}{newLine}{indent}City:{Address.City}{newLine}";
        return str;
    }

    /// <summary>
    /// 深拷贝
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (var stream = new System.IO.MemoryStream())
        {
            serializer.Serialize(stream, this);
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            return serializer.Deserialize(stream) as Person;
        }
    }
    }
}