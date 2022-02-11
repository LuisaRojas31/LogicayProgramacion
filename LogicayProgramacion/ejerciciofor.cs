// See https://aka.ms/new-console-template for more information
int numero;

Console.WriteLine("ingrese cantidad numeros");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    Console.WriteLine("{0} - {1} - {2}", i, i * i, i * (i + 1));
}
