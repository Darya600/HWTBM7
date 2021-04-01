using System;
using System.Collections.Generic;
using System.Text;

namespace HWTBM7
{
    abstract class  Game
    {
      
        public void StartGame(User user)
        {
         
            Questions [] question = CreateQuestionList();
            question[0].Answer = CreateAnswerList(3, "2020", 1,"2021", 4,"2022", 2,"2019");
            question[1].Answer = CreateAnswerList(1, "December", 3, "April", 2, "October", 4, "November");
            question[2].Answer = CreateAnswerList(4, "22", 3, "21", 2, "23", 1, "20");
            Console.WriteLine("Игра начинается ознакомьтесь с правилами!"+Environment.NewLine+  
                           " пт. 1 - для начала игры вы должны внести свое имя; " + Environment.NewLine +
                           " пт. 2 - после начала игры вам предложен ограниченный перечень вопросов по очереди; " + Environment.NewLine +
                           " пт. 3 - для каждого вопроса предоставляется 4 варианта ответа; " + Environment.NewLine +
                           " пт. 4 - для на вопрос ответа номер в числовом представлении, н.п. '1'; " + Environment.NewLine +
                           " пт. 5 - выбор при верного ответа на вопрос выйгрыш приумножается х 2, по выбору пользователя " + Environment.NewLine +
                           " при помощи комманды 'Продолжить игру' игра может быть продолжена или завершена при вооде комманды 'Завершить игру'; " + Environment.NewLine +
                           " пт. 6 - выбор при не верного ответа на вопрос, игра окончена, выйгрыш = 0; "  +Environment.NewLine +
                           " пт. 7 - при условии верного ответа на все вопросы или при вооде комманды 'Завершить игру' игрок Выйграл и может забрать свои средства. ");
           
            GameCycle(question, user);
        }
        private void GameCycle(Questions [] question, User user)
        {
            for (int numberQuestion=user.UserQuestionNumber;numberQuestion<=2; numberQuestion++)
            {
                Console.WriteLine(question[numberQuestion].QuestionText);

                for (int number = 1; number <= 4; number++)
                {
                   for(int count = 0; count < question[numberQuestion].Answer.Length ; count++)
                    {
                        if (question[numberQuestion].Answer[count].AnswerNumber == number)
                        {
                            Console.WriteLine(question[numberQuestion].Answer[count].AnswerNumber+". "+ question[numberQuestion].Answer[count].AnswerText);
                        }
                    }
                   
                }
                if (question[numberQuestion].Answer[User.GetUserChoise(1, 4, "Введите номер верного ответа")-1] is CorrectAnswer)
                {
                    Console.WriteLine("LOVE");
                }
                else
                Console.WriteLine("FUCK");

            }
        }
        private  Questions [] CreateQuestionList()
                {
                Questions [] question = new Questions[3];
                question[0] = new Questions("This year is....");
                question[1] = new Questions("This month is...");
                question[2] = new Questions("This century is...");
                return question;
                }
        private Answers [] CreateAnswerList(int answerNumber1, string answer1, int answerNumber2, string answer2,
                                            int answerNumber3, string answer3, int answerNumber4, string answer4)
        {
           Answers [] Answer= new Answers[4];
           Answer[0] = new WrongAnswer(answerNumber1, answer1);
           Answer[1] = new CorrectAnswer(answerNumber2, answer2);
           Answer[2] = new WrongAnswer(answerNumber3, answer3);
           Answer[3] = new WrongAnswer(answerNumber4, answer4);
            return Answer;
        }
        
    }
    class NewGame : Game
    {
       
    }
    class LoadGame: Game
    {

    }
}
