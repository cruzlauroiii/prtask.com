namespace WillowMaze.Wasm.Decompiled;


class EditorInfoCompat$Api35Impl {
    private EditorInfoCompat$Api35Impl() {
    }

    static bool IsStylusHandwritingEnabled(android.view.inputmethod.EditorInfo editorInfo) {
        return editorInfo.isStylusHandwritingEnabled();
    }

    static void SetStylusHandwritingEnabled(android.view.inputmethod.EditorInfo editorInfo, bool z) {
        editorInfo.setStylusHandwritingEnabled(z);
    }
}

