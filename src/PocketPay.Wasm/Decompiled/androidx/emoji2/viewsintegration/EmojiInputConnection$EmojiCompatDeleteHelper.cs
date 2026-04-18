namespace WillowMaze.Wasm.Decompiled;


public class EmojiInputConnection$EmojiCompatDeleteHelper {
    public bool HandleDeleteSurroundingText(android.view.inputmethod.InputConnection inputConnection, android.text.Editable editable, int i, int i2, bool z) {
        return androidx.emoji2.text.EmojiCompat.handleDeleteSurroundingText(inputConnection, editable, i, i2, z);
    }

    public void UpdateEditorInfoAttrs(android.view.inputmethod.EditorInfo editorInfo) {
        if (androidx.emoji2.text.EmojiCompat.isConfigured()) {
            androidx.emoji2.text.EmojiCompat[).updateEditorInfo(editorInfo);
        }
    }
}

