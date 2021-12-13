// See https://aka.ms/new-console-template for more information

using librarycalculator;
Calculator calculator=new Calculator();

int toplama = calculator.toplama(7, 8);
Console.Write("iki ededin toplamasi:="   +toplama+ "\n");

int cixma=calculator.cixma(10,7);
Console.Write("iki ededin cixmasi:="   + cixma + "\n");

double bolme = calculator.bolme(8, 4);
Console.Write("iki ededin bolunmesi:="  +bolme + "\n");

int vurma=calculator.vurma(8, 4);
Console.Write("iki ededin vurma:="+ vurma + "\n");


