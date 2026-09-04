Console.Clear();

Console.Write("Digite algo: ");

string digitado = Console.ReadLine();
digitado = digitado.Trim();

Console.WriteLine();

Console.Write("O primeiro caractere digitado (exceto espaços) foi: ");

Console.ForegroundColor = System.ConsoleColor.Cyan;
Console.WriteLine(digitado.Substring(0, 1));

Console.ResetColor();