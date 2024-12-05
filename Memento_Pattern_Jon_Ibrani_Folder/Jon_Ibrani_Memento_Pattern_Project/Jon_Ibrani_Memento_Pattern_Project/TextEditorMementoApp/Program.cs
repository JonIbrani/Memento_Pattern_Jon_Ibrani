
namespace TextEditorMementoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor("Hello, World!");
            Caretaker caretaker = new Caretaker();
            string userInput;

            while (true)
            {
                DisplayMenu();
                userInput = System.Console.ReadLine();

                if (userInput == "1")
                {
                    System.Console.Write("Enter new text: ");
                    string newText = System.Console.ReadLine();
                    editor.SetText(newText);
                }
                else if (userInput == "2")
                {
                    caretaker.SaveState(editor);
                    System.Console.WriteLine("State saved.");
                }
                else if (userInput == "3")
                {
                    caretaker.Undo(editor);
                    System.Console.WriteLine("Undo complete.");
                }
                else if (userInput == "4")
                {
                    System.Console.WriteLine("Current text: ");
                    PrintText(editor.GetText());
                }
                else if (userInput == "5")
                {
                    System.Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }

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

        static void PrintText(char[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                System.Console.Write(text[i]);
            }
            System.Console.WriteLine();
        }
    }
}
