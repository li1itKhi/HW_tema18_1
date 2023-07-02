string[] arr = { "уже", "идет", "второй", "месяц", "лета"};
string my_word;
bool isTrue = true;
string choise;

while (isTrue)
{
    Console.Write("Введите ваше слово: ");
    my_word = Console.ReadLine();

    for(int i=0; i<arr.Length; i++)
    {
        if (arr[i] == my_word)
        {
            arr[i] = "скрыто";
        }
        else Console.WriteLine("совпадений не найдено");
    }

    Console.Write("Далее/Конец? ");
    choise = Console.ReadLine();
    if(choise == "конец")
    {
        isTrue = false;
        for(int i=0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }
    else if(choise=="далее") isTrue = true;
}