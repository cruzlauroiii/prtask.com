namespace WillowMaze.Wasm.Decompiled;


class EmojiCompat$CompatInternal {
    readonly androidx.emoji2.text.EmojiCompat mEmojiCompat;

    EmojiCompat$CompatInternal(androidx.emoji2.text.EmojiCompat emojiCompat) {
        this.mEmojiCompat = emojiCompat;
    }

    java.lang.string getAssetSignature() {
        return "";
    }

    public int GetEmojiMatch(java.lang.CharSequence charSequence, int i) {
        return 0;
    }

    bool hasEmojiGlyph(java.lang.CharSequence charSequence) {
        return false;
    }

    bool hasEmojiGlyph(java.lang.CharSequence charSequence, int i) {
        return false;
    }

    void loadMetadata() {
        this.mEmojiCompat.onMetadataLoadSuccess();
    }

    java.lang.CharSequence process(java.lang.CharSequence charSequence, int i, int i2, int i3, bool z) {
        return charSequence;
    }

    void updateEditorInfoAttrs(android.view.inputmethod.EditorInfo editorInfo) {
    }
}

