// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




Console.WriteLine("Input number:  ");//Вводим число

int array = Convert.ToInt32(Console.ReadLine());
string str = array.ToString();
//Console.WriteLine(str);

int[] arrayB = new int[str.Length];
int sumElmMass = 0;
for (int i = 0; i < str.Length; i++)
{
    
    arrayB[i] = Convert.ToInt32(str[i].ToString());//int.Parse(str[i].ToString());
    sumElmMass = sumElmMass + arrayB[i];
    


}
Console.WriteLine("sumElmMass = " + sumElmMass);




