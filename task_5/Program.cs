/// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

bool isSquare(double op1, double op2)
{
    if (op1 == Math.Pow(op2, 2)){
        Console.WriteLine("True");
        return true;
    }
    else{
        Console.WriteLine("False");
        return false;
    }
}


isSquare(AskUser(), AskUser());