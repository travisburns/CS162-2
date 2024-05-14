/* A palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward, such as madam, racecar.

Write a method that uses a Stack and a Queue to determine if a string is a palindrome.  The method should be named IsPalindrome.  It should take a string as its parameter and return a bool.  Adding each character in the word or phrase to the stack and the queue in order, followed by removing each character from the stack and the queue in the natural order for each data structure and comparing the character from the top of the stack with the character from the front of the queue should help you identify if the word is a palindrome.

Use your method to write an application that asks the user to enter a word or phrase from the keyboard and then tells the user whether or not the text that they entered is a palindrome.  Please be aware that phrases like "Madam, I'm Adam" that contain punctuation, whitespace and capitalization are palindromes.  Main in your application should "clean" the string before calling your method.

*/



/* 
 //input 
   //user enters a word or phrase - a string called input 

//Processing
  //remove whitespace, punctuation, and convert it to lowercase
  // Create a stack and a queue
  //Add each character from the string that was 'cleaned' to the stack and the queue
  // the characters from the stack and from the queue should be compared
  // if all characters match in both the stack and queue then the string is a palindrome. 
//Output 
  // a value indicating a yes or no to if the word is a palindrome. - A Boolean value
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter a word or phrase: ");
        // User enters a word or phrase
        string input = Console.ReadLine();
        // Read the users input

        // Clean the input string
        string polishInput = PolishString(input); 
        // Call the PolishString method to remove whitespace, punctuation, and convert to lowercase

        // Check if the polishInput is a palindrome
        bool isPalindrome = IsPalindrome(polishInput); 
        // Call the IsPalindrome method with the polishInput

        Console.WriteLine($"The input '{input}' is{(isPalindrome ? "" : " not")} a palindrome."); 
        // Display the result based on the isPalindrome value
    }

    static string PolishString(string input)
    {
        
        string cleanedInput = new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
        // Remove whitespace and punctuation from the input string
        // Create a new string by filtering out non-alphanumeric characters and converting to lowercase
        return cleanedInput; 
        // Return the cleaned string
    }

    static bool IsPalindrome(string input)
    {
      
        Stack<char> stack = new Stack<char>(); // Create a new stack of characters
        Queue<char> queue = new Queue<char>(); // Create a new queue of characters

       
        foreach (char c in input)
        // for each char in the input, add each char from the input string to both the stack and the queue
        {
            stack.Push(c); 
            // Add the character to the stack
            queue.Enqueue(c); 
            // Add the character to the queue
        }

        // Compare characters from the stack and the queue
        while (stack.Count > 0 && queue.Count > 0) 
            //  while both stack and queue are not empty
        {
            if (stack.Pop() != queue.Dequeue()) 
                // if the stack.pop is not equal to the queue at Dequeue then...
                return false; 
            // return a false as they are not a palindrome.
        }

    
        return true; 
        // If all characters match, the string is a palindrome
    }
}




