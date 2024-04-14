using System;

public struct Student
{
    public string surnameNO;
    public string groupNumber;
    public double[] marks;

    public double AverageMarks()
    {
        double sum = 0;
        foreach (double mark in marks)
        {
            sum += mark;
        }
        return sum / marks.Length;
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[7];

        students[0] = new Student { surnameNO = "Крючков Е.С.", groupNumber = "2", marks = new double[] { 4, 3, 4.2, 4.8, 2 } };
        students[1] = new Student { surnameNO = "Егоров Е.С.", groupNumber = "22", marks = new double[] { 3.7, 3.5, 4, 5, 4.9 } };
        students[2] = new Student { surnameNO = "Кушнарёв Р.В", groupNumber = "24", marks = new double[] { 4.8, 4.7, 4.9, 4.6, 4.6 } };
        students[3] = new Student { surnameNO  = "Коробкин И.А.", groupNumber = "24", marks = new double[] { 2, 3, 3, 2, 3} };
        students[4] = new Student { surnameNO = "Левин А.С.", groupNumber = "23", marks = new double[] { 4.0, 3.5, 4.1, 4.2, 3.8 } };
        students[5] = new Student { surnameNO = "Правин К.С.", groupNumber = "23", marks = new double[] {4, 4, 4, 4,3} };
        students[6] = new Student { surnameNO = "Сергеев С.Ю.", groupNumber = "23", marks = new double[] { 4.5, 4.3, 4.2, 4.4, 4.1 } };

        Array.Sort(students, (x, y) => x.AverageMarks().CompareTo(y.AverageMarks()));

        Console.WriteLine("Студенты:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.surnameNO} ({student.groupNumber}) - Средний балл: {student.AverageMarks():0.00}");
        }
    }
}