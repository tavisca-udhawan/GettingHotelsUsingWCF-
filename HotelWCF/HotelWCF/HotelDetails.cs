using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    public class HotelDetails
    {
        public List<Hotel> hotels;
        public HotelDetails()
        {
            hotels = new List<Hotel>();
            hotels.AddRange(GetdemoData());
        }
        public List<Hotel> GetdemoData()
        {
            Random random = new Random();
            List<Hotel> demoData = new List<Hotel>();
            for (int i = 1; i <= 10; i++)
            {
                Hotel model = new Hotel();
                model.ID = i;
                model.Name = string.Format("Hyatt{0}", i);
                model.Address = string.Format("Pune");
                model.Rating = random.Next(1, 6);
                demoData.Add(model);
            }
            return demoData;
        }
    }
}
