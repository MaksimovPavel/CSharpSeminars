//Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
void SortStrings(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length ; i++)
    {
        if (words[i][0] == 'a' || words[i][0] == 'i' || words[i][0] == 'e' || words[i][0] == 'o' || words[i][0] == 'u' || words[i][0] == 'y')count++;
    }
    Console.Write(count);
}

string[] names = {"ave", "emperor", "of", "united", "independent", "yard"};
SortStrings(names);
*/

//Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно
string [] SortStrings(string[] words)
{
    for (int i = 0; i < words.Length ; i+=2)
    {
        words[i] = words[i] + words[i+1];
    }
    return words;
}

string[] names = { "qwe", "wer", "ert", "rty", "tyu", "yui"};
SortStrings(names);
for (int i = 0; i < names.Length; i+=2)
{
    Console.Write(names[i] + " ");
}