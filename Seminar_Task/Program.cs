Console.WriteLine("Введите число");
double number = double.Parse(Console.ReadLine());
int pow = Convert.ToInt32(Math.Log(number, 2));

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