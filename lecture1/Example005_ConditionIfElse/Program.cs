Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша") // Оператор .ToLover() все символы в строке будут переведены в нижний регистр
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write($"Привет, {username}! ");
}