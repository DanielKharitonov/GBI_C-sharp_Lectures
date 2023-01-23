// Дан текст. В тексте нужно все побелы 
// заменить черточками, маленькие буквы
// "к" заменить большими "К", а большие
// "С" заменить маленькими "с".

Console.Clear();

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "taxt"
//             1023
// s[3] // t

string Replace(string text, char oldValume, char newValume)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i=0;i<length;i++)
    {
        if (text[i] == oldValume) result = result + $"{newValume}";
        else result = result + $"{text[i]}";
    };

    return result;
}
string newText = Replace(text,' ','|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText,'к','К');
System.Console.WriteLine(newText);