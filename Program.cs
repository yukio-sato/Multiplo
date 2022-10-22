Console.ForegroundColor = ConsoleColor.White;
string frase = "- - Multiplo - -\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.Yellow;
frase = "Escreva um número para se dividir: ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
int numero = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Cyan;
frase = "Escreva um número para dividir o numero escolhido: ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
int numero2 = Convert.ToInt32(Console.ReadLine());
if (numero % numero2 != 1)
{
Console.ForegroundColor = ConsoleColor.DarkGreen;
frase = $"{numero} é multiplo\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
}
else if (numero % numero2 >= 1)
Console.ForegroundColor = ConsoleColor.Red;
frase = $"{numero} não é multiplo\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}

Console.ResetColor();
