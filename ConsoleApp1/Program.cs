//encapsulation

using ConsoleApp1.src.oops.polymorphism;

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car{Brand = "Toyota", Model = "Corolla", year = 2019, NumberOfDoors = 4});
vehicles.Add(new Motorcycle{Brand = "Boeing", Model = "sports", year = 2019});   
vehicles.Add(new Plane{Brand = "Honda", Model = "Civic", year = 2019, NumberOfDoors = 4});
 
 //vehicle inspection

 foreach (var vehicle in vehicles)
 {
        vehicle.Start();
        vehicle.Stop();
 }
 