using Bridge;

namespace Oresundbro
{
    public class OreSundBro
    {
        public OreSundBro() { }

        public double Price(Vehicle vehicle, bool haveBroBizz)
        {
            Car car = new Car("12345678");
            double carTicketPrice = 460;
            double MCticketPrice = 235;


            if (vehicle == car)
            {
                if (haveBroBizz == true)
                {
                    carTicketPrice = 178;
                }

                return carTicketPrice;
            }
            else
            {
                if (haveBroBizz == true)
                {
                    MCticketPrice = 92;
                }
                return MCticketPrice;
            }
        }

        public string VehicleType(string typeVehicle)
        {
            string itIsACar = "Car";
            string car = itIsACar.ToLower();
            if (typeVehicle == car)
            {
                return "Car";
            }
            else
            {
                return "MC";
            }

    }




    }
}
