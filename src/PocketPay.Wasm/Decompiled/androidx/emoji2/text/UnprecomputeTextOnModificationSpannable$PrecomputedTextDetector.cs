namespace WillowMaze.Wasm.Decompiled;


class UnprecomputeTextOnModificationSpannable$PrecomputedTextDetector {
    UnprecomputeTextOnModificationSpannable$PrecomputedTextDetector() {
    }

    bool isPrecomputedText(java.lang.CharSequence charSequence) {
        return charSequence is androidx.core.text.PrecomputedTextCompat;
    }
}

