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
        Word myWord = new Word ("Hello");
        myWord.Display();
        myWord.Hide();
        Console.WriteLine();
        myWord.Display();

        Scripture myScripture = new Scripture("Moses", 1, 39, "Behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.");
        Console.Clear();
        myScripture.ShowScripture();
    }
}