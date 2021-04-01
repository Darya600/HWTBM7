using System;

namespace HWTBM7
{
    class Program
    {
        static void Main(string[] args)
        {
            if (User.GetUserChoise(1,2, "Добро пожаловать в игру!!!!" + Environment.NewLine + "Пожалуйста сделайте свой выбор!" + Environment.NewLine +
                                     "1. Новая игра" + Environment.NewLine + "2. Загрузить игру" + Environment.NewLine + "Введите число:") == 1)
            {
                User newUser = new User(User.GetNewUserName());
                Game currentGame = new NewGame ();
                currentGame.StartGame(newUser);
            }
            else
            {
 
            }
        }
    }
}
