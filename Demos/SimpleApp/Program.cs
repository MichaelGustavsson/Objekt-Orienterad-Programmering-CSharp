// Ändrar färgen på text och bakgrund...
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("Vad heter du?");
var name = Console.ReadLine();
Console.WriteLine("Hej {0}", name);
/*
    Återställer färgerna
    till sist original...
*/
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Klar med koden!");