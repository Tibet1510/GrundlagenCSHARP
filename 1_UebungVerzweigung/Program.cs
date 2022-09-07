
int x = 9;
double y = 8;
int z = 6;


//Console.WriteLine(x-- == y);    //Ausgabe: False

//Console.WriteLine(x == (int)y);   //Ausgabe: False

//Console.WriteLine("{0:F1}",0.123);              //Ausgabe: 0,1

//Console.WriteLine(z/y);                         //Ausgabe: 0,75

//Console.WriteLine(x-=10);   //Ausgabe: -1

//Console.WriteLine(x--== y & true);             //Ausgabe: False

//Console.WriteLine(!(z == 6) | false);           //Ausgabe: False

//Console.WriteLine((x*=-2) == z );               //Ausgabe: False

/*Console.WriteLine("Was soll umgewandelt werden?");
    Console.WriteLine(
        "\n (1) Umrechnung von Celsius nach Kelvin"+
        "\n (2) Umrechnung von Celsius nach Fahrenheit"+
        "\n (3) Umrechnung von Kelvin nach Celsius"+
        "\n (4) Umrechnung von Kelvin nach Fahrenheit");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zahl:");
float temp1 = float.Parse(Console.ReadLine());
switch(x)
{ case 1:

        if (temp1 > -217.16)
        {
            temp1 = (float)(temp1 + 273.15);
            Console.WriteLine(temp1 + " Kelvin!");
        }
        else
        {
            Console.WriteLine("Alles unter 217.15 Celsius sind unter dem absoluten Nullpunkt und demnach nicht möglich!");
        }
    break;
case 2:
        temp1 = (temp1 * 9 / 5) + 32;
        Console.WriteLine(temp1 + " Fahrenheit!");
        break;
case 3:
        temp1 = (float)(temp1 - 273.15);
        Console.WriteLine(temp1 + " Celsius!");
        break;
case 4:
        if (temp1 >= 0)
        {
            temp1 = (float)((temp1 - 273.15) * 9 / 5 + 32);
            Console.WriteLine(temp1 + " Fahrenheit!");
        }
        else
        {
            Console.WriteLine("0 Kelvin ist der absolute Nullpunkt");
        }
        break;
}
*/