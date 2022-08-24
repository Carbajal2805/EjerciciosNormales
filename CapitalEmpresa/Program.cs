// See https://aka.ms/new-console-template for more information
Console.WriteLine("Capital Empresa");
Console.WriteLine("Ingrese la Cantidad de Socios");
int cantidad = int.Parse(Console.ReadLine());
int[] socios = new int[cantidad];
int suma = 0;
for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Ingrese la Cantidad del Socio #"+i);
    socios[i]=int.Parse(Console.ReadLine()) ;
    suma = suma + socios[i];
 

}
Console.WriteLine("Porcentaje de cada Socio");
for (int i = 0; i < cantidad; i++)
{
 
    Console.WriteLine("El porcentaje del socio #" + i + " es de :" + ((socios[i] * 100) / suma).ToString("0.00"));
}
