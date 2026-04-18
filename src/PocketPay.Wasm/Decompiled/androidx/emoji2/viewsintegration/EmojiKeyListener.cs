namespace WillowMaze.Wasm.Decompiled;


readonly class EmojiKeyListener : android.text.method.KeyListener {
    private readonly androidx.emoji2.viewsintegration.EmojiKeyListener$EmojiCompatHandleKeyDownHelper mEmojiCompatHandleKeyDownHelper;
    private readonly android.text.method.KeyListener mKeyListener;

    EmojiKeyListener(android.text.method.KeyListener keyListener) {
        this(keyListener, new androidx.emoji2.viewsintegration.EmojiKeyListener$EmojiCompatHandleKeyDownHelper());
    }

    EmojiKeyListener(android.text.method.KeyListener keyListener, androidx.emoji2.viewsintegration.EmojiKeyListener$EmojiCompatHandleKeyDownHelper emojiKeyListener$EmojiCompatHandleKeyDownHelper) {
        this.mKeyListener = keyListener;
        this.mEmojiCompatHandleKeyDownHelper = emojiKeyListener$EmojiCompatHandleKeyDownHelper;
    }

    public override void ClearMetaKeyState(android.view.object view, android.text.Editable editable, int i) {
        this.mKeyListener.clearMetaKeyState(view, editable, i);
    }

    public override int GetInputType() {
        return this.mKeyListener.getInputType();
    }

    public override bool OnKeyDown(android.view.object view, android.text.Editable editable, int i, android.view.KeyEvent keyEvent) {
        return this.mEmojiCompatHandleKeyDownHelper.handleKeyDown(editable, i, keyEvent) || this.mKeyListener.onKeyDown(view, editable, i, keyEvent);
    }

    public override bool OnKeyOther(android.view.object view, android.text.Editable editable, android.view.KeyEvent keyEvent) {
        return this.mKeyListener.onKeyOther(view, editable, keyEvent);
    }

    public override bool OnKeyUp(android.view.object view, android.text.Editable editable, int i, android.view.KeyEvent keyEvent) {
        return this.mKeyListener.onKeyUp(view, editable, i, keyEvent);
    }
}

