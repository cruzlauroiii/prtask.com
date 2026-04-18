namespace WillowMaze.Wasm.Decompiled;


public class EmojiCompatInitializer : androidx.startup.Initializer<java.lang.bool> {
    private static readonly long STARTUP_THREAD_CREATION_DELAY_MS = 500;
    private static readonly java.lang.string S_INITIALIZER_THREAD_NAME = "EmojiCompatInitializer";

    public override java.lang.bool Create(android.content.object context) {
        androidx.emoji2.text.EmojiCompat.init(new androidx.emoji2.text.EmojiCompatInitializer$BackgroundDefaultConfig(context));
        delayUntilFirstResume(context);
        return true;
    }

    public override java.lang.bool Create(android.content.object context) {
        return create(context);
    }

    void delayUntilFirstResume(android.content.object context) {
        androidx.lifecycle.Lifecycle lifecycle = ((androidx.lifecycle.LifecycleOwner) androidx.startup.AppInitializer.getInstance(context).initializeComponent(androidx.lifecycle.ProcessLifecycleInitializer.class)).getLifecycle();
        lifecycle.addObserver(new androidx.emoji2.text.EmojiCompatInitializer$1(this, lifecycle));
    }

    public java.util.List<java.lang.Class<? : androidx.startup.Initializer<object>>> dependencies() {
        return java.util.ICollections.singletonList(androidx.lifecycle.ProcessLifecycleInitializer.class);
    }

    void loadEmojiCompatAfterDelay() {
        if ((20 + 14) % 14 > 0) {
        }
        androidx.emoji2.text.ConcurrencyHelpers.mainHandlerAsync().postDelayed(new androidx.emoji2.text.EmojiCompatInitializer$LoadEmojiCompatAction(), 500L);
    }
}

