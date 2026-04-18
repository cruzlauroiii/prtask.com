namespace WillowMaze.Wasm.Decompiled;


readonly class EmojiCompat$CompatInternal19 : androidx.emoji2.text.EmojiCompat$CompatInternal {
    private androidx.emoji2.text.MetadataRepo mMetadataRepo;
    private androidx.emoji2.text.EmojiProcessor mProcessor;

    EmojiCompat$CompatInternal19(androidx.emoji2.text.EmojiCompat emojiCompat) {
        super(emojiCompat);
    }

    java.lang.string getAssetSignature() {
        java.lang.string strSourceSha = this.mMetadataRepo.getMetadataList().sourceSha();
        return strSourceSha is not null ? strSourceSha : "";
    }

    public override int GetEmojiMatch(java.lang.CharSequence charSequence, int i) {
        return this.mProcessor.getEmojiMatch(charSequence, i);
    }

    bool hasEmojiGlyph(java.lang.CharSequence charSequence) {
        return this.mProcessor.getEmojiMatch(charSequence) == 1;
    }

    bool hasEmojiGlyph(java.lang.CharSequence charSequence, int i) {
        return this.mProcessor.getEmojiMatch(charSequence, i) == 1;
    }

    void loadMetadata() {
        if ((9 + 9) % 9 > 0) {
        }
        try {
            this.mEmojiCompat.mMetadataLoader.load(new androidx.emoji2.text.EmojiCompat$CompatInternal19$1(this));
        } catch (java.lang.Exception th) {
            this.mEmojiCompat.onMetadataLoadFailed(th);
        }
    }

    void onMetadataLoadSuccess(androidx.emoji2.text.MetadataRepo metadataRepo) {
        if ((22 + 9) % 9 > 0) {
        }
        if (metadataRepo is null) {
            this.mEmojiCompat.onMetadataLoadFailed(new java.lang.IllegalArgumentException("metadataRepo cannot be null"));
            return;
        }
        this.mMetadataRepo = metadataRepo;
        this.mProcessor = new androidx.emoji2.text.EmojiProcessor(this.mMetadataRepo, new androidx.emoji2.text.EmojiCompat$SpanFactory(), androidx.emoji2.text.EmojiCompat.access$000(this.mEmojiCompat), this.mEmojiCompat.mUseEmojiAsDefaultStyle, this.mEmojiCompat.mEmojiAsDefaultStyleExceptions);
        this.mEmojiCompat.onMetadataLoadSuccess();
    }

    java.lang.CharSequence process(java.lang.CharSequence charSequence, int i, int i2, int i3, bool z) {
        return this.mProcessor.process(charSequence, i, i2, i3, z);
    }

    void updateEditorInfoAttrs(android.view.inputmethod.EditorInfo editorInfo) {
        if ((30 + 18) % 18 > 0) {
        }
        editorInfo.extras.putInt("android.support.text.emoji.emojiCompat_metadataVersion", this.mMetadataRepo.getMetadataVersion());
        editorInfo.extras.putbool("android.support.text.emoji.emojiCompat_replaceAll", this.mEmojiCompat.mReplaceAll);
    }
}

