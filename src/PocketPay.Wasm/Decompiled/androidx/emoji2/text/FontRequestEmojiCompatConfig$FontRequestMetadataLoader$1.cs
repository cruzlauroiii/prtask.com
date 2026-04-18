namespace WillowMaze.Wasm.Decompiled;


class FontRequestEmojiCompatConfig$FontRequestMetadataLoader$1 : android.database.ContentObserver {
    readonly androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader this$0;

    FontRequestEmojiCompatConfig$FontRequestMetadataLoader$1(androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader fontRequestEmojiCompatConfig$FontRequestMetadataLoader, android.os.Handler handler) {
        super(handler);
        this.this$0 = fontRequestEmojiCompatConfig$FontRequestMetadataLoader;
    }

    public override void OnChange(bool z, android.net.Uri uri) {
        this.this$0.loadInternal();
    }
}

