using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Excersise06
{
    [Serializable]
    public class Person : ISerializable
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public Address MainAddress { get; set; }


        [NonSerialized] 
        private List<Bill> _bills = new();

        public List<Bill> Bills => _bills;
        
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            
        }
    }
}