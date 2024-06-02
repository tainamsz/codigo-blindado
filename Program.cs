namespace codigo_blindado;

public class Program

{
    public static void Main()

        {
            Calculadora calc = new Calculadora();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha uma operação: soma, subtracao, multiplicacao, divisao, historico ou sair:");
                string escolha = Console.ReadLine().ToLower();

                if (escolha == "sair")
                {
                    continuar = false;
                }
                else if (escolha == "historico")
                {
                    calc.ExibirHistorico();
                }
                else
                {
                    Console.WriteLine("Digite o primeiro número:");
                    if (!int.TryParse(Console.ReadLine(), out int a))
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro!");
                        continue;
                    }

                    Console.WriteLine("Digite o segundo número:");
                    if (!int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro!");
                        continue;
                    }

                    try
                    {
                        switch (escolha)
                        {
                            case "soma":
                                Console.WriteLine($"Resultado da soma: {calc.Somar(a, b)}");
                                break;
                            case "subtracao":
                                Console.WriteLine($"Resultado da subtracao: {calc.Subtrair(a, b)}");
                                break;
                            case "multiplicacao":
                                Console.WriteLine($"Resultado da multiplicacao: {calc.Multiplicar(a, b)}");
                                break;
                            case "divisao":
                                Console.WriteLine($"Resultado da divisao: {calc.Dividir(a, b)}");
                                break;
                            default:
                                Console.WriteLine("Operação desconhecida.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                }
            }
        }
}


