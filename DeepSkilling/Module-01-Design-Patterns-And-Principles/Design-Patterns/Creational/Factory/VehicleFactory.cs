namespace Factory;

public class VehicleFactory
{

    public IVehicle GetVehicle(string type)
    {

        if(type == "Car")
        {
            return new Car();
        }


        else if(type == "Bike")
        {
            return new Bike();
        }


        else
        {
            throw new Exception("Vehicle not found");
        }

    }

}