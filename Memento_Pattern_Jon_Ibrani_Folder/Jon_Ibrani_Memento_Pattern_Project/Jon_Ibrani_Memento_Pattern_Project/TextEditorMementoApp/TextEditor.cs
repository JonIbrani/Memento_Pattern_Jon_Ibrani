
namespace TextEditorMementoApp
{
    public class TextEditor : ITextEditor
    {
        private char[] _text;

        public TextEditor(string initialText)
        {
            _text = new char[initialText.Length];
            for (int i = 0; i < initialText.Length; i++)
            {
                _text[i] = initialText[i];
            }
        }

        public void SetText(string newText)
        {
            _text = new char[newText.Length];
            for (int i = 0; i < newText.Length; i++)
            {
                _text[i] = newText[i];
            }
        }

        public char[] GetText()
        {
            return _text;
        }

        public Memento SaveState()
        {
            return new Memento(_text);
        }

        public void RestoreState(Memento memento)
        {
            _text = memento.GetText();
        }
    }
}
