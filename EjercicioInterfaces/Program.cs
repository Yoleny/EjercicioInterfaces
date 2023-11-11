using EjercicioInterfaces;

public class Program
{
    public static void Main(string[] args)
    {
        Suma suma = new Suma(5, 3);
        Resta resta = new Resta(10, 4);

        suma.RealizarOperacion();
        suma.MostrarResultado();

        resta.RealizarOperacion();
        resta.MostrarResultado();
    }
}
