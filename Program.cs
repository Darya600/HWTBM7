﻿using System;

namespace HWTBM7
{
    class Program
    {
        static void Main(string[] args)
        {
            if (User.GetUserChoiseLoadSelect() == 1)
            {
                User newUser = new User(User.GetNewUserName());
                GameNew currentGame = new GameNew ();
                currentGame.StartGame();
            }
            else
            {
 
            }
        }
    }
}