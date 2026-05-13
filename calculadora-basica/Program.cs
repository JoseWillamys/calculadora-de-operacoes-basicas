// Calculadora de operações básicas
Console.WriteLine("Calculadora de operações básicas.\n");

// solicitando os dados ao usuário 
double primeiroNumero = ValidarInformacao("Digite o primeiro número:");
double segundoNumero = ValidarInformacao("Digite o segundo número:");
char tipoDaOperacao = ValidarOperacao("Informe qual operação você deseja realizar (+, -, *, /):");

// Calcula o resultado conforme o operador informado
// Usa switch expression para escolher a operação
double resultado = tipoDaOperacao switch
{
    '+' => primeiroNumero + segundoNumero,
    '-' => primeiroNumero - segundoNumero,
    '*' => primeiroNumero * segundoNumero,
    '/' => segundoNumero != 0 ? primeiroNumero / segundoNumero : double.NaN, // Tratamento de divisão por zero
    _ => double.NaN
};

// validando o resultado
if (double.IsNaN(resultado))
{
    Console.WriteLine("Erro: operação inválida");
} 
else
{
    Console.WriteLine($"Resultado: {resultado}");
}


// funções para validar os dados necessários 
double ValidarInformacao(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string entrada = Console.ReadLine()!;

        if (double.TryParse(entrada, out double valorConvertido))
        {
            return valorConvertido;
        }

        Console.WriteLine("Apenas números são aceitos, tente novamente.\n");
    }
}

char ValidarOperacao(string msg)
{

    while (true)
    {
        Console.WriteLine(msg);
        string operador = Console.ReadLine()!;

        if (operador.Length == 1 && "+-*/".Contains(operador))
        {
            return operador[0];
        }

        Console.WriteLine("Operação inválida. Digite apenas +, -, * ou /.\n");
    }
}
