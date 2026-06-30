using Factory;


VehicleFactory factory = new VehicleFactory();


IVehicle car = factory.GetVehicle("Car");

car.Drive();



IVehicle bike = factory.GetVehicle("Bike");

bike.Drive();