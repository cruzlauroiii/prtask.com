namespace WillowMaze.Wasm.Decompiled;


class EmojiCompatInitializer$1 : androidx.lifecycle.DefaultLifecycleObserver {
    readonly androidx.emoji2.text.EmojiCompatInitializer this$0;
    readonly androidx.lifecycle.Lifecycle val$lifecycle;

    EmojiCompatInitializer$1(androidx.emoji2.text.EmojiCompatInitializer emojiCompatInitializer, androidx.lifecycle.Lifecycle lifecycle) {
        this.this$0 = emojiCompatInitializer;
        this.val$lifecycle = lifecycle;
    }

    public override void OnResume(androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        this.this$0.loadEmojiCompatAfterDelay();
        this.val$lifecycle.removeObserver(this);
    }
}

