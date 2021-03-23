using System;

namespace Excersise06
{
    [Serializable]
    public class Address
    {
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}