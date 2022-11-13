// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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

double is1221(double op1, double op2){
    double ost = op2%op1;
    if(ost ==0){
        Console.WriteLine("Кратно");
    }
    else{
        Console.WriteLine(ost);
    }
    return ost;
}

is1221(AskUser(), AskUser());