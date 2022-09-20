// See https://aka.ms/new-console-template for more information
/*
int value = 0; 
switch(value)
{
  case 1: 
    comando a ser executado;
    break;
 case 2: 
    comando a ser executado; 
    break;
}
 */

const string DIAS_31 = "Este mês tem 31 dias!";
const string DIAS_30 = "Este mês tem 30 dias!";
const string DIAS_28 = "Este mês tem 28 dias!";
const string MES_INVALIDO = "Este mês não existe!";

Console.WriteLine("Escreva um mês: ");
string mes = Console.ReadLine();

switch (mes)
{
    case "JANEIRO":
    case "MARÇO":
        Console.WriteLine(DIAS_31);
        break;
    case "FEVEREIRO":
        Console.WriteLine(DIAS_28);
        break;
    case "ABRIL":
        Console.WriteLine(DIAS_30);
        break;
    default:
        Console.WriteLine(MES_INVALIDO);
        break;
}
