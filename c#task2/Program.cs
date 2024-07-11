using System;

class Program
{
    static void Main()
    {
      
        PrintMultiplicationTable();
        GetUserInput();
        CreateAndDisplayStudent();
    }

    // Task 1: Multiplication Table
    static void PrintMultiplicationTable()
    {
        Console.WriteLine("Multiplication Table:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}");
            }
            Console.WriteLine();
        }
    }

    // Task 2: Get user input
    static void GetUserInput()
    {
        Console.WriteLine("Enter some data:");
        string userInput = Console.ReadLine();
        Console.WriteLine($"You entered: {userInput}");
    }

    // Task 3: Create and display student instance
    static void CreateAndDisplayStudent()
    {
        // Create an instance of the student class
        Student student = new Student("John", "Doe", 20, 12, 12345);
        student.DisplayStudentInfo();
    }
}

class Student
{
    public string fname;
    public string lname;
    public int age;
    public int grade;
    public int id;

    public Student() { }

    public Student(string fname, string lname, int age, int grade, int id)
    {
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.grade = grade;
        this.id = id;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student Info:First Name: {fname}Last Name: {lname}Age: {age}Grade: {grade}ID: {id}");
    }
}






