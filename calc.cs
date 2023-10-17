public class Calc {
    public int Sum(int x, int y){
        return x + y;
    }
}

public class Requester{
    Calc calc;

    public Requester(Calc calc){
        this.calc = calc;
    }
    public void req(){
        double firstValue, secondValue;
        string action = "";

        Console.WriteLine("Введите число 1");
        firstValue = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Введите число 2");
        secondValue = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
        action = Console.ReadLine();

        switch (action)
        {
            case "+":
            Console.WriteLine(firstValue + secondValue);
            break;
            case "-":
        Console.WriteLine(firstValue - secondValue);
            break;
            case "*":
        Console.WriteLine(firstValue * secondValue);
            break;
            case "/":
        if (secondValue == 0)
        {
        Console.WriteLine(0);
        }
            else
        {
        Console.WriteLine(firstValue / secondValue);
        }
            break;
            default:
        Console.WriteLine("Ошибка! Неизвестное действие!");
        b   reak;
        }          
        Console.ReadLine();
    }
}
        class Program{
        static void Main(string[] args){
        Calc calc = new Calc();
        Requester req = new Requester(calc);
        req.req();
    }
}