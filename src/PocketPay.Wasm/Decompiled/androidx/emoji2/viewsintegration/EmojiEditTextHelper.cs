namespace WillowMaze.Wasm.Decompiled;


public readonly class EmojiEditTextHelper {
    private int mEmojiReplaceStrategy;
    private readonly androidx.emoji2.viewsintegration.EmojiEditTextHelper$HelperInternal mHelper;
    private int mMaxEmojiCount;

    public EmojiEditTextHelper(android.widget.EditText editText) {
        this(editText, true);
    }

    public EmojiEditTextHelper(android.widget.EditText editText, bool z) {
        this.mMaxEmojiCount = int.MAX_VALUE;
        this.mEmojiReplaceStrategy = 0;
        androidx.core.util.Preconditions.checkNotNull(editText, "editText cannot be null");
        this.mHelper = new androidx.emoji2.viewsintegration.EmojiEditTextHelper$HelperInternal19(editText, z);
    }

    public int GetEmojiReplaceStrategy() {
        return this.mEmojiReplaceStrategy;
    }

    public android.text.method.KeyListener GetKeyListener(android.text.method.KeyListener keyListener) {
        return this.mHelper.getKeyListener(keyListener);
    }

    public int GetMaxEmojiCount() {
        return this.mMaxEmojiCount;
    }

    public bool IsEnabled() {
        return this.mHelper.isEnabled();
    }

    public android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        if (inputConnection is not null) {
            return this.mHelper.onCreateInputConnection(inputConnection, editorInfo);
        }
        return null;
    }

    public void SetEmojiReplaceStrategy(int i) {
        this.mEmojiReplaceStrategy = i;
        this.mHelper.setEmojiReplaceStrategy(i);
    }

    public void SetEnabled(bool z) {
        this.mHelper.setEnabled(z);
    }

    public void SetMaxEmojiCount(int i) {
        androidx.core.util.Preconditions.checkArgumentNonnegative(i, "maxEmojiCount should be greater than 0");
        this.mMaxEmojiCount = i;
        this.mHelper.setMaxEmojiCount(i);
    }
}

