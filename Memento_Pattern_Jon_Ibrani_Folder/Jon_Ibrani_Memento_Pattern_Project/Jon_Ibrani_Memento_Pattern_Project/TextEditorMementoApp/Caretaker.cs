namespace TextEditorMementoApp
{
    public class Caretaker
    {
        private Memento _memento;

        public void SaveState(ITextEditor editor)
        {
            _memento = editor.SaveState();
        }

        public void Undo(ITextEditor editor)
        {
            if (_memento != null)
            {
                editor.RestoreState(_memento);
                _memento = null;
            }
        }
    }
}
