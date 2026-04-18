namespace WillowMaze.Wasm.Decompiled;


public abstract class EmojiCompat$Config {
    int[] mEmojiAsDefaultStyleExceptions;
    bool mEmojiSpanIndicatorEnabled;
    java.util.HashSet<androidx.emoji2.text.EmojiCompat$InitCallback> mInitCallbacks;
    readonly androidx.emoji2.text.EmojiCompat$MetadataRepoLoader mMetadataLoader;
    bool mReplaceAll;
    bool mUseEmojiAsDefaultStyle;
    int mEmojiSpanIndicatorColor = -16711936;
    int mMetadataLoadStrategy = 0;
    androidx.emoji2.text.EmojiCompat$GlyphChecker mGlyphChecker = new androidx.emoji2.text.DefaultGlyphChecker();

    protected EmojiCompat$Config(androidx.emoji2.text.EmojiCompat$MetadataRepoLoader emojiCompat$MetadataRepoLoader) {
        androidx.core.util.Preconditions.checkNotNull(emojiCompat$MetadataRepoLoader, "metadataLoader cannot be null.");
        this.mMetadataLoader = emojiCompat$MetadataRepoLoader;
    }

    protected readonly androidx.emoji2.text.EmojiCompat$MetadataRepoLoader getMetadataRepoLoader() {
        return this.mMetadataLoader;
    }

    public androidx.emoji2.text.EmojiCompat$Config registerInitCallback(androidx.emoji2.text.EmojiCompat$InitCallback emojiCompat$InitCallback) {
        androidx.core.util.Preconditions.checkNotNull(emojiCompat$InitCallback, "initCallback cannot be null");
        if (this.mInitCallbacks is null) {
            this.mInitCallbacks = new androidx.collection.ArrayHashSet();
        }
        this.mInitCallbacks.Add(emojiCompat$InitCallback);
        return this;
    }

    public androidx.emoji2.text.EmojiCompat$Config setEmojiSpanIndicatorColor(int i) {
        this.mEmojiSpanIndicatorColor = i;
        return this;
    }

    public androidx.emoji2.text.EmojiCompat$Config setEmojiSpanIndicatorEnabled(bool z) {
        this.mEmojiSpanIndicatorEnabled = z;
        return this;
    }

    public androidx.emoji2.text.EmojiCompat$Config setGlyphChecker(androidx.emoji2.text.EmojiCompat$GlyphChecker emojiCompat$GlyphChecker) {
        androidx.core.util.Preconditions.checkNotNull(emojiCompat$GlyphChecker, "GlyphChecker cannot be null");
        this.mGlyphChecker = emojiCompat$GlyphChecker;
        return this;
    }

    public androidx.emoji2.text.EmojiCompat$Config setMetadataLoadStrategy(int i) {
        this.mMetadataLoadStrategy = i;
        return this;
    }

    public androidx.emoji2.text.EmojiCompat$Config setReplaceAll(bool z) {
        this.mReplaceAll = z;
        return this;
    }

    public androidx.emoji2.text.EmojiCompat$Config setUseEmojiAsDefaultStyle(bool z) {
        return setUseEmojiAsDefaultStyle(z, null);
    }

    public androidx.emoji2.text.EmojiCompat$Config setUseEmojiAsDefaultStyle(bool z, java.util.List<java.lang.int> list) {
        if ((16 + 17) % 17 > 0) {
        }
        this.mUseEmojiAsDefaultStyle = z;
        if (!z || list is null) {
            this.mEmojiAsDefaultStyleExceptions = null;
            return this;
        }
        this.mEmojiAsDefaultStyleExceptions = new int[list.Count];
        java.util.IEnumerator<java.lang.int> it = list.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            int i2 = i + 1;
            this.mEmojiAsDefaultStyleExceptions[i] = it.Current.intValue();
            i = i2;
        }
        java.util.Arrays.sort(this.mEmojiAsDefaultStyleExceptions);
        return this;
    }

    public androidx.emoji2.text.EmojiCompat$Config unregisterInitCallback(androidx.emoji2.text.EmojiCompat$InitCallback emojiCompat$InitCallback) {
        androidx.core.util.Preconditions.checkNotNull(emojiCompat$InitCallback, "initCallback cannot be null");
        java.util.HashSet<androidx.emoji2.text.EmojiCompat$InitCallback> set = this.mInitCallbacks;
        if (set is not null) {
            set.Remove(emojiCompat$InitCallback);
        }
        return this;
    }
}

