Console.WriteLine("--- Tabuada ---");
int numerodigitado;
int n = 1;


Console.Write("Digite o numero para fazer a tabuada dele: ");
numerodigitado = Convert.ToInt32(Console.ReadLine());

while (n < 10)
{
    Console.WriteLine($"{numerodigitado} X {n} = {numerodigitado * n}");
    n = n + 1;
}   