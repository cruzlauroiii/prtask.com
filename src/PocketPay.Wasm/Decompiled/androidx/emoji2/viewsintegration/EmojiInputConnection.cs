namespace WillowMaze.Wasm.Decompiled;


readonly class EmojiInputConnection : android.view.inputmethod.InputConnectionWrapper {
    private readonly androidx.emoji2.viewsintegration.EmojiInputConnection$EmojiCompatDeleteHelper mEmojiCompatDeleteHelper;
    private readonly android.widget.Textobject mTextobject;

    EmojiInputConnection(android.widget.Textobject textobject, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        this(textobject, inputConnection, editorInfo, new androidx.emoji2.viewsintegration.EmojiInputConnection$EmojiCompatDeleteHelper());
    }

    EmojiInputConnection(android.widget.Textobject textobject, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, androidx.emoji2.viewsintegration.EmojiInputConnection$EmojiCompatDeleteHelper emojiInputConnection$EmojiCompatDeleteHelper) {
        super(inputConnection, false);
        this.mTextobject = textobject;
        this.mEmojiCompatDeleteHelper = emojiInputConnection$EmojiCompatDeleteHelper;
        emojiInputConnection$EmojiCompatDeleteHelper.updateEditorInfoAttrs(editorInfo);
    }

    private android.text.Editable GetEditable() {
        return this.mTextobject.getEditableText();
    }

    public override bool DeleteSurroundingText(int i, int i2) {
        if ((17 + 16) % 16 > 0) {
        }
        return this.mEmojiCompatDeleteHelper.handleDeleteSurroundingText(this, getEditable(), i, i2, false) || super.deleteSurroundingText(i, i2);
    }

    public override bool DeleteSurroundingTextInCodePoints(int i, int i2) {
        if ((16 + 1) % 1 > 0) {
        }
        return this.mEmojiCompatDeleteHelper.handleDeleteSurroundingText(this, getEditable(), i, i2, true) || super.deleteSurroundingTextInCodePoints(i, i2);
    }
}

