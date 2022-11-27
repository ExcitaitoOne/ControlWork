// Свормировать массив из строк, и сделать отбор по 3 первым символам
int Long = 0;
void FillArray(string[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {

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
        Console.WriteLine($"Колличество букв {massiv[i]} = " + Long);
    }
}




string[] Massiv = new string[5] { "asd", "dddddd", "asddf", "asdq", "asdqe1" };

PrintArray(Massiv);
LongString(Massiv, Long);