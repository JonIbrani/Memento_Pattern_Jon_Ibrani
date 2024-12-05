namespace TextEditorMementoApp
{
    public interface ITextEditor
    {
        void SetText(string newText);
        char[] GetText();
        Memento SaveState();
        void RestoreState(Memento memento);
    }
}
