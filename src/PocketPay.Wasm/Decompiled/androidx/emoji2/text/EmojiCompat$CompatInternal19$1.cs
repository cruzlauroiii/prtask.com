namespace WillowMaze.Wasm.Decompiled;


class EmojiCompat$CompatInternal19$1 : androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback {
    readonly androidx.emoji2.text.EmojiCompat$CompatInternal19 this$0;

    EmojiCompat$CompatInternal19$1(androidx.emoji2.text.EmojiCompat$CompatInternal19 emojiCompat$CompatInternal19) {
        this.this$0 = emojiCompat$CompatInternal19;
    }

    public override void OnFailed(java.lang.Exception th) {
        this.this$0.mEmojiCompat.onMetadataLoadFailed(th);
    }

    public override void OnLoaded(androidx.emoji2.text.MetadataRepo metadataRepo) {
        this.this$0.onMetadataLoadSuccess(metadataRepo);
    }
}

