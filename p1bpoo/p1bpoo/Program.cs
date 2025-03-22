
using p1bpoo;
using p1bpoo.MisClases;

Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

Vehiculo_combustion autoCombustion = new Vehiculo_combustion(2022, "Gris", "Toyota", "Gasolina", 4, "Automatica", 14);

Moto miMoto = new Moto(2025, "Azul", "Yamaha", "Motocross", 2, 250);

Camion miCamion = new Camion(2010, "Blanco", "Freightliner", 8, 3, "Aire");

Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD", 90, true);

miBYD.InformacionVehiculo();
miBYD.cargarBateria();
Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());



