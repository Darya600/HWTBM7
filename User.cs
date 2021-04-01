using System;
using System.Collections.Generic;
using System.Text;

namespace HWTBM7
{
    class User
    {
        static public int GetUserChoise(int numberMin, int numberMax, string Text=null)
        {

            Console.Write(Text);
            Text = null;
            int UserSelect;
            try
            {
                UserSelect = int.Parse(Console.ReadLine());
                if (UserSelect >= numberMin & UserSelect <= numberMax)
                {
                    return UserSelect;
                } else
                {
                    Console.WriteLine("Введите число!");
                    return GetUserChoise(numberMin,numberMax);
                }
            }
            catch
            {
                Console.WriteLine("Введите число!");
                return GetUserChoise(numberMin, numberMax);
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


        public string UserName
        { get;
            private set;
        }
        public int UserQuestionNumber
        {
            get;
            private set;

        }
        public int UserScore
        { get;
          private set;
        }
        public User(string userName)
        {
            this.UserName = userName;
            this.UserQuestionNumber = 0;
            this.UserScore = 0;
        }
    }
}
