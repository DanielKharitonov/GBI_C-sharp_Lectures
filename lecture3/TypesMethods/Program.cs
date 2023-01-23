// Вид 1 'Ничего не принимают, ничего не возвращают'
void Method1()
{
    System.Console.WriteLine("Автор ...");
}
// Как вызвать?
Method1();

// Вид 2 'Ничего не принимают, что-то возвращают'
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Как вызывать?
// Method2(msg: "Текст сообщения");
// Еще вариант
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
// Как вызвать?
// Method2("Text", 4);
// или
Method2(msg: "Tekst", count: 5);

// ВИД 3 'Ничего не принмиает, что-то возвращает'
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// ВИД 4 'Что-то принимает, что-то возвращает'
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "bom! ");
System.Console.WriteLine(res);
