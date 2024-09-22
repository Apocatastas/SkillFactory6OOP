using System;

class Program
{

    class User
    {
        private int age;
        private string login;
        private string email;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть минимум 3 символа");
                }
                else
                {
                    login = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Адрес email должен содержать знак @");
                }
                else
                {
                    login = value;
                }
            }
        }
    }


    public static void Main(string[] args)
    {

    } 
}
