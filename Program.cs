using System;
class Program
{
    public static void Main(string[] args)
    {
        double valor, alc, gas;
        String cont = "S", res;
        Console.Clear();
        while (cont.Equals("s", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Clear();
            Console.WriteLine("Informe o valor da gasolina: R$ ");
            gas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do álcool: R$ ");
            alc = double.Parse(Console.ReadLine());
            valor = alc / gas;
            res = valor > 0.7 ? "A gasolina vale mais a pena!\n" : valor == 0.7 ? "Tanto faz abastecer com um ou outro!\n" : "O álcool vale mais a pena!\n";
            Console.WriteLine(res);
            Console.WriteLine("Deseja efetuar um novo calculo?\nS-->SIM\nN-->NÃO");
            cont = Console.ReadLine();
        }
        Console.WriteLine("Programa finalizado!");
    }
}

