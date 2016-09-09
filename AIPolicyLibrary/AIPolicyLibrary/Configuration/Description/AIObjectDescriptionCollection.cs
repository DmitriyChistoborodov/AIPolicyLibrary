using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AIPolicyLibrary.Configuration.Description
{
    public class AIObjectDescriptionCollection : ICollection<AIObjectDescription>
    {
        private readonly ICollection<AIObjectDescription> descriptions;

        public AIObjectDescriptionCollection(ICollection<AIObjectDescription> descriptions)
        {
            this.descriptions = descriptions;
        }

        public AIObjectDescriptionCollection()
        {
            descriptions = new List<AIObjectDescription>();
        }

        public IEnumerator<AIObjectDescription> GetEnumerator()
        {
            return descriptions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) descriptions).GetEnumerator();
        }

        public void Add(AIObjectDescription item)
        {
            descriptions.Add(item);
        }

        public void Clear()
        {
            descriptions.Clear();
        }

        public bool Contains(AIObjectDescription item)
        {
            return descriptions.Contains(item);
        }

        public void CopyTo(AIObjectDescription[] array, int arrayIndex)
        {
            descriptions.CopyTo(array, arrayIndex);
        }

        public bool Remove(AIObjectDescription item)
        {
            return descriptions.Remove(item);
        }

        public int Count
        {
            get { return descriptions.Count; }
        }

        public bool IsReadOnly
        {
            get { return descriptions.IsReadOnly; }
        }


        public AIObjectDescription this[string name] => descriptions.First(x => x.Name == name);

    }
}