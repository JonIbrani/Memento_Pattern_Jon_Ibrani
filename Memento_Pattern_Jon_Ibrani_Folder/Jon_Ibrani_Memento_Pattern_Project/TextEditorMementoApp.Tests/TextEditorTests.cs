using TextEditorMementoApp;
using Xunit;

namespace TextEditorMementoApp.Tests
{
    public class TextEditorTests
    {
        [Fact]
        public void SetText_ShouldUpdateText()
        {
            // Arrange
            var editor = new TextEditor("Hello");

            // Act
            editor.SetText("New Text");

            // Assert
            Assert.Equal("New Text", new string(editor.GetText()));
        }

        [Fact]
        public void SaveState_ShouldSaveCurrentState()
        {
            // Arrange
            var editor = new TextEditor("Initial State");

            // Act
            var memento = editor.SaveState();

            // Assert
            Assert.Equal("Initial State", new string(memento.GetText()));
        }

        [Fact]
        public void RestoreState_ShouldRestorePreviousState()
        {
            // Arrange
            var editor = new TextEditor("First State");
            var memento = editor.SaveState();
            editor.SetText("Second State");

            // Act
            editor.RestoreState(memento);

            // Assert
            Assert.Equal("First State", new string(editor.GetText()));
        }

        [Fact]
        public void Undo_ShouldRevertToPreviousState()
        {
            // Arrange
            var editor = new TextEditor("Original State");
            var caretaker = new Caretaker();
            caretaker.SaveState(editor);

            editor.SetText("Modified State");

            // Act
            caretaker.Undo(editor);

            // Assert
            Assert.Equal("Original State", new string(editor.GetText()));
        }

        [Fact]
        public void Undo_ShouldDoNothingIfNoStateSaved()
        {
            // Arrange
            var editor = new TextEditor("No State Saved");
            var caretaker = new Caretaker();

            // Act
            caretaker.Undo(editor);

            // Assert
            Assert.Equal("No State Saved", new string(editor.GetText()));
        }
    }
}
