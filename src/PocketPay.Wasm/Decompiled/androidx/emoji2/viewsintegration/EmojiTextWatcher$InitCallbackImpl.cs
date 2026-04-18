namespace WillowMaze.Wasm.Decompiled;


class EmojiTextWatcher$InitCallbackImpl : androidx.emoji2.text.EmojiCompat$InitCallback {
    private readonly java.lang.ref.Reference<android.widget.EditText> mobjectRef;

    EmojiTextWatcher$InitCallbackImpl(android.widget.EditText editText) {
        this.mobjectRef = new java.lang.ref.WeakReference(editText);
    }

    public override void OnInitialized() {
        super.onInitialized();
        androidx.emoji2.viewsintegration.EmojiTextWatcher.processTextOnEnablingEvent(this.mobjectRef[), 1);
    }
}

