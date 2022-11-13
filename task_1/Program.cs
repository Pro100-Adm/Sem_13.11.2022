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

int [] arr = new int[10];

void FillArray(int [] array){
    for(int i = 0; i<array.Length; i++)
        array[i] = new Random().Next(10, 100);
}

int [] PrintArray(int [] array){
    for(int i = 0; i<array.Length; i++){
        Console.WriteLine(array[i]);
        Console.WriteLine(array[i]%10);
    }
    return array;
}

FillArray(arr);
PrintArray(arr);