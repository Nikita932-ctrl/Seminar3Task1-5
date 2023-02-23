
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void isPalindrom (string palidromNumber)
{

    char[] palindromChar = palidromNumber.ToCharArray();

    if (palindromChar[0] == palindromChar[4] && palindromChar[1] == palindromChar[3])
    {
        Console.WriteLine($"Число {palidromNumber} палиндром") ;
    }
    else
    {
        Console.WriteLine($"Число не палиндром");
    }

}

isPalindrom("12821");


//напишите программу ,которая принимает на вход координаты двух точек их находит расстояние между ними в 3D пространстве

void TwoPointValue(int x1, int y1, int z1, int x2, int y2, int z2) //A(x1,y1,z1) B(x2,y2,z2) 
{

    var square = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    Console.WriteLine(Math.Round(square, 2));

}

TwoPointValue(3, 6, 8, 2, 1, -7);



//Напишите программу которая выдает число N и возвращает таблицу квадратов от 1 до N 


void squareTable(int N)
{

    for (int start = 1; start <= N; start++)
    {

        Console.WriteLine($"{Math.Pow(start, 3)}");


    }
}
squareTable(5);



//Доп. задание №1:


double bankCount (double deposit)
{
    double percentLessThundred = 0.05;
    double percentMoreHundredAndLess2Hundred = 0.07;
    double percentMore2Hundred = 0.1;
    double percent = 0;
    double result = 0;

    if (deposit < 100)
    {
        percent = deposit * percentLessThundred ;
        result = deposit + percent;

    }
    else if (deposit >= 100 && deposit < 200)
    {
        percent = deposit * percentMoreHundredAndLess2Hundred;
        result = deposit + percent;
    }
    else if (deposit >= 200)
    {
        percent = deposit * percentMore2Hundred;
        result = deposit + percent;
    }

    return result;
}

Console.WriteLine(bankCount(200));


//Доп. задание №2:

void interestingNumber(string number)
{
    char[] arrayNumber = number.ToCharArray();
    var interestingNumber = (int)arrayNumber[4] - (int)arrayNumber[0];




    var a = char.GetNumericValue(arrayNumber[2]);

    Console.WriteLine(a);


    if (interestingNumber == a)
    {
        Console.WriteLine($"Число {number} интересное");
    }
    else
    {
        Console.WriteLine("Не интересное(");
    }
}

interestingNumber("23456");