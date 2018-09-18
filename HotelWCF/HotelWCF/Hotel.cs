using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int Rating { get; set; }
    }
}
