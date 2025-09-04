using sistem;
class Program
{
    static void Main()

    {
        strig[] nombre = { "fran", "luis", "ana", "maria" };

        Console.WriteLine("Escoge un nombre del 1 al 4");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El nombre escogido es: " + nombre[numero - 1]);

    }

}
