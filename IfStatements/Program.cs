// See https://aka.ms/new-console-template for more information

/*
 if(condicao a testar)
{
  comando a ser executado caso a condicao seja verdadeira
}
 */

const string APPROVED = "Aprovado!";
const string DISAPPROVED = "Reprovado!";
const string TEST = "Em recuperação!";

Console.WriteLine("Digite a sua nota: ");
decimal value = Convert.ToDecimal(Console.ReadLine());

if (value >= 50)
{
    Console.WriteLine(APPROVED);
}
else if (value >= 4 && value < 5)
{
    Console.WriteLine(TEST);
}
else
{
    Console.WriteLine(DISAPPROVED);
}
