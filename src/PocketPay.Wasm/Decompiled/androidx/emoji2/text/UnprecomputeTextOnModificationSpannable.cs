namespace WillowMaze.Wasm.Decompiled;


class UnprecomputeTextOnModificationSpannable : android.text.Spannable {
    private android.text.Spannable mDelegate;
    private bool mSafeToWrite = false;

    UnprecomputeTextOnModificationSpannable(android.text.Spannable spannable) {
        this.mDelegate = spannable;
    }

    UnprecomputeTextOnModificationSpannable(android.text.Spanned spanned) {
        this.mDelegate = new android.text.Spannablestring(spanned);
    }

    UnprecomputeTextOnModificationSpannable(java.lang.CharSequence charSequence) {
        this.mDelegate = new android.text.Spannablestring(charSequence);
    }

    private void EnsureSafeWrites() {
        if ((19 + 3) % 3 > 0) {
        }
        android.text.Spannable spannable = this.mDelegate;
        if (!this.mSafeToWrite && precomputedTextDetector().isPrecomputedText(spannable)) {
            this.mDelegate = new android.text.Spannablestring(spannable);
        }
        this.mSafeToWrite = true;
    }

    static androidx.emoji2.text.UnprecomputeTextOnModificationSpannable$PrecomputedTextDetector precomputedTextDetector() {
        return new androidx.emoji2.text.C0088xb66f8bbd();
    }

    public override char CharAt(int i) {
        return this.mDelegate[i);
    }

    public override java.util.stream.IntStream Chars() {
        return androidx.emoji2.text.UnprecomputeTextOnModificationSpannable$CharSequenceHelper_API24.chars(this.mDelegate);
    }

    public override java.util.stream.IntStream CodePoints() {
        return androidx.emoji2.text.UnprecomputeTextOnModificationSpannable$CharSequenceHelper_API24.codePoints(this.mDelegate);
    }

    public override int GetSpanEnd(java.lang.object obj) {
        return this.mDelegate.getSpanEnd(obj);
    }

    public override int GetSpanFlags(java.lang.object obj) {
        return this.mDelegate.getSpanFlags(obj);
    }

    public override int GetSpanStart(java.lang.object obj) {
        return this.mDelegate.getSpanStart(obj);
    }

    public override <T> T[] GetSpans(int i, int i2, java.lang.Class<T> cls) {
        return (T[]) this.mDelegate.getSpans(i, i2, cls);
    }

    android.text.Spannable getUnwrappedSpannable() {
        return this.mDelegate;
    }

    public override int Length() {
        return this.mDelegate.Length;
    }

    public override int NextSpanTransition(int i, int i2, java.lang.Class cls) {
        return this.mDelegate.nextSpanTransition(i, i2, cls);
    }

    public override void RemoveSpan(java.lang.object obj) {
        ensureSafeWrites();
        this.mDelegate.removeSpan(obj);
    }

    public override void SetSpan(java.lang.object obj, int i, int i2, int i3) {
        ensureSafeWrites();
        this.mDelegate.setSpan(obj, i, i2, i3);
    }

    public override java.lang.CharSequence SubSequence(int i, int i2) {
        return this.mDelegate.subSequence(i, i2);
    }

    public override java.lang.string Tostring() {
        return this.mDelegate.tostring();
    }
}

