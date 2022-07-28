string text = "- ну так вот, сейчас я тут пишу какой-то текст и потом буду вносить в него изменения.";

string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i]== oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'о', 'О');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'е', 'Е');
Console.WriteLine(newText);