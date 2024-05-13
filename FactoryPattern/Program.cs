using System.Threading.Channels;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("How many wheels whould like on your vehicale, or type exit to quit");
         var vehicaleType = Console.ReadLine();

         var vehicaleName = VehicleFactory.GetRide(vehicaleType);

            vehicaleName.Drive();
            
        }
    }
}
