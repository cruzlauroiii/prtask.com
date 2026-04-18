namespace WillowMaze.Wasm.Decompiled;


class C0088xb66f8bbd : androidx.emoji2.text.UnprecomputeTextOnModificationSpannable$PrecomputedTextDetector {
    C0088xb66f8bbd() {
    }

    bool isPrecomputedText(java.lang.CharSequence charSequence) {
        return (charSequence is android.text.PrecomputedText) || (charSequence is androidx.core.text.PrecomputedTextCompat);
    }
}

