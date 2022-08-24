// See https://aka.ms/new-console-template for more information
Console.WriteLine("Promedio Notas");
Console.WriteLine("Ingrese la Cantidad de alumnos");
int cantidad=int.Parse(Console.ReadLine());
int[] alumnos = new int[cantidad];
int suma = 0;
for(int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Ingrese la nota del Alumno #"+i);
    alumnos[i] = int.Parse(Console.ReadLine());
    suma = suma + alumnos[i];

}
double promedio = suma / cantidad;
Console.WriteLine("El promedio de los alumnos es de:"+promedio);
