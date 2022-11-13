/// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
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

int ShowThirdNum(int num){
    double num_length = Math.Floor(Math.Log10(num))+1;
    if (num_length>=3){
        int third_num = Convert.ToInt32(Math.Floor((num%(Math.Pow(10,num_length-2)))/(Math.Pow(10, num_length-3))));
        Console.WriteLine($"Third number: {third_num}");
        return third_num;
    }
    else Console.WriteLine("No third number!");
    return 0;
}

ShowThirdNum(AskUser());
