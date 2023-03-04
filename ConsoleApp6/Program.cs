namespace ConsoleApp6;

public class Program
{
    static void Main(string[] args)
    {
        Calculation solve = new Calculation();
        Console.WriteLine("Введите значения calculationLine");
        solve.SetCalculationLine();
        Console.WriteLine("Изменено...\nДобавте новый символ");
        solve.SetLastSymbolCalculationLine();
        Console.WriteLine("Изменено...\n");
        solve.GetCalculationLine();
        solve.GetLastSymbol();
        Console.WriteLine("");
        solve.DeleteLastSymbol();
    }
}