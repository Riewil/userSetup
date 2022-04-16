namespace userprofil
{
    using System;
    class User 
    {
        public string firstName;
        public string lastName;
        public int age;
        public string gender;
    }
    class Program
    {
        static User GetUser()
        {
            var user = new User();
            Console.WriteLine("Введите имя:");
            user.firstName = Console.ReadLine();    
            Console.WriteLine("Введите фамилию:");
            user.lastName = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            user.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите пол:\n1.Мужчина\n2.Женщина\n3.Другой");
            int choice = int.Parse(Console.ReadLine());    
            switch(choice)
            {
                case 1:
                    user.gender = "Мужчина";
                    break;
                case 2:
                    user.gender = "Посудомойка";
                    break;
                case 3:
                    Console.WriteLine("Че особенн(ая/ый) дохуя? Иди нахуй выбери нормальный пол уебище\n1.Мужчина\n2.Женщина");
                    choice = int.Parse(Console.ReadLine());
                    if(choice == 1)
                    {
                        goto case 1;
                    }
                    else 
                    {
                        goto case 2;
                    } 
                    break;
            }       
            return user;
        }
        static void Print(User user)
        {
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine($"Вас зовут {user.firstName} {user.lastName} вам {user.age} лет, ваш пол  {user.gender}");
        }    
        static void Main(string[] args) 
        {
            var firstUser = GetUser(); 
            Print(firstUser);
        }
    }
}