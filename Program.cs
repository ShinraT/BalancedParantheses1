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
            string _input = Console.ReadLine();

            Stack<char> _stack = new Stack<char>();

            for (int i = 0; i < _input.Length; i++)
            {

                //Default case if it is not a valid input, we will break the loop and return 0
                if (_input[i] != '(' && _input[i] != ')' && _input[i] != '[' && _input[i] != ']')
                {
                    Console.WriteLine("Invalid input. Please enter only '(', ')', '[' or ']'.");
                    isBalanced = false;
                    break;
                }

                // Check if the _input variable is "(" 0r "["
                //because we dont need to check if it is "]" or ")", 
                if (_input[i] == '(' || _input[i] == '[')
                {
                    _stack.Push(_input[i]);
                    continue;
                }

                // Only need to check with the further iterations if it is a right sided parantheses.
                if (_input[i] == ')')
                {
                    if (_stack.Count == 0 || _stack.Peek() != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                    //pop the stack to make it a clean slate for the next iteration
                    _stack.Pop();
                }

                // Only need to check with the further iterations if it is a right sided square bracket. 
                if (_input[i] == ']')
                {
                    if (_stack.Count == 0 || _stack.Peek() != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                    //pop the stack to make it a clean slate for the next iteration
                    _stack.Pop();
                }


            }
            if (_stack.Count > 0)
            {
                isBalanced = false;
            }

            Console.WriteLine(isBalanced ? "1" : "0");
        }
    }
}