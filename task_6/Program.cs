// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

void is1221(double op){
    double ost1 = op%7;
    double ost2 = op%23;

    if(ost1 ==0 && ost2==0){
        Console.WriteLine("Кратно");
    }
    else{
        Console.WriteLine("Не Кратно");
    }
    
}

is1221(Convert.ToDouble(Console.ReadLine()));
