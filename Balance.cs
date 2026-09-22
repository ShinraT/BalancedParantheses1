using System;
using System.Collections.Generic;

class Balance
{

    public static void Main()
    {
        bool isBalanced = true;
        while (true)
        {

            Console.Write("Enter '( )' or '[ ]' combination: ");
            string s = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {

                //Default case if it is not a valid input, we will break the loop and return 0
                if (s[i] != '(' && s[i] != ')' && s[i] != '[' && s[i] != ']')
                {
                    Console.WriteLine("Invalid input. Please enter only '(', ')', '[' or ']'.");
                    isBalanced = false;
                    break;
                }

                // Check if the _input variable is "(" 0r "["
                //because we dont need to check if it is "]" or ")", 
                if (s[i] == '(' || s[i] == '[')
                {
                    stack.Push(s[i]);
                    continue;
                }

                // Only need to check with the further iterations if it is a right sided parantheses.
                if (s[i] == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                    //pop the stack to make it a clean slate for the next iteration
                    stack.Pop();
                }

                // Only need to check with the further iterations if it is a right sided square bracket. 
                if (s[i] == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                    //pop the stack to make it a clean slate for the next iteration
                    stack.Pop();
                }


            }
            if (stack.Count > 0)
            {
                isBalanced = false;
            }

            Console.WriteLine(isBalanced ? "1" : "0");
        }
    }
}