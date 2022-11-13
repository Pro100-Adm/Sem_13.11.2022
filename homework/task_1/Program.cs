// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null && (Ask.Length==3 || (Ask.Length==4 && Ask[0]=='-'))){
try
{
    int op = int.Parse(Ask);
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

int PrintSecondNum(int num){
        num=num/10;
        num=num%10;
        Console.Write(num);
        return num;
    }

PrintSecondNum(AskUser());
