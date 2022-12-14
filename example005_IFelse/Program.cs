Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("УРА МАША");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}