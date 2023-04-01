
Console.WriteLine("--- Pet Hotel Check-in ---\n");

Console.Write("Espécie......: ");
string especie = Console.ReadLine()!;

Console.Write("Raça.........: ");
string raca = Console.ReadLine()!;

Console.Write("Alcunha......: ");
string alcunha = Console.ReadLine()!;

Console.Write("Idade (anos).: ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/cor..: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Pet Hotel \"Monga City\"");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                  |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("| Atende pela alcunha de: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("+=========================================================+");

Console.ResetColor();