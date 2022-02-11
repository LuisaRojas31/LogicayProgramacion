// See https://aka.ms/new-console-template for more information

int numeroN;
int suma = 0;
int contador = 1;


Console.WriteLine("ingrese Número");
numeroN = Convert.ToInt32(Console.ReadLine());

if (numeroN <= 10)
{
    Console.WriteLine("El Número debe ser mayor a 10");

}
else
{
    while (contador <= numeroN)
    {
        if (contador != 5 && contador != 10)
        {
            suma = suma + contador;
        }
        contador++;
    }
    Console.WriteLine("la suma es:" + suma);

}
