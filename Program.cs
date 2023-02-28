/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.
 Entrada:                               Saida:
8                                       MUITO OBRIGADO
1                                       Alcool: 1
7                                       Gasolina: 2
2                                       Diesel: 3
2
4
 */

public class Program
{
    public static void Main(string[] args)
    {
        int gasolina = 0;
        int etanol = 0;
        int diesel = 0;

        Console.WriteLine("Digite o tipo de combustivel: 1 - Etanol; 2 - Gasolina; 3 - Diesel; 4 - Sair");
        int tipo = int.Parse(Console.ReadLine());

        while (tipo < 1 || tipo > 4)
        {
            Console.WriteLine("Digite um código válido");
            Console.WriteLine("Digite o tipo de combustivel: 1 - Etanol; 2 - Gasolina; 3 - Diesel; 4 - Sair");
            tipo = int.Parse(Console.ReadLine());
        }
        while (tipo != 4)
        {
            tipo = int.Parse(Console.ReadLine());
            if (tipo == 1)
                etanol++;

            else if (tipo == 2)
                gasolina++;

            else if (tipo == 3)
                diesel++;
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Etanol: " + etanol);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}