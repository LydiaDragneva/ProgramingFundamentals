string text = Console.ReadLine();
Console.WriteLine(GetVowesCount(text));
static int GetVowesCount (string text)
{
    int count = 0;

    for (int position = 0; position <= text.Length - 1; position++)
    {
        char symbol = text[position];  
        if (symbol ==  'A' || symbol =='a' 
          || symbol == 'E'|| symbol=='e' 
          || symbol == 'O' || symbol== 'o' 
          || symbol=='U' || symbol== 'u'
          || symbol == 'I' || symbol == 'i')
        {
            count++;
        }
    }
    return count;
}
