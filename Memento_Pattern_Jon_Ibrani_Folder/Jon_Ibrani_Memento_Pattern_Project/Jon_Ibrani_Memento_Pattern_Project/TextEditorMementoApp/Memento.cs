namespace TextEditorMementoApp
{
    public class Memento
    {
        private readonly char[] _text;

        public Memento(char[] text)
        {
            _text = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                _text[i] = text[i];
            }
        }

        public char[] GetText()
        {
            return _text;
        }
    }
}
