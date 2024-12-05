namespace TextEditorMementoApp
{
    // Memento class stores the state of the text.
    public class Memento
    {
        private readonly char[] _text; // Holds the saved state of the text.

        // Constructor creates a deep copy of the text array.
        public Memento(char[] text)
        {
            _text = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                _text[i] = text[i];
            }
        }

        // Returns the saved text state.
        public char[] GetText()
        {
            return _text;
        }
    }
}
