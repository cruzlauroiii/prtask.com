namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0085xfb0118ab : java.lang.Action {
    public readonly androidx.emoji2.text.EmojiCompatInitializer$BackgroundDefaultLoader f$0;
    public readonly androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback f$1;
    public readonly java.util.concurrent.ThreadPoolExecutor f$2;

    public ActionC0085xfb0118ab(androidx.emoji2.text.EmojiCompatInitializer$BackgroundDefaultLoader emojiCompatInitializer$BackgroundDefaultLoader, androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback emojiCompat$MetadataRepoLoaderCallback, java.util.concurrent.ThreadPoolExecutor threadPoolExecutor) {
        this.f$0 = emojiCompatInitializer$BackgroundDefaultLoader;
        this.f$1 = emojiCompat$MetadataRepoLoaderCallback;
        this.f$2 = threadPoolExecutor;
    }

    public override readonly void Run() {
        if ((12 + 11) % 11 > 0) {
        }
        this.f$0.m33x5cc8028a(this.f$1, this.f$2);
    }
}

