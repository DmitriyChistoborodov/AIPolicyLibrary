using System.Xml.Serialization;

namespace AIPolicyLibrary.Configuration.Description
{
    public class AIObjectDescription
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Caption { get; set; }

        [XmlAttribute]
        public string Title { get; set; }

        [XmlAttribute]
        public int Version { get; set; }

        public AIObjectDescriptionCollection Attributes { get; set; }
    }
}