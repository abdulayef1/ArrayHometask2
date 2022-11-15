Console.WriteLine("input length:");
int length = int.Parse(Console.ReadLine());
int[] numbers= new int[length];
int sumOfEvens = 0;

for (int i = 0; i < length; i++)
{
    Console.WriteLine("intput "+(i+1)+". number:");
    numbers[i]=int.Parse(Console.ReadLine());


    if (numbers[i]%2==0)
    {
        sumOfEvens += numbers[i];
    }
}

Console.WriteLine("Sum of even numbers:"+sumOfEvens);

