namespace ConsoleApp6;

public class Calculation
{
    public string calculationLine;

    public string Calc
    {
        get => this.calculationLine;
        set => this.calculationLine = value;
    }

    
    public void SetCalculationLine()
    {
        calculationLine = Console.ReadLine();
    }

    public void SetLastSymbolCalculationLine()
    {
        calculationLine += Console.ReadLine();
    }

    public void GetCalculationLine()
    {
        Console.WriteLine($"Значения calculationLine = {calculationLine}");
    }

    public void GetLastSymbol()
    {
        Console.WriteLine($"Последний символ:{calculationLine[calculationLine.Length - 1]}");
    }

    public void DeleteLastSymbol()
    {
        int x = calculationLine.Length - 1;
        calculationLine = calculationLine.Remove(x);
        Console.WriteLine($"Число удалено...");
        Console.WriteLine($"Значения calculationLine = {calculationLine}");
    }
}