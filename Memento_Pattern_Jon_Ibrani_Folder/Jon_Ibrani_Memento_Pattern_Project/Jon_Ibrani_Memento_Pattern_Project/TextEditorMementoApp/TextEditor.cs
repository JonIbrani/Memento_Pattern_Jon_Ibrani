namespace TextEditorMementoApp
{
    // Represents a text editor that supports saving and restoring state
    public class TextEditor : ITextEditor
    {
        // Internal storage for the text as a character array
        private char[] _text;

        // Constructor to initialize the text editor with initial content
        public TextEditor(string initialText)
        {
            // Copy each character from the initial text to the internal array
            _text = new char[initialText.Length];
            for (int i = 0; i < initialText.Length; i++)
            {
                _text[i] = initialText[i];
            }
        }

        // Updates the editor's text with new content
        public void SetText(string newText)
        {
            // Create a new character array for the updated text
            _text = new char[newText.Length];
            for (int i = 0; i < newText.Length; i++)
            {
                _text[i] = newText[i];
            }
        }

        // Retrieves the current text from the editor
        public char[] GetText()
        {
            return _text;
        }

        // Saves the current state of the editor into a Memento object
        public Memento SaveState()
        {
            return new Memento(_text);
        }

        // Restores the editor's state from the provided Memento
        public void RestoreState(Memento memento)
        {
            _text = memento.GetText();
        }
    }
}
