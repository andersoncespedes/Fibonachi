using System.Security.Principal;

public static class Program{
    public static bool IsFibonacci(int num){
        if(num == 0)return true;
        List<int> fib = new List<int>(){0,1};
        do{
            fib.Add( fib[fib.Count - 1] + fib[fib.Count - 2]);
        }while(fib.Last() < num);
        return fib.Last() == num;
    }
     public static void FibonacciList(int num){
        List<int> fib = new List<int>(){0,1};
        for(int i = 2; i <= num ; i++){
            fib.Add(fib[fib.Count - 1] + fib[fib.Count - 2]);
        }
        foreach(var a in fib){
            Console.WriteLine(a);
        }
    }
    public static int Fibonacci(int num){
        List<int> fib = new List<int>(){0,1};
        for(int i = 2; i <= num ; i++){
            fib.Add(fib[fib.Count - 1] + fib[fib.Count - 2]);
        }
        return fib.Last();
    }
    public static void Main(string[] args){
        int op;
        do{
        Console.Clear();
        Console.WriteLine("Elija Un Ejercicio");
        Console.WriteLine("1:Es Fibonachi");
        Console.WriteLine("2:Secuencia Fibonacci");
        Console.WriteLine("3:Salir");
        op = int.Parse( Console.ReadLine());
        if(op == 1){
            Console.WriteLine("Ingrese un Numero");
            int num = int.Parse(Console.ReadLine());
            bool res = IsFibonacci(num);
            Console.WriteLine(!res ? $"{num} No Es numero de Fibonacci " :  $"{num} Es numero de Fibonacci ");
            Console.WriteLine("Presione Enter Para Continuar ->");
            Console.ReadLine();
        }
        else if(op == 2){
            Console.WriteLine("Ingrese un Numero");
            int num = int.Parse(Console.ReadLine());
            int res = Fibonacci(num);
            Console.WriteLine($"La secuencia numero {num} en fibonacci es {res}");
            Console.WriteLine("Presione Enter Para Continuar ->");
            Console.ReadLine();
        }
         else if(op == 3){
            Console.WriteLine("Ingrese un Numero");
            int num = int.Parse(Console.ReadLine());
            FibonacciList(num);
            Console.WriteLine("Presione Enter Para Continuar ->");
            Console.ReadLine();
        }
        }while(op != 3);
        
        Console.WriteLine(Fibonacci(11));

    }
}
