using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ProyectoBD.Model
{
    [DataContract]
    public partial class PhoneNumber
    {
        [DataMember]
        public int Phone { get; set; }

        public PhoneNumber() { }

        public PhoneNumber(int Phone)
        {
            this.Phone = Phone;
        }
    }
}
