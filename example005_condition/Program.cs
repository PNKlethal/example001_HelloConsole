Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower == "яна")
{
    Console.WriteLine ("Я тебя люблю!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}