
using System.Security.Cryptography;

namespace RandomNumber;
public class Random
{
    public static byte[] GenerateRandomNumbers(int length)
    {
        using var randomNumberGenerator = RandomNumberGenerator.Create();

        byte[] randomNumber = new byte[length];
        randomNumberGenerator.GetBytes(randomNumber);
        return randomNumber;

    }
}
