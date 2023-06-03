// See https://aka.ms/new-console-template for more information

int? i = null;
byte a = 0b1111_1111;
long b = 0xAFD12;
decimal c = 1/30000m;
float f = 1/30000f;
double d = 1/30000d;
bool bandera = true;
char l = 'a';
var s = false;
Console.WriteLine("El valor de i es {0}", i);
Console.WriteLine("El valor de a es {0}", a);
Console.WriteLine("El valor de b es {0:X}", b);
Console.WriteLine("Valores con puntos flotantes");
Console.WriteLine("El valor de c es {0}", c);
Console.WriteLine("El valor de f es {0}", f);
Console.WriteLine("El valor de d es {0}", d);
Console.WriteLine(bandera);
Console.WriteLine(l);
Console.WriteLine("Valores tipo var");
Console.WriteLine("El valor de s es {0} de tipo {1}", s, s.GetType());
Console.ReadKey();
