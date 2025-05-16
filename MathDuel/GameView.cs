using System;

public class GameView
{
    public void ShowWelcomeMessage()
    {
        Console.WriteLine("=== Math Duel ===");
        Console.WriteLine("Answer the math problems correctly!");
        Console.WriteLine("You can make up to 3 mistakes.\n");
    }

    public void ShowQuestion(string question)
    {
        Console.Write("Question: " + question + " ");
    }

    public int GetUserInput()
    {
        string input = Console.ReadLine();
        return int.TryParse(input, out int answer) ? answer : int.MinValue;
    }

    public void ShowCorrect()
    {
        Console.WriteLine("Correct!\n");
    }

    public void ShowWrong(int correctAnswer)
    {
        Console.WriteLine($"Wrong! The correct answer was {correctAnswer}.\n");
    }

    public void ShowGameOver(int score)
    {
        Console.WriteLine($"Game over! Your final score is: {score}");
    }
}
