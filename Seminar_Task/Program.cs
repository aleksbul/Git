Console.WriteLine("Введите число");
double number = double.Parse(Console.ReadLine());
int pow = 0;

// pow - степень числа 2 при которой значение 2 в степени pow максимально близко к заданному числу, но не больше его.

for (int i = 0; Math.Pow(2, i) <= number; i++)
{
    pow = i;
}

int size = pow + 1;
int[] array = new int[size];


for (int i = 0; i < size; i++)
{
    if (number >= Math.Pow(2, pow))
    {
        array[i] = 1;
        number = number - Math.Pow(2, pow);
    }
    else array[i] = 0;    
    pow = pow - 1;
}

Console.WriteLine($"{String.Join("", array)}");