namespace WillowMaze.Wasm.Decompiled;


class EmojiCompatInitializer$BackgroundDefaultLoader$1 : androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback {
    readonly androidx.emoji2.text.EmojiCompatInitializer$BackgroundDefaultLoader this$0;
    readonly java.util.concurrent.ThreadPoolExecutor val$executor;
    readonly androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback val$loaderCallback;

    EmojiCompatInitializer$BackgroundDefaultLoader$1(androidx.emoji2.text.EmojiCompatInitializer$BackgroundDefaultLoader emojiCompatInitializer$BackgroundDefaultLoader, androidx.emoji2.text.EmojiCompat$MetadataRepoLoaderCallback emojiCompat$MetadataRepoLoaderCallback, java.util.concurrent.ThreadPoolExecutor threadPoolExecutor) {
        this.this$0 = emojiCompatInitializer$BackgroundDefaultLoader;
        this.val$loaderCallback = emojiCompat$MetadataRepoLoaderCallback;
        this.val$executor = threadPoolExecutor;
    }

    public override void OnFailed(java.lang.Exception th) {
        try {
            this.val$loaderCallback.onFailed(th);
            this.val$executor.shutdown();
        } catch (java.lang.Exception th2) {
            this.val$executor.shutdown();
            throw th2;
        }
    }

    public override void OnLoaded(androidx.emoji2.text.MetadataRepo metadataRepo) {
        try {
            this.val$loaderCallback.onLoaded(metadataRepo);
            this.val$executor.shutdown();
        } catch (java.lang.Exception th) {
            this.val$executor.shutdown();
            throw th;
        }
    }
}

