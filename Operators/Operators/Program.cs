// See https://aka.ms/new-console-template for more information


// Temos 3 tipos de operadores

//Operadores aritmetricos

int addition = 5 + 1;
int subtraction = 5 - 1;
int multiplication = 5 * 3;

int expr = (1 + 2) * 5 - 2 / 2;
//Operadores relacionais

string city1 = "Luanda";
string city2 = "Huambo";

bool ret1 = city1 == city2;
bool ret2 = city1 != city2;

int i = 2;
int j = 5;

bool ret3 = i == j;
bool ret4 = i != j;
bool ret5 = i > j;
bool ret6 = i < j;
bool ret7 = i >= j;
bool ret8 = i <= j;

//Operadores logicos

bool ret9 = i < j && city1 != city2;
bool ret10 = i < j || city1 == city2;
bool ret11 = !(i < j);

Console.WriteLine(ret11);