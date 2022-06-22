using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ProyectoBD.Model
{
    [DataContract]
    public partial class CreditCard
    {
        [DataMember]
        public int CreditCardID { get; set; }
        [DataMember]
        public string CardType { get; set; }
        [DataMember]
        public string CardNumber { get; set; }
        [DataMember]
        public byte ExpMonth { get; set; }
        [DataMember]
        public Int16 ExpYear { get; set; }

        public CreditCard() { }

        public CreditCard(int CreditCardId, 
            string CardType, 
            string CardNumber, 
            byte ExpMonth, 
            Int16 ExpYear)
        {
            this.CreditCardID = CreditCardId;
            this.CardType = CardType;
            this.CardNumber = CardNumber;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
        }
    }
}
