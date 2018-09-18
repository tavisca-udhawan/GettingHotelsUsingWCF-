using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    [ServiceContract]
    public interface IHotel
    {
        [OperationContract]
       string GetHotelById(int id);

        [OperationContract]
        List<Hotel> GetHotels();
    }
}
