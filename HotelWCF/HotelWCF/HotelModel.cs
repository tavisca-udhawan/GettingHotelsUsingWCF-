using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    public class HotelModel : IHotel
    {

        HotelDetails AllHotels = new HotelDetails();
        public string GetHotelById(int id)
        {
            List<Hotel> list = AllHotels.hotels;
            Hotel hotel = new Hotel();
            int flag = 0;
            for(var check = 0; check < list.Count; check++)
            {
                if (list[check].ID == id)
                {
                    hotel.ID = list[check].ID;
                    hotel.Name = list[check].Name;
                    hotel.Address= list[check].Address;
                    hotel.Rating = list[check].Rating;
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
            return string.Format("Hotel Name: {0},  Hotel ID: {1}, Address: {2}, Rating: {3}",hotel.Name,hotel.ID,hotel.Address,hotel.Rating );
            else
                return string.Format("No Data Found");
        }

        public List<Hotel> GetHotels()
        {
            return AllHotels.hotels;
        }
    }
}
