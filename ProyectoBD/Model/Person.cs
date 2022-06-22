using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ProyectoBD.Model
{
    [DataContract]
    public partial class Person
    {
        [DataMember]
        public int BusinessEntityID { get; set; }
        [DataMember]
        public string PersonType { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Suffix { get; set; }

        public Person() { }

        public Person(string PersonType,
            string Title,
            string FirstName,
            string MiddleName,
            string LastName,
            string suffix
            )
        {
            this.PersonType = PersonType;
            this.Title = Title;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Suffix = suffix;
        }
    }
}
