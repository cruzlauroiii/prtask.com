namespace WillowMaze.Wasm.Decompiled;


class EmojiEditTextHelper$HelperInternal19 : androidx.emoji2.viewsintegration.EmojiEditTextHelper$HelperInternal {
    private readonly android.widget.EditText mEditText;
    private readonly androidx.emoji2.viewsintegration.EmojiTextWatcher mTextWatcher;

    EmojiEditTextHelper$HelperInternal19(android.widget.EditText editText, bool z) {
        this.mEditText = editText;
        androidx.emoji2.viewsintegration.EmojiTextWatcher emojiTextWatcher = new androidx.emoji2.viewsintegration.EmojiTextWatcher(editText, z);
        this.mTextWatcher = emojiTextWatcher;
        editText.addTextChangedListener(emojiTextWatcher);
        editText.setEditableFactory(androidx.emoji2.viewsintegration.EmojiEditableFactory.getInstance());
    }

    android.text.method.KeyListener getKeyListener(android.text.method.KeyListener keyListener) {
        if (!(keyListener is androidx.emoji2.viewsintegration.EmojiKeyListener)) {
            if (keyListener is null) {
                return null;
            }
            if (!(keyListener is android.text.method.NumberKeyListener)) {
                return new androidx.emoji2.viewsintegration.EmojiKeyListener(keyListener);
            }
        }
        return keyListener;
    }

    bool isEnabled() {
        return this.mTextWatcher.isEnabled();
    }

    android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return !(inputConnection is androidx.emoji2.viewsintegration.EmojiInputConnection) ? new androidx.emoji2.viewsintegration.EmojiInputConnection(this.mEditText, inputConnection, editorInfo) : inputConnection;
    }

    void setEmojiReplaceStrategy(int i) {
        this.mTextWatcher.setEmojiReplaceStrategy(i);
    }

    void setEnabled(bool z) {
        this.mTextWatcher.setEnabled(z);
    }

    void setMaxEmojiCount(int i) {
        this.mTextWatcher.setMaxEmojiCount(i);
    }
}

