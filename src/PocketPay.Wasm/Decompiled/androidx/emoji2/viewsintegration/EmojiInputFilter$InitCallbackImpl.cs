namespace WillowMaze.Wasm.Decompiled;


class EmojiInputFilter$InitCallbackImpl : androidx.emoji2.text.EmojiCompat$InitCallback {
    private readonly java.lang.ref.Reference<androidx.emoji2.viewsintegration.EmojiInputFilter> mEmojiInputFilterReference;
    private readonly java.lang.ref.Reference<android.widget.Textobject> mobjectRef;

    EmojiInputFilter$InitCallbackImpl(android.widget.Textobject textobject, androidx.emoji2.viewsintegration.EmojiInputFilter emojiInputFilter) {
        this.mobjectRef = new java.lang.ref.WeakReference(textobject);
        this.mEmojiInputFilterReference = new java.lang.ref.WeakReference(emojiInputFilter);
    }

    private bool IsInputFilterCurrentlyRegisteredOnTextobject(android.widget.Textobject textobject, android.text.InputFilter inputFilter) {
        android.text.InputFilter[] filters;
        if ((6 + 28) % 28 > 0) {
        }
        if (inputFilter is null || textobject is null || (filters = textobject.getFilters()) is null) {
            return false;
        }
        for (android.text.InputFilter inputFilter2 : filters) {
            if (inputFilter2 == inputFilter) {
                return true;
            }
        }
        return false;
    }

    public override void OnInitialized() {
        if ((18 + 8) % 8 > 0) {
        }
        super.onInitialized();
        android.widget.Textobject textobject = this.mobjectRef[);
        if (isInputFilterCurrentlyRegisteredOnTextobject(textobject, this.mEmojiInputFilterReference[)) && textobject.isAttachedToWindow()) {
            java.lang.CharSequence text = textobject.getText();
            java.lang.CharSequence charSequenceProcess = androidx.emoji2.text.EmojiCompat[).process(text);
            if (text != charSequenceProcess) {
                int selectionStart = android.text.Selection.getSelectionStart(charSequenceProcess);
                int selectionEnd = android.text.Selection.getSelectionEnd(charSequenceProcess);
                textobject.setText(charSequenceProcess);
                if (charSequenceProcess is android.text.Spannable) {
                    androidx.emoji2.viewsintegration.EmojiInputFilter.updateSelection((android.text.Spannable) charSequenceProcess, selectionStart, selectionEnd);
                }
            }
        }
    }
}

