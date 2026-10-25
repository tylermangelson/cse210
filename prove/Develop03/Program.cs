using System;

// Scripture: reference, words
// Above and beyond: hide hidden words
// can hard code scripture
// Classes: program, word, scripture_reference, scripture

// Reference.cs (new file)

// Create the Reference class with _book, _chapter, _startVerse, _endVerse.
// Write the 4-argument constructor (verse range).
// Write the 3-argument constructor (single verse), and set _endVerse to match _startVerse.
// Write DisplayReference() to print something like “Moses 1:39” or “Moses 1:38-39”.

// Scripture.cs
// 5. Add the _reference field.
// 6. In the single-verse constructor, create the Reference and call ConvertToWords(text).
// 7. Fill in the range constructor: create the Reference and set _words (it’s empty now and would crash).
// 8. Update ShowScripture() to display the reference first, then the words.
// 9. Write HideWords(): hide three random words that aren’t hidden yet, and return false when everything is already hidden.

// Program.cs
// 10. Delete the “Hello” test code.
// 11. Add a loop: show the scripture, wait for Enter, hide words, repeat.
// 12. Type “quit” to exit, and stop automatically when HideWords() returns false.
// 13. Call Console.Clear() at the start of each loop pass.
class Program
{
    static void Main(string[] args)
    {

        Scripture myScripture = new Scripture("James", 1, 39, 40, "Every good gift and every perfect gift is from above, and cometh down from the Father of lights, with whom is no variableness, neither shadow of turning. Of his own will begat he us with the word of truth, that we should be a kind of firstfruits of his creatures.");

        while (true)
        {
            Console.Clear();
            myScripture.ShowScripture();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to hid words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            if (!myScripture.HideWords())
            {
                break;
            
            }



        }


        Console.Clear();


    }
}

