using System;

public class GameModel
{
    private Random rand = new Random();
    public int Score { get; private set; }
    public int WrongAnswers { get; private set; }

    public bool GameOver => WrongAnswers >= 3;

    public (string question, int correctAnswer) GenerateQuestion()
    {
        int a = rand.Next(1, 11);
        int b = rand.Next(1, 11);
        int operation = rand.Next(3);

        int result;
        string question;

        switch (operation)
        {
            case 0:
                result = a + b;
                question = $"{a} + {b} = ?";
                break;
            case 1:
                result = a - b;
                question = $"{a} - {b} = ?";
                break;
            default:
                result = a * b;
                question = $"{a} * {b} = ?";
                break;
        }

        return (question, result);
    }

    public bool CheckAnswer(int userAnswer, int correctAnswer)
    {
        if (userAnswer == correctAnswer)
        {
            Score++;
            return true;
        }
        else
        {
            WrongAnswers++;
            return false;
        }
    }
}
