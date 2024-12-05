namespace TextEditorMementoApp
{
    // The main entry point for the Text Editor application
    class Program
    {
        static void Main(string[] args)
        {
            // Create a text editor with initial content
            TextEditor editor = new TextEditor("Hello, World!");
            
            // Create a Caretaker to manage the editor's state
            Caretaker caretaker = new Caretaker();
            string userInput;

            // Run the application in a loop to allow multiple operations
            while (true)
            {
                // Display the menu options to the user
                DisplayMenu();
                
                // Get user input for the selected operation
                userInput = System.Console.ReadLine();

                if (userInput == "1") // Option to set new text in the editor
                {
                    System.Console.Write("Enter new text: ");
                    string newText = System.Console.ReadLine();
                    editor.SetText(newText);
                }
                else if (userInput == "2") // Option to save the current state
                {
                    caretaker.SaveState(editor);
                    System.Console.WriteLine("State saved.");
                }
                else if (userInput == "3") // Option to undo to the last saved state
                {
                    caretaker.Undo(editor);
                    System.Console.WriteLine("Undo complete.");
                }
                else if (userInput == "4") // Option to display the current text
                {
                    System.Console.WriteLine("Current text: ");
                    PrintText(editor.GetText());
                }
                else if (userInput == "5") // Option to exit the application
                {
                    System.Console.WriteLine("Exiting...");
                    break;
                }
                else // Handle invalid input
                {
                    System.Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }

        // Displays the menu options to the user
        static void DisplayMenu()
        {
            System.Console.WriteLine("\nText Editor - Memento Pattern");
            System.Console.WriteLine("1. Set Text");
            System.Console.WriteLine("2. Save State");
            System.Console.WriteLine("3. Undo");
            System.Console.WriteLine("4. Display Text");
            System.Console.WriteLine("5. Exit");
            System.Console.Write("Choose an option: ");
        }

        // Prints the current text in the editor
        static void PrintText(char[] text)
        {
            // Iterate over the character array and print each character
            for (int i = 0; i < text.Length; i++)
            {
                System.Console.Write(text[i]);
            }
            System.Console.WriteLine(); // Move to the next line after printing
        }
    }
}
