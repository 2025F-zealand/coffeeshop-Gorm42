namespace Bridge
{
    public class Car : Vehicle
    {
        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
        }
        public double Price(bool haveBroBizz)
        {
            if (haveBroBizz == true)
            {
                return 230 * discount;
            }
            else
            {
                return 230;
            }
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
