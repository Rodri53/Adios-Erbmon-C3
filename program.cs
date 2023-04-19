Console.WriteLine("Introduzca su nombre por favor");
String nombre;
nombre = Console.ReadLine();
String reverse = "";
for (int i = nombre.Length - 1; i >= 0; i--)
{
    reverse += nombre[i];
}
    Console.WriteLine("Adiós " + reverse);