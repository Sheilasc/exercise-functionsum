internal class Program
{
    private static void Main(string[] args)
    {
        int a = Leer("ingrese Valor1: ");
        int b = Leer("ingrese Valor2: ");

        int resultado = sumar (a ,b);
        Console.WriteLine("El resultado es: "+resultado);
    }

    public static int Leer(string mensaje)
  {
    Console.WriteLine(mensaje);
    string numeroComoString = Console.ReadLine();
    int valor = Int32.Parse(numeroComoString);
    return valor;
  }

  public static int sumar(int numero1, int numero2)
  {
    int sumatotal = (numero1 + numero2);
    return sumatotal;
  }
}