namespace modules_4._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string surename, string login, int loginLenght, bool havePet, int age, string[] favColor) user;
            bool end = true;
            for (int j = 0; j < 3; j++) 
            {


                Console.WriteLine("Введите имя");
                user.name = Console.ReadLine();



                Console.WriteLine("Введите фамилию");
                user.surename = Console.ReadLine();

                Console.WriteLine("Введите логин");
                user.login = Console.ReadLine();
                user.loginLenght = user.login.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                switch (Console.ReadLine().ToLower())
                {
                    case "да":
                        user.havePet = true;
                        break;
                    case "нет":
                        user.havePet = false;
                        break;
                    default:
                        user.havePet = false;
                        break;

                }
                Console.WriteLine("Введите возраст пользователя");
                user.age = Convert.ToInt32(Console.ReadLine());
                user.favColor = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < user.favColor.Length; i++)
                    user.favColor[i] = Console.ReadLine();
            }
        }
    }
}
