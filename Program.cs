
//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] array1 = {"Hello", "2", "World", ":-)"};
string [] array2 = {"1234", "1567", "-2", "computer science"};
string [] array3 = {"Russia", "Denmark", "Kazan"};

maxLenght = 3;

string [] ShortArray (string [] array){
    int lenght = array.Length;
    string [] arrResult = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++){
        if(array[i].Length <= maxLengnt){
           arrResult[count] = array[i];
		   count++; 
        }
    }
    return arrResult;
}

void PrintArray(string[] array){
	if(array.Length == 0){
		Console.WriteLine("Array is empty");
	}
	else{
       for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    }
} 
