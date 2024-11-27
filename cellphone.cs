using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, string> KEYPAD = new Dictionary<char, string>
    {
        { '1', "&'(" },
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " " }
    };

    static string OldPhonePad(string input)
    {
        string result = "";
        int count = 0;
        char? current = null;

        if (input[input.Length-1] != '#')
        {
            input += "#";
        }

        for (int i=0; i<input.Length; i++)
        {
            char key = input[i];

            if (key == '#')
            {
                if (current.HasValue)
                {
                    result += ExtractLetter(current.Value, count);
                }
                break;
            }

            if (key =='*')
            {
                count = 0;
                current = null;
                continue;
            }

            if (key == '0')
            {
                count = 0;
                current = null;
                result += " ";
                continue;
            }

            if (current == null)
            {
                current = key;
                count++;
            }
            else if (current ==key)
            {
                count++;
            }
            else
            {
                result += ExtractLetter(current.Value, count);
                current = key;
                count = 1;
            }
        }

        return result;
    }

    static string ExtractLetter(char current, int count)
    {
        if (!KEYPAD.ContainsKey(current))
        {
            return ""; 
        }

        string keyCharacters = KEYPAD[current];

        if (count > keyCharacters.Length)
        {
            count = count % keyCharacters.Length;
        }

        return keyCharacters[count - 1].ToString();
    }

    static void Main()
    {
        Console.WriteLine(OldPhonePad("33#"));
        Console.WriteLine(OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#")); 
    }
}

