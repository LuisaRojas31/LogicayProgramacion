// See https://aka.ms/new-console-template for more information

string nombre;
string tipoServicio;
double valorComision = 0;
double valorPagadoUsuario = 0;
double valorTotalDia = 0;
string hayUsuarios = "s";
string hayServicios = "s";

Console.WriteLine("Ingrese el nombre del usuario: ");
nombre = Console.ReadLine();

while (hayUsuarios == "s")
{
    while (hayServicios == "s")
    {
        Console.WriteLine("Ingrese tipo de servicio: " +
            "\n 1. Masaje de relajación " +
            "\n 2. Masaje de reducción " +
            "\n 3. Mascarilla ");
        tipoServicio = Console.ReadLine();

        switch (tipoServicio)
        {
            case "1":
                valorComision += 50000;
                valorPagadoUsuario += 150000;
                break;
            case "2":
                valorComision += 80000;
                valorPagadoUsuario += 200000;
                break;
            case "3":
                valorComision += 20000;
                valorPagadoUsuario += 100000;
                break;
        }

        Console.WriteLine("\n¿Hay más servicios?: ");
        hayServicios = Console.ReadLine();
    }
    Console.WriteLine("\nEl valor pagado por este usuario es: {0}", valorPagadoUsuario);
    valorTotalDia += valorPagadoUsuario;
    valorPagadoUsuario = 0;
    hayServicios = "s";

    Console.WriteLine("\n¿Hay más usuarios?: ");
    hayUsuarios = Console.ReadLine();
}
Console.WriteLine("\nEl total de la comisión del día es: {0}", valorComision);
Console.WriteLine("\nEl valor total de servicios por el día de hoy es: {0}", valorTotalDia);
