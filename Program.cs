// Свормировать массив из строк, и сделать отбор по колличеству символов = 3
int Long = 0;
Console.WriteLine("Ввелите строку ");
string arg = Console.ReadLine();

void FillArray(string[] massiv, string)
{
    for (int i = 0; i < massiv.Length; i++)
    {  
        massiv[i] = arg;
    }

}

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

string[] Massiv = new string [5];

FillArray(Massiv);
Console.WriteLine("введенные строки ");
PrintArray(Massiv);
LongString(Massiv, Long);

