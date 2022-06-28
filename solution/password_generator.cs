using System;
using System.Text;
 
public class Example
{
    public static string GetRandomPassword(int length)
    {
        const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
 
        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();
 
        for (int i = 0; i < length; i++)
        {
            int index = rnd.Next(chars.Length);
            sb.Append(chars[index]);
        }
 
        return sb.ToString();
    }
 
    public static void Main()
    {
        int length = 10;
 
        string password = GetRandomPassword(length);
        Console.WriteLine(password);
    }
}
 
/*
    Output: 3Dn6V7dK48
*/
