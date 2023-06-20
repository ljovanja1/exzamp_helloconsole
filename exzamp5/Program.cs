Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "roman")
{
    Console.WriteLine("Ура, этоже Roma");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
