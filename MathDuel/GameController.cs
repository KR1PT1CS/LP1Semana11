public class GameController
{
    private GameModel model;
    private GameView view;

    public GameController()
    {
        model = new GameModel();
        view = new GameView();
    }

    public void Run()
    {
        view.ShowWelcomeMessage();

        while (!model.GameOver)
        {
            var (question, correctAnswer) = model.GenerateQuestion();
            view.ShowQuestion(question);
            int playerAnswer = view.GetUserInput();

            if (playerAnswer == int.MinValue)
            {
                Console.WriteLine("Invalid input. Try again.\n");
                continue;
            }

            bool isCorrect = model.CheckAnswer(playerAnswer, correctAnswer);
            if (isCorrect)
                view.ShowCorrect();
            else
                view.ShowWrong(correctAnswer);
        }

        view.ShowGameOver(model.Score);
   }
}
