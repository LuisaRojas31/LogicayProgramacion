// See https://aka.ms/new-console-template for more information

int numero;
int contadorNumero = 6;

Console.WriteLine("Ingrese Número");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 6)
{
    while (contadorNumero <= numero)
    {
        if (contadorNumero % 3 == 0)
        {
            Console.WriteLine("Los multiplos de 3 entre 6 y n son:" + contadorNumero);
        }
        contadorNumero++;
    }
}
else
{
    Console.WriteLine("El Número debe ser mayor a 6");
}
