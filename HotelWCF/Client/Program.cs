using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                HotelClient client = new HotelClient("BasicHttpBinding_IHotel");
                Console.WriteLine("Enter option:");
                Console.WriteLine("1--Get Hotel By ID");
                Console.WriteLine("2--Get All Hotels");
                Console.WriteLine("3--To Exit");
                Console.WriteLine("Enter choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(client.GetHotelById(id));
                }
                else if (choice == 2)
                {
                    List<Hotel> list = new List<Hotel>(client.GetHotels());
                    for (var hotel = 0; hotel < list.Count; hotel++)
                    {
                        Console.WriteLine("Hotel Name: {0},  Hotel ID: {1}, Address: {2}, Rating: {3}", list[hotel].Name, list[hotel].ID, list[hotel].Address, list[hotel].Rating);
                    }
                }
                else if (choice == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}