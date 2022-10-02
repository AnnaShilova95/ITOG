
//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Задаем исходный массив

string[] array1 = {"Hello", "2", "world", ":-)"};

//Метод, укорачивающий исходный массив до <= 3х элементов и переносящий элементы в новый
		
string[] ShortArray(string[] array){
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
			
	for (int i = 0; i < length; i++){
		if(array[i].Length <= 3){
			result[count] = array[i];
			count++;
			}
		}
	return result;
}
		
//Вывод масиива на экран

void PrintArray(string[] array){
	if(array.Length == 0) Console.WriteLine("Array is empty");
    else{
	Array.ForEach(array, (str) => Console.Write($"{str} "));
	Console.WriteLine();
    }
}
	
//Вывод исходного и итогового массивов

void PrintOrigArr(string[] array){
    Console.WriteLine("Изначальный массив:");
	PrintArray(array);
	string[] shortArray = ShortArray(array);
	Console.WriteLine("Итоговый массив");
	PrintArray(shortArray);
	Console.WriteLine();
}
		
PrintOrigArr(array1);


	
