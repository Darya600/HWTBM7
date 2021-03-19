using System;
using System.Collections.Generic;
using System.Text;

namespace HWTBM7
{
    class User
    {   static string TextForUser = ("Добро пожаловать в игру!" + Environment.NewLine + "Пожалуйста сделайте свой выбор!" + Environment.NewLine +
                                     "1. Новая игра" + Environment.NewLine + "2. Загрузить игру" + Environment.NewLine + "Введите число:");
       
        static public int GetUserChoiseLoadSelect()
        {
            
            Console.Write(TextForUser);
            TextForUser = null;
            int UserSelect;
            try
            {
                UserSelect = int.Parse(Console.ReadLine());
                if(UserSelect>=1&UserSelect<=2) 
                {
                    return UserSelect;
                } else
                {
                    Console.WriteLine("Введите число 1 или 2!");
                    return GetUserChoiseLoadSelect();
                }
            }
            catch
            {
                Console.WriteLine("Введите число!");
                return GetUserChoiseLoadSelect();
            }
        }
        static public string GetNewUserName()
        {
            Console.Write("Введите свое имя:");
            string name;
            name = Console.ReadLine();
            if (name == "")
            {
              
               return GetNewUserName();
            }
            else
            {
                return name;   
            }
        }
        
        private string UserName;
        public User(string userName)
        {
            this.UserName = userName;
        }
        

    }
}
