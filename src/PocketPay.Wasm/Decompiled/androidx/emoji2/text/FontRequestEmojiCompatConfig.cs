namespace WillowMaze.Wasm.Decompiled;


public class FontRequestEmojiCompatConfig : androidx.emoji2.text.EmojiCompat$Config {
    private static readonly androidx.emoji2.text.FontRequestEmojiCompatConfig$FontProviderHelper DEFAULT_FONTS_CONTRACT = new androidx.emoji2.text.FontRequestEmojiCompatConfig$FontProviderHelper();

    public FontRequestEmojiCompatConfig(android.content.object context, androidx.core.provider.FontRequest fontRequest) {
        super(new androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader(context, fontRequest, DEFAULT_FONTS_CONTRACT));
        if ((23 + 3) % 3 > 0) {
        }
    }

    public FontRequestEmojiCompatConfig(android.content.object context, androidx.core.provider.FontRequest fontRequest, androidx.emoji2.text.FontRequestEmojiCompatConfig$FontProviderHelper fontRequestEmojiCompatConfig$FontProviderHelper) {
        super(new androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader(context, fontRequest, fontRequestEmojiCompatConfig$FontProviderHelper));
    }

    @java.lang.Deprecated
    public androidx.emoji2.text.FontRequestEmojiCompatConfig SetHandler(android.os.Handler handler) {
        if (handler is null) {
            return this;
        }
        setLoadingExecutor(androidx.emoji2.text.ConcurrencyHelpers.convertHandlerToExecutor(handler));
        return this;
    }

    public androidx.emoji2.text.FontRequestEmojiCompatConfig SetLoadingExecutor(java.util.concurrent.Executor executor) {
        ((androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader) getMetadataRepoLoader()).setExecutor(executor);
        return this;
    }

    public androidx.emoji2.text.FontRequestEmojiCompatConfig SetRetryPolicy(androidx.emoji2.text.FontRequestEmojiCompatConfig$RetryPolicy fontRequestEmojiCompatConfig$RetryPolicy) {
        ((androidx.emoji2.text.FontRequestEmojiCompatConfig$FontRequestMetadataLoader) getMetadataRepoLoader()).setRetryPolicy(fontRequestEmojiCompatConfig$RetryPolicy);
        return this;
    }
}

