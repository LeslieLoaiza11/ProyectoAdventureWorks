using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ProyectoBD.Model
{
    [DataContract]
    public partial class EmailAdress
    {
        [DataMember]
        public int EmailAdressID { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
