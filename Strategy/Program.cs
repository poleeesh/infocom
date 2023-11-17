abstract class NavigateFunction
{
    public string FunctionName { get; set; }
    public abstract void doFunction(string[] conditions);
}

class Navigator
{
    NavigateFunction func;
    string[] array;

    public Navigator(NavigateFunction func, string[] array)
    {
        this.func = func;
        this.array = array;
    }

    public void doFunc()
    {
        func.doFunction(array);
    }

    public void printResult()
    {
        Console.WriteLine(func.ToString());
        Console.WriteLine();
    }

}

class Map : NavigateFunction
{
    public Map()
    {
        FunctionName = "Карта навигатора";
    }
    
    public override string ToString()
    {
        return FunctionName;
    }

    public override void doFunction(string[] conds)
    {
        int a = 1;
    }
}

class Route : NavigateFunction
{
    public Route()
    {
        FunctionName = "Маршрут навигатора";
    }
    
    public override string ToString()
    {
        return FunctionName;
    }

    public override void doFunction(string[] conds)
    {
        int a = 1;
    }
}

class Program
{
    static void Main()
    {
        
    }
}
