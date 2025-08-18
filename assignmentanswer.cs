using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // i) Temperature check using float literal
        float temperature = 36.6f;
        Console.WriteLine(temperature > 37.0f ? "Fever" : "Normal");

        // ii) Age check using int literal
        int age = 18;
        Console.WriteLine(age >= 18 ? "Eligible to Vote" : "Not Eligible");

        // iii) Gender using char literal
        char gender = 'M';
        if (gender == 'M') Console.WriteLine("Male");
        else if (gender == 'F') Console.WriteLine("Female");
        else Console.WriteLine("Other");

        // iv) Price calculation using double literals
        double price = 1000.0, discount = 10.0;
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: ₹" + finalPrice);

        // v) Bool literal for login
        bool loginSuccess = true;
        Console.WriteLine(loginSuccess ? "Login successful" : "Access denied");

        // vi) Print literals and their types
        int age2 = 25;
        float temp2 = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine($"Age: {age2}, Type: {age2.GetType()}");
        Console.WriteLine($"Temperature: {temp2}, Type: {temp2.GetType()}");
        Console.WriteLine($"Grade: {grade}, Type: {grade.GetType()}");
        Console.WriteLine($"Passed: {isPassed}, Type: {isPassed.GetType()}");

        // --------------------------
        // Calculator App for Kids
        // --------------------------
        int a = 10, b = 5;
        Console.WriteLine($"Total apples: {a + b}");
        Console.WriteLine($"Difference of pencils: {a - b}");
        Console.WriteLine($"Total pages: {a * b}");
        Console.WriteLine($"Chocolates per kid: {a / b}");
        Console.WriteLine($"Leftover candies: {a % b}");

        // --------------------------
        // Game Score Comparison
        // --------------------------
        int playerA = 20, playerB = 15;
        Console.WriteLine("Player A > Player B: " + (playerA > playerB));
        Console.WriteLine("Scores equal: " + (playerA == playerB));
        Console.WriteLine("Player A <= Player B: " + (playerA <= playerB));
        Console.WriteLine("Player B <= Player A: " + (playerB <= playerA));

        // --------------------------
        // Login System using Logical Operators
        // --------------------------
        string validUsername = "admin", validPassword = "1234";
        string username = "admin", password = "1234";

        bool login = (username == validUsername && password == validPassword);
        Console.WriteLine(login ? "Access Granted" : "Access Denied");
        Console.WriteLine("At least one valid? " + (username == validUsername || password == validPassword));
        Console.WriteLine("!Login: " + !login);

        // --------------------------
        // Student Quiz Score Updates
        // --------------------------
        int score = 50;
        Console.WriteLine("Start Score: " + score);

        score += 10; // Correct
        Console.WriteLine("After Correct: " + score);

        score -= 5; // Wrong
        Console.WriteLine("After Wrong: " + score);

        score *= 2; // Bonus
        Console.WriteLine("After Bonus: " + score);

        score /= 5; // Penalty
        Console.WriteLine("After Penalty: " + score);

        // --------------------------
        // Election Booth with Loop
        // --------------------------
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age of person " + i + ": ");
            int personAge = int.Parse(Console.ReadLine());
            Console.WriteLine(personAge >= 18 ? "Eligible to Vote" : "Not Eligible");
        }

        // --------------------------
        // ATM System with PIN (max 3 tries)
        // --------------------------
        const int correctPIN = 1234;
        int attempts = 0;
        bool pinSuccess = false;

        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            int enteredPIN = int.Parse(Console.ReadLine());

            if (enteredPIN == correctPIN)
            {
                Console.WriteLine("Access Granted");
                pinSuccess = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                attempts++;
            }
        }
        if (!pinSuccess) Console.WriteLine("Card Blocked");

        // --------------------------
        // Multiplication Table Generator
        // --------------------------
        string choice;
        do
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            Console.Write("Try another number? (Y/N): ");
            choice = Console.ReadLine().ToUpper();
        }
        while (choice == "Y");

        // --------------------------
        // Electricity Bill Calculator
        // --------------------------
        Console.Write("Enter units consumed: ");
        int units = int.Parse(Console.ReadLine());
        double bill = 0;

        if (units <= 100)
            bill = units * 2;
        else if (units <= 200)
            bill = 100 * 2 + (units - 100) * 3;
        else
            bill = 100 * 2 + 100 * 3 + (units - 200) * 5;

        Console.WriteLine("Total Bill: ₹" + bill);

        // --------------------------
        // Student Marks & Result
        // --------------------------
        int[] marks = new int[5];
        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        double average = marks.Average();
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine(average >= 40 ? "Passed" : "Failed");

        // --------------------------
        // Name Validation
        // --------------------------
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine(IsValidName(name) ? "Valid Name" : "Invalid Name");
    }

    static bool IsValidName(string name)
    {
        return Regex.IsMatch(name, @"^[A-Za-z\s]+$");
    }
}