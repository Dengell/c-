Console.Clear();

bool CheckIfAnagram(string word1, string word2)
{
    string newWord1 = RemoveNonLetters(word1);
    string newWord2 = RemoveNonLetters(word2);

    if(newWord1.Length != newWord2.Length) return false;

    char[] chars1 = newWord1.ToLower().ToCharArray();
    char[] chars2 = newWord2.ToLower().ToCharArray();

    AlphabeticalSort(chars1);
    AlphabeticalSort(chars2);

    return chars1.SequenceEqual(chars2);
}

string RemoveNonLetters(string input)
{
    string output = "";

    for (int i = 0; i < input.Length; i++)
    {
        if(char.IsLetter(input[i]))
        {
            output += input[i];
        }
    }

    return output;
}

void AlphabeticalSort(char[] input)
{
    for(int i = 0; i < input.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i+1; j < input.Length; j++)
        {
            if(input[j] < input[minPosition])
            {
                minPosition = j;
            }
        }

        if(minPosition != i)
        {
           char temp = input[i];
           input[i] = input[minPosition];
           input[minPosition] = temp; 
        }
    }
}

// void ReverseAlphabeticalSort(char[] input)
// {
//     for(int i = 0; i < input.Length - 1; i++)
//     {
//         int maxPosition = i;

//         for(int j = i+1; j < input.Length; j++)
//         {
//             if(input[j] < input[maxPosition])
//             {
//                 maxPosition = j;
//             }
//         }

//         if(maxPosition != i)
//         {
//            char temp = input[i];
//            input[i] = input[maxPosition];
//            input[maxPosition] = temp; 
//         }
//     }
// }

string fWord1 = "I am Lord Voldemort";
string sWord1 = "Tom Marvolo Riddle";

string fWord2 = "рама";
string sWord2 = "мара";

string fWord3 = "лорд Волран-де-Морт";
string sWord3 = "Том Марволо Реддл";

string result1 = CheckIfAnagram(fWord1, sWord1) ? "Да" : "Нет";
string result2 = CheckIfAnagram(fWord2, sWord2) ? "Да" : "Нет";
string result3 = CheckIfAnagram(fWord3, sWord3) ? "Да" : "Нет";

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);