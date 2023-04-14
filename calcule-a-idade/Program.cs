using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a idade em dias: ");
        int dias = int.Parse(Console.ReadLine());

        int idadeEmDias = anos * 365 + meses * 30 + dias;

        Console.WriteLine("A idade em dias é: " + idadeEmDias);

        Console.ReadLine();
    }
}
