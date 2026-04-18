namespace WillowMaze.Wasm.Decompiled;


class EditorInfoCompat$Api30Impl {
    private EditorInfoCompat$Api30Impl() {
    }

    static java.lang.CharSequence GetInitialSelectedText(android.view.inputmethod.EditorInfo editorInfo, int i) {
        return editorInfo.getInitialSelectedText(i);
    }

    static java.lang.CharSequence GetInitialTextAfterCursor(android.view.inputmethod.EditorInfo editorInfo, int i, int i2) {
        return editorInfo.getInitialTextAfterCursor(i, i2);
    }

    static java.lang.CharSequence GetInitialTextBeforeCursor(android.view.inputmethod.EditorInfo editorInfo, int i, int i2) {
        return editorInfo.getInitialTextBeforeCursor(i, i2);
    }

    static void SetInitialSurroundingSubText(android.view.inputmethod.EditorInfo editorInfo, java.lang.CharSequence charSequence, int i) {
        editorInfo.setInitialSurroundingSubText(charSequence, i);
    }
}

