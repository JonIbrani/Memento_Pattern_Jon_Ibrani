namespace TextEditorMementoApp
{
    // The Caretaker class is responsible for managing the Memento object
    public class Caretaker
    {
        // Holds the memento that represents a saved state
        private Memento _memento;

        // Saves the current state of the text editor into a memento
        public void SaveState(ITextEditor editor)
        {
            _memento = editor.SaveState();
        }

        // Restores the text editor to its last saved state
        public void Undo(ITextEditor editor)
        {
            // Check if there is a saved state to restore
            if (_memento != null)
            {
                editor.RestoreState(_memento);
                // Clear the memento after restoring the state
                _memento = null;
            }
        }
    }
}
