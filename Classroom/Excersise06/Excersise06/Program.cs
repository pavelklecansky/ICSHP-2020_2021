using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Excersise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person01 = new Person()
            {
                Id = 0,
                FirstName = "Franta",
                LastName = "Flinta",
                Description = "First person in line",
                MainAddress = new Address()
                {
                    Street = "Vankova",
                    HouseNumber = 13,
                    PostCode = 58203,
                    City = "Benesov",
                    State = "Czech Republic"
                }
            };
            person01.Bills.Add(new Bill {Number = 123456789, Code = 2010});
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.OpenWrite("person.dat"))
            {
                bf.Serialize(fs, person01);
            }

            using (FileStream fs = File.OpenRead("person.dat"))
            {
                Person person2 = (Person) bf.Deserialize(fs);
            }
        }
    }
}