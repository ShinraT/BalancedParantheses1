using System;
using System.Collections.Generic;

class Balance
{

    public static void Main()
    {
        bool isBalanced = true;

        string s = Console.ReadLine();

        Stack<char> stack = new Stack<char>();
        if(s.Length > 100)
        {
            isBalanced = false;
            Console.WriteLine(isBalanced ? "1" : "0");
            return;
        }

        for (int i = 0; i < s.Length; i++)
        {
            // Standardfall om det inte är en giltig input
            if (s[i] != '(' && s[i] != ')' && s[i] != '[' && s[i] != ']')
            {
                isBalanced = false;
                break;
            }

            // Öppna paranteser eller brackets pusha på stacken.
            if (s[i] == '(' || s[i] == '[')
            {
                stack.Push(s[i]);
                continue;
            }

            // Stängande parentes
            if (s[i] == ')')
            {
                if (stack.Count == 0 || stack.Peek() != '(')
                {
                    isBalanced = false;
                    break;
                }

                stack.Pop();
            }

            // Stängande bracket 
            if (s[i] == ']')
            {
                if (stack.Count == 0 || stack.Peek() != '[')
                {
                    isBalanced = false;
                    break;
                }

                stack.Pop();
            }
        }

        // Om något finns kvar på stacken,
        // finns det obalanserade öppningsparenteser eller brackets.
        if (stack.Count > 0)
        {
            isBalanced = false;
        }

        Console.WriteLine(isBalanced ? "1" : "0");
    }
}
