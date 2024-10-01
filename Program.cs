//Exemplo de TryCatch com numerador e denominador
// O bloco try-catch em c# permite que você execute um bloco de código
// (try) que pode gerar exceções. Se uma exceção ocorrer, ela irá ser
// tratada no bloco catch.

/* Exemplo 1 com valores inteiros */
//try
//{
//    Console.Write("Digite o numerador: "); // string "5" =  5 int
//    int numerador = int.Parse(Console.ReadLine());

//    Console.Write("Digite o denominador: ");
//    int denominador = int.Parse(Console.ReadLine());

//    int resultado = numerador / denominador;
//    Console.WriteLine($"O resultado da divisão é: {resultado}");
//} catch(DivideByZeroException)
//{
//    Console.WriteLine("Erro: Não é possível dividir por zero!");
//}
//catch(FormatException)
//{
//    Console.WriteLine("Erro: Por favor, digite números válidos");
//}

/* Exemplo 2 com casas decimais utilizando Double e convertendo esses valores com o TryParse */
using System.Globalization;

try
{
    Console.Write("Digite o numerador: "); // string "5" =  5 int
    double numerador;
    // ! significa diferente
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador))
    {
        Console.WriteLine("Erro: por favor digite um numero válido.");
        Console.Write("Digite o numerador: ");
    }

    Console.Write("Digite o denominador: ");
    double denominador;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
    {
        Console.WriteLine("Erro: por favor digite um numero válido.");
        Console.Write("Digite o denominador: ");
    }
    //Verifica o valor do denominador e caso seja zero gera uma exceção
    if (denominador == 0)
    {
        throw new DivideByZeroException();
    }

    double resultado = numerador / denominador;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Não é possívela dividir por zero!");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}
Console.ReadKey();