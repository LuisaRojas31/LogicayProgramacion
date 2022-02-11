// See https://aka.ms/new-console-template for more information

int numero;
double funcion;

Console.WriteLine("Ingrese el valor de x: ");
numero = int.Parse(Console.ReadLine());

while (numero >= 0)
{
    for (int x = 0; x <= numero; x += 2)
    {
        funcion = Math.Pow(x, 3) + Math.Pow(x, 2) - 5;
        Console.Write("Para x = {0} f(x) = {1} \n", x, funcion);
    }
    numero = -1;
}
Console.WriteLine("Terminó la ejecución");
