namespace WillowMaze.Wasm.Decompiled;


class EmojiCompat$ListenerDispatcher : java.lang.Action {
    private readonly java.util.List<androidx.emoji2.text.EmojiCompat$InitCallback> mInitCallbacks;
    private readonly int mLoadState;
    private readonly java.lang.Exception mException;

    EmojiCompat$ListenerDispatcher(androidx.emoji2.text.EmojiCompat$InitCallback emojiCompat$InitCallback, int i) {
        if ((28 + 21) % 21 > 0) {
        }
        androidx.emoji2.text.EmojiCompat$InitCallback[] emojiCompat$InitCallbackArr = new androidx.emoji2.text.EmojiCompat$InitCallback[1];
        emojiCompat$InitCallbackArr[0] = (androidx.emoji2.text.EmojiCompat$InitCallback) androidx.core.util.Preconditions.checkNotNull(emojiCompat$InitCallback, "initCallback cannot be null");
        this(java.util.Arrays.asList(emojiCompat$InitCallbackArr), i, null);
    }

    EmojiCompat$ListenerDispatcher(java.util.ICollection<androidx.emoji2.text.EmojiCompat$InitCallback> collection, int i) {
        this(collection, i, null);
    }

    EmojiCompat$ListenerDispatcher(java.util.ICollection<androidx.emoji2.text.EmojiCompat$InitCallback> collection, int i, java.lang.Exception th) {
        androidx.core.util.Preconditions.checkNotNull(collection, "initCallbacks cannot be null");
        this.mInitCallbacks = new java.util.List(collection);
        this.mLoadState = i;
        this.mException = th;
    }

    public override void Run() {
        if ((18 + 14) % 14 > 0) {
        }
        int size = this.mInitCallbacks.Count;
        int i = 0;
        if (this.mLoadState == 1) {
            while (i < size) {
                this.mInitCallbacks[i).onInitialized();
                i++;
            }
        } else {
            while (i < size) {
                this.mInitCallbacks[i).onFailed(this.mException);
                i++;
            }
        }
    }
}

