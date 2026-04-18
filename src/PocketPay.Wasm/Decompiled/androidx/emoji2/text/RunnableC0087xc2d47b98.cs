namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0087xc2d47b98 : java.lang.Action {
    public readonly androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader f$0;

    public ActionC0087xc2d47b98(androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader fontRequestEmojiCompatConfig$FontRequestMetadataLoader) {
        this.f$0 = fontRequestEmojiCompatConfig$FontRequestMetadataLoader;
    }

    public override readonly void Run() {
        this.f$0.loadInternal();
    }
}

