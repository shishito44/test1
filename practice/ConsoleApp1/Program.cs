// See https://aka.ms/new-console-template for more information
Console.WriteLine("オウム返しをするプログラム（finで終了）");
while (true)
{
    string? str = Console.ReadLine();
    if (str == string.Empty)
    {
        Console.WriteLine("文字を入力してください");
    }
    else if (str == "fin")
    {
        Console.WriteLine("終了");
        break;
    }
    Console.WriteLine(str);
}
