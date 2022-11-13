// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int [] arr = new int[1];

void FillArray(int [] array){
    for(int i = 0; i<array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int [] PrintArray(int [] array){
    for(int i = 0; i<array.Length; i++){
        Console.WriteLine(array[i]);
        array[i]=array[i]/10+array[i]%10;
        Console.Write(array[i]);
    }
    return array;
}

FillArray(arr);
PrintArray(arr);