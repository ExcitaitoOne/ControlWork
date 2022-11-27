// Свормировать массив из строк, и сделать отбор по колличеству символов = 3
int Long = 0;
void PrintArray(string[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.WriteLine(" " + massiv[i]);
    }
}

void LongString(string[] massiv, int Long)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Long = massiv[i].Length;
        if (Long <= 3){
        Console.WriteLine($" {massiv[i]}" );
        }
    }
}

string[] Massiv = new string [5] {"String", "int", "bool", "Longint", " 1" };

Console.WriteLine("введенные строки ");
PrintArray(Massiv);
Console.WriteLine("Строки состоящие из 3 символов и менее ");
LongString(Massiv, Long);

