using System;

var number = "72723339";

var decimalDigits = "0123456789";

List<int> listOfDecimalDigits = new List<int>();

List<int> numberOfRepetitionsDigit = new List<int>();

for (int i = 0; i < 10; i++)
{
    listOfDecimalDigits.Add(i);
    numberOfRepetitionsDigit.Add(0);
}

foreach (int digit in listOfDecimalDigits)
{
    foreach (char num in number)
    {
        var valueNumber = int.Parse(num.ToString());

        if (digit == valueNumber)
        {
            numberOfRepetitionsDigit[digit] = numberOfRepetitionsDigit[digit] + 1;
        }
    }
    Console.WriteLine($"{listOfDecimalDigits[digit]}  =>  {numberOfRepetitionsDigit[digit]}");
}


