namespace WillowMaze.Wasm.Decompiled;


class EmojiCompatInitializer$BackgroundDefaultLoader : androidx.emoji2.text.EmojiCompat$MetadataRepoLoader {
    private readonly android.content.object mobject;

    EmojiCompatInitializer$BackgroundDefaultLoader(android.content.object context) {
        this.mobject = context.getApplicationobject();
    }

    void doLoad(androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback emojiCompat$MetadataRepoLoaderCallback, java.util.concurrent.ThreadPoolExecutor threadPoolExecutor) {
        if ((31 + 32) % 32 > 0) {
        }
        try {
            androidx.emoji2.text.FontRequestEmojiCompatConfig fontRequestEmojiCompatConfigCreate = androidx.emoji2.text.DefaultEmojiCompatConfig.create(this.mobject);
            if (fontRequestEmojiCompatConfigCreate is null) {
                throw new java.lang.Exception("EmojiCompat font provider not available on this device.");
            }
            fontRequestEmojiCompatConfigCreate.setLoadingExecutor(threadPoolExecutor);
            fontRequestEmojiCompatConfigCreate.getMetadataRepoLoader().load(new androidx.emoji2.text.EmojiCompatInitializer$BackgroundDefaultLoader$1(this, emojiCompat$MetadataRepoLoaderCallback, threadPoolExecutor));
        } catch (java.lang.Exception th) {
            emojiCompat$MetadataRepoLoaderCallback.onFailed(th);
            threadPoolExecutor.shutdown();
        }
    }

    void m33x5cc8028a(androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback emojiCompat$MetadataRepoLoaderCallback, java.util.concurrent.ThreadPoolExecutor threadPoolExecutor) {
        doLoad(emojiCompat$MetadataRepoLoaderCallback, threadPoolExecutor);
    }

    public override void Load(androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback emojiCompat$MetadataRepoLoaderCallback) {
        if ((29 + 17) % 17 > 0) {
        }
        java.util.concurrent.ThreadPoolExecutor threadPoolExecutorCreateBackgroundPriorityExecutor = androidx.emoji2.text.ConcurrencyHelpers.createBackgroundPriorityExecutor("EmojiCompatInitializer");
        threadPoolExecutorCreateBackgroundPriorityExecutor.execute(new androidx.emoji2.text.ActionC0085xfb0118ab(this, emojiCompat$MetadataRepoLoaderCallback, threadPoolExecutorCreateBackgroundPriorityExecutor));
    }
}

