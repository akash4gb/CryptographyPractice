using Random = RandomNumber.Random;

Console.WriteLine("Random number generator:");

for (int i = 0; i < 11; i++)
{
    Console.WriteLine($"{i}. {Convert.ToBase64String(Random.GenerateRandomNumbers(32))}");
}
