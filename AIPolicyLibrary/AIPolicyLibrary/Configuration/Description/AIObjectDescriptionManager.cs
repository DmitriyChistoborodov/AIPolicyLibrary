using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace AIPolicyLibrary.Configuration.Description
{
    public static class AIObjectDescriptionManager
    {
        // AIPolicyLibrary.desc
        private static readonly string fileName = Assembly.GetExecutingAssembly().GetName().Name + ".desc";

        public static AIObjectDescriptionCollection Descriptions { get; }

        static AIObjectDescriptionManager()
        {
            var parent = new AIObjectDescriptionCollection()
            {
                new AIObjectDescription()
                {
                    Name = "parentName",
                    Caption = "captionName",
                    Title = "titleParent",
                    Attributes = new AIObjectDescriptionCollection()
                    {
                        new AIObjectDescription()
                        {
                            Caption = "childName"
                        }
                    }
                }
            };

            Descriptions = parent;
            var xmlSerializer = new XmlSerializer(Descriptions.GetType());
            xmlSerializer.Serialize(File.Create(fileName),Descriptions);
        }
    }
}