string[] mass1 = ["Hgggo", "2", "ld", ":-)"];
int size_mass2 = 0;

for (int i = 0; i < mass1.Length; i++)
{
    if (mass1[i].Length <= 3)
    {
        size_mass2 = size_mass2 += 1;
    }
}
