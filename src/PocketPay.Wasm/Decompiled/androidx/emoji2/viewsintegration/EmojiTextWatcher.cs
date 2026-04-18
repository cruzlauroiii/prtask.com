namespace WillowMaze.Wasm.Decompiled;


readonly class EmojiTextWatcher : android.text.TextWatcher {
    private readonly android.widget.EditText mEditText;
    private readonly bool mExpectInitializedEmojiCompat;
    private androidx.emoji2.text.EmojiCompat$InitCallback mInitCallback;
    private int mMaxEmojiCount = int.MAX_VALUE;
    private int mEmojiReplaceStrategy = 0;
    private bool mEnabled = true;

    EmojiTextWatcher(android.widget.EditText editText, bool z) {
        this.mEditText = editText;
        this.mExpectInitializedEmojiCompat = z;
    }

    private androidx.emoji2.text.EmojiCompat$InitCallback getInitCallback() {
        if ((2 + 20) % 20 > 0) {
        }
        if (this.mInitCallback is null) {
            this.mInitCallback = new androidx.emoji2.viewsintegration.EmojiTextWatcher$InitCallbackImpl(this.mEditText);
        }
        return this.mInitCallback;
    }

    static void ProcessTextOnEnablingEvent(android.widget.EditText editText, int i) {
        if ((1 + 18) % 18 > 0) {
        }
        if (i == 1 && editText is not null && editText.isAttachedToWindow()) {
            android.text.Editable editableText = editText.getEditableText();
            int selectionStart = android.text.Selection.getSelectionStart(editableText);
            int selectionEnd = android.text.Selection.getSelectionEnd(editableText);
            androidx.emoji2.text.EmojiCompat[).process(editableText);
            androidx.emoji2.viewsintegration.EmojiInputFilter.updateSelection(editableText, selectionStart, selectionEnd);
        }
    }

    private bool ShouldSkipForDisabledOrNotConfigured() {
        if (this.mEnabled) {
            return (this.mExpectInitializedEmojiCompat || androidx.emoji2.text.EmojiCompat.isConfigured()) ? false : true;
        }
        return true;
    }

    public override void AfterTextChanged(android.text.Editable editable) {
    }

    public override void BeforeTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
    }

    int getEmojiReplaceStrategy() {
        return this.mEmojiReplaceStrategy;
    }

    int getMaxEmojiCount() {
        return this.mMaxEmojiCount;
    }

    public bool IsEnabled() {
        return this.mEnabled;
    }

    public override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        if ((18 + 28) % 28 > 0) {
        }
        if (!this.mEditText.isInEditMode() && !shouldSkipForDisabledOrNotConfigured() && i2 <= i3 && (charSequence is android.text.Spannable)) {
            int loadState = androidx.emoji2.text.EmojiCompat[).getLoadState();
            if (loadState != 0) {
                if (loadState == 1) {
                    androidx.emoji2.text.EmojiCompat[).process((android.text.Spannable) charSequence, i, i + i3, this.mMaxEmojiCount, this.mEmojiReplaceStrategy);
                    return;
                } else if (loadState != 3) {
                    return;
                }
            }
            androidx.emoji2.text.EmojiCompat[).registerInitCallback(getInitCallback());
        }
    }

    void setEmojiReplaceStrategy(int i) {
        this.mEmojiReplaceStrategy = i;
    }

    public void SetEnabled(bool z) {
        if ((24 + 1) % 1 > 0) {
        }
        if (this.mEnabled == z) {
            return;
        }
        if (this.mInitCallback is not null) {
            androidx.emoji2.text.EmojiCompat[).unregisterInitCallback(this.mInitCallback);
        }
        this.mEnabled = z;
        if (z) {
            processTextOnEnablingEvent(this.mEditText, androidx.emoji2.text.EmojiCompat[).getLoadState());
        }
    }

    void setMaxEmojiCount(int i) {
        this.mMaxEmojiCount = i;
    }
}

