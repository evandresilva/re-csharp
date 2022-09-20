// See https://aka.ms/new-console-template for more information

//Manipulação de strings

string text = "O dia está lindo!";
// O substring vai retornar parte do texto, desde a posicao inicial até um certo tamanho
string subtringText = text.Substring(0, text.Length - 1);

string replaceText = text.Replace("lindo", "chuvoso");

string trimText = text.Trim();
string trimStartText = text.TrimStart();
string trimEndText = text.TrimEnd();

string trimCharText = text.Trim('!');

string referenceNumber = "768945384";
string padLeftReferenceNumber = referenceNumber.PadLeft(11, '0');
string padRightReferenceNumber = referenceNumber.PadRight(11, '0');

string text2 = trimCharText + " e ensolarado";

string interpolationText = $"{trimCharText} e ensolarado";
Console.WriteLine(interpolationText);