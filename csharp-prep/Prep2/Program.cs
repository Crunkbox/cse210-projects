using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("PREPARE TO BE JUDGED. SUBMIT THINE GRADE. ");
        string grade = Console.ReadLine();
        string letter = "";
        if (int.Parse(grade) >= 90)
        {
            letter = "A";
        }
        else if (int.Parse(grade) >= 80)
        {
            letter = "B";
        }
        else if (int.Parse(grade) >= 70)
        {
            letter = "C";
        }
        else if (int.Parse(grade) >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        
        if (int.Parse(grade) >= 70)
        {
            Console.Write($"THINE GRADE IS '{letter}'. THOU DIDST ACHIEVE EXCELLANCE!");
        }
        else
        {
            Console.Write($"THINE GRADE IS '{letter}'. I SHALL CAST YOU OUT FROM MY PRECENSE!");
        }
    }
}