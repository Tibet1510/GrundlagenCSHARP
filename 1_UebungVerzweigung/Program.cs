/*
int x = 9;
double y = 8;
int z = 6;
*/

//Console.WriteLine(x-- == y);    //Ausgabe: False

//Console.WriteLine(x == (int)y);   //Ausgabe: False

//Console.WriteLine("{0:F1}",0.123);              //Ausgabe: 0,1

//Console.WriteLine(z/y);                         //Ausgabe: 0,75

//Console.WriteLine(x-=10);   //Ausgabe: -1

//Console.WriteLine(x--== y & true);             //Ausgabe: False

//Console.WriteLine(!(z == 6) | false);           //Ausgabe: False

//Console.WriteLine((x*=-2) == z );               //Ausgabe: False

Console.WriteLine("Was soll umgewandelt werden?");
    Console.WriteLine(
        "\n (1) Umrechnung von Celsius nach Kelvin"+
        "\n (2) Umrechnung von Celsius nach Fahrenheit"+
        "\n (3) Umrechnung von Kelvin nach Celsius"+
        "\n (4) Umrechnung von Kelvin nach Fahrenheit");
int temp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Erste Zahl:");
float x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zweite Zahl:");
float y = Convert.ToInt32(Console.ReadLine());
