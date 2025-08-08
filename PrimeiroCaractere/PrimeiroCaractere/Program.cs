using System;
using System.Linq;

public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        foreach (char letra in s)
        {
            int count = s.Count(x => char.ToLower(x) == char.ToLower(letra));
            if (count == 1)
                return letra.ToString();
        }

        return "";
    }
}


