Console. Write("Введите имя пользователья:");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.Write("Ура, это же MASHA!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}