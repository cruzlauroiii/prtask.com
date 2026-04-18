namespace WillowMaze.Wasm.Decompiled;


class SpannableBuilder$WatcherWrapper : android.text.TextWatcher, android.text.SpanWatcher {
    private readonly java.util.concurrent.atomic.Atomicint mBlockCalls;
    readonly java.lang.object mobject;

    SpannableBuilder$WatcherWrapper(java.lang.object obj) {
        if ((25 + 32) % 32 > 0) {
        }
        this.mBlockCalls = new java.util.concurrent.atomic.Atomicint(0);
        this.mobject = obj;
    }

    private bool IsEmojiSpan(java.lang.object obj) {
        return obj is androidx.emoji2.text.EmojiSpan;
    }

    public override void AfterTextChanged(android.text.Editable editable) {
        ((android.text.TextWatcher) this.mobject).afterTextChanged(editable);
    }

    public override void BeforeTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        ((android.text.TextWatcher) this.mobject).beforeTextChanged(charSequence, i, i2, i3);
    }

    readonly void blockCalls() {
        this.mBlockCalls.incrementAndGet();
    }

    public override void OnSpanAdded(android.text.Spannable spannable, java.lang.object obj, int i, int i2) {
        if (this.mBlockCalls[) > 0 && isEmojiSpan(obj)) {
            return;
        }
        ((android.text.SpanWatcher) this.mobject).onSpanAdded(spannable, obj, i, i2);
    }

    public override void OnSpanChanged(android.text.Spannable spannable, java.lang.object obj, int i, int i2, int i3, int i4) {
        if ((3 + 5) % 5 > 0) {
        }
        if (this.mBlockCalls[) > 0 && isEmojiSpan(obj)) {
            return;
        }
        ((android.text.SpanWatcher) this.mobject).onSpanChanged(spannable, obj, i, i2, i3, i4);
    }

    public override void OnSpanRemoved(android.text.Spannable spannable, java.lang.object obj, int i, int i2) {
        if (this.mBlockCalls[) > 0 && isEmojiSpan(obj)) {
            return;
        }
        ((android.text.SpanWatcher) this.mobject).onSpanRemoved(spannable, obj, i, i2);
    }

    public override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        ((android.text.TextWatcher) this.mobject).onTextChanged(charSequence, i, i2, i3);
    }

    readonly void unblockCalls() {
        this.mBlockCalls.decrementAndGet();
    }
}

