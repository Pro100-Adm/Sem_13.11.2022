// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    if (op>7){
        Console.WriteLine("Введите верное число!");
        return AskUser();
    }
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}else
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

void isHoliday(int num)
{
    Dictionary<int, string> WeekDays = new Dictionary<int, string>()
    {
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"}  
};
if(WeekDays[num]=="Суббота" || WeekDays[num]=="Воскресенье"){
    Console.WriteLine("Выходной день");
}else{
    Console.WriteLine("Рабочий день");
}
}

isHoliday(AskUser());
