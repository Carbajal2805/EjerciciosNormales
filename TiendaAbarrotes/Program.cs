// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tienda de Abarrotes");
int cantidad; double precio;
Console.WriteLine("Ingrese la Cantidad Seleccionada");
cantidad= int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del Producto");
precio = double.Parse(Console.ReadLine());
double monto = precio * cantidad;
Console.WriteLine("El Monto a pagar es de "+monto.ToString("0.00"));