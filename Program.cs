string[] mass1 = ["Hgggo", "2255", "lн25", ":-)5", "dddн"];
int size_mass2 = 0;

for (int i = 0; i < mass1.Length; i++)
{
    if (mass1[i].Length <= 3)
    {
        size_mass2 = size_mass2 += 1;
    }
}

string[] mass2 = new string[size_mass2];
int j = 0; // счетчик индекса для mass2
if (size_mass2 == 0)
{
    Console.WriteLine($"В массиве нет строк меньше или равной трем");
}
else
{
    for (int i = 0; i < mass1.Length; i++)
    {
        if (mass1[i].Length <= 3)
        {
            mass2[j] = mass1[i];
            j += 1;
        }
    }
Console.WriteLine($"Изначальный массив: [ {string.Join("; ", mass1)} ]");
Console.WriteLine($"В масиве {size_mass2} элемент(а) с заданным условием: [ {string.Join("; ", mass2)} ]");
}



