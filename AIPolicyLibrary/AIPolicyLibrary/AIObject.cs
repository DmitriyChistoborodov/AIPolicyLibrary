using System.IO;

namespace AIPolicyLibrary
{
    public abstract class AIObject
    {
        public abstract void Read(BinaryReader binaryReader);
        public abstract void Write(BinaryWriter binaryWriter);

        
    }
}