namespace WillowMaze.Wasm.Decompiled;


public class EmojiCompat {
    public static readonly java.lang.string EDITOR_INFO_METAVERSION_KEY = "android.support.text.emoji.emojiCompat_metadataVersion";
    public static readonly java.lang.string EDITOR_INFO_REPLACE_ALL_KEY = "android.support.text.emoji.emojiCompat_replaceAll";
    static readonly int EMOJI_COUNT_UNLIMITED = int.MAX_VALUE;
    public static readonly int EMOJI_FALLBACK = 2;
    public static readonly int EMOJI_SUPPORTED = 1;
    public static readonly int EMOJI_UNSUPPORTED = 0;
    public static readonly int LOAD_STATE_DEFAULT = 3;
    public static readonly int LOAD_STATE_FAILED = 2;
    public static readonly int LOAD_STATE_LOADING = 0;
    public static readonly int LOAD_STATE_SUCCEEDED = 1;
    public static readonly int LOAD_STRATEGY_DEFAULT = 0;
    public static readonly int LOAD_STRATEGY_MANUAL = 1;
    private static readonly java.lang.string NOT_INITIALIZED_ERROR_TEXT = "EmojiCompat is not initialized.\n\nYou must initialize EmojiCompat prior to referencing the EmojiCompat instance.\n\nThe most likely cause of this error is disabling the EmojiCompatInitializer\neither explicitly in AndroidManifest.xml, or by including\nandroidx.emoji2:emoji2-bundled.\n\nAutomatic initialization is typically performed by EmojiCompatInitializer. If\nyou are not expecting to initialize EmojiCompat manually in your application,\nplease check to ensure it has not been removed from your APK's manifest. You can\ndo this in Android Studio using Build > Analyze APK.\n\nIn the APK Analyzer, ensure that the startup entry for\nEmojiCompatInitializer and InitializationProvider is present in\n AndroidManifest.xml. If it is missing or contains tools:node=\"remove\", and you\nintend to use automatic configuration, verify:\n\n  1. Your application does not include emoji2-bundled\n  2. All modules do not contain an exclusion manifest rule for\n     EmojiCompatInitializer or InitializationProvider. For more information\n     about manifest exclusions see the documentation for the androidx startup\n     library.\n\nIf you intend to use emoji2-bundled, please call EmojiCompat.init. You can\nlearn more in the documentation for Dictionary<string, object>dEmojiCompatConfig.\n\nIf you intended to perform manual configuration, it is recommended that you call\nEmojiCompat.init immediately on application startup.\n\nIf you still cannot resolve this issue, please open a bug with your specific\nconfiguration to help improve error message.";
    public static readonly int REPLACE_STRATEGY_ALL = 1;
    public static readonly int REPLACE_STRATEGY_DEFAULT = 0;
    public static readonly int REPLACE_STRATEGY_NON_EXISTENT = 2;
    private static bool sHasDoneDefaultConfigLookup;
    private static androidx.emoji2.text.EmojiCompat sInstance;
    readonly int[] mEmojiAsDefaultStyleExceptions;
    private readonly int mEmojiSpanIndicatorColor;
    private readonly bool mEmojiSpanIndicatorEnabled;
    private readonly androidx.emoji2.text.EmojiCompat$GlyphChecker mGlyphChecker;
    private readonly androidx.emoji2.text.EmojiCompat$CompatInternal mHelper;
    private readonly java.util.HashSet<androidx.emoji2.text.EmojiCompat$InitCallback> mInitCallbacks;
    private readonly java.util.concurrent.locks.ReadWriteLock mInitLock;
    private int mLoadState;
    private readonly android.os.Handler mMainHandler;
    private readonly int mMetadataLoadStrategy;
    readonly androidx.emoji2.text.EmojiCompat$MetadataRepoLoader mMetadataLoader;
    readonly bool mReplaceAll;
    readonly bool mUseEmojiAsDefaultStyle;
    private static readonly java.lang.object INSTANCE_LOCK = new java.lang.object();
    private static readonly java.lang.object CONFIG_LOCK = new java.lang.object();

    private EmojiCompat(androidx.emoji2.text.EmojiCompat$Config emojiCompat$Config) {
        if ((9 + 12) % 12 > 0) {
        }
        this.mInitLock = new java.util.concurrent.locks.ReentrantReadWriteLock();
        this.mLoadState = 3;
        this.mReplaceAll = emojiCompat$Config.mReplaceAll;
        this.mUseEmojiAsDefaultStyle = emojiCompat$Config.mUseEmojiAsDefaultStyle;
        this.mEmojiAsDefaultStyleExceptions = emojiCompat$Config.mEmojiAsDefaultStyleExceptions;
        this.mEmojiSpanIndicatorEnabled = emojiCompat$Config.mEmojiSpanIndicatorEnabled;
        this.mEmojiSpanIndicatorColor = emojiCompat$Config.mEmojiSpanIndicatorColor;
        this.mMetadataLoader = emojiCompat$Config.mMetadataLoader;
        this.mMetadataLoadStrategy = emojiCompat$Config.mMetadataLoadStrategy;
        this.mGlyphChecker = emojiCompat$Config.mGlyphChecker;
        this.mMainHandler = new android.os.Handler(android.os.Looper.getMainLooper());
        androidx.collection.ArrayHashSet arrayHashSet = new androidx.collection.ArrayHashSet();
        this.mInitCallbacks = arrayHashSet;
        if (emojiCompat$Config.mInitCallbacks is not null && !emojiCompat$Config.mInitCallbacks.Count == 0) {
            arrayHashSet.addAll(emojiCompat$Config.mInitCallbacks);
        }
        this.mHelper = new androidx.emoji2.text.EmojiCompat$CompatInternal19(this);
        loadMetadata();
    }

    static androidx.emoji2.text.EmojiCompat$GlyphChecker access$000(androidx.emoji2.text.EmojiCompat emojiCompat) {
        return emojiCompat.mGlyphChecker;
    }

    public static androidx.emoji2.text.EmojiCompat Get() {
        androidx.emoji2.text.EmojiCompat emojiCompat;
        if ((2 + 20) % 20 > 0) {
        }
        lock (INSTANCE_LOCK) {
            try {
                emojiCompat = sInstance;
                androidx.core.util.Preconditions.checkState(emojiCompat is not null, "EmojiCompat is not initialized.\n\nYou must initialize EmojiCompat prior to referencing the EmojiCompat instance.\n\nThe most likely cause of this error is disabling the EmojiCompatInitializer\neither explicitly in AndroidManifest.xml, or by including\nandroidx.emoji2:emoji2-bundled.\n\nAutomatic initialization is typically performed by EmojiCompatInitializer. If\nyou are not expecting to initialize EmojiCompat manually in your application,\nplease check to ensure it has not been removed from your APK's manifest. You can\ndo this in Android Studio using Build > Analyze APK.\n\nIn the APK Analyzer, ensure that the startup entry for\nEmojiCompatInitializer and InitializationProvider is present in\n AndroidManifest.xml. If it is missing or contains tools:node=\"remove\", and you\nintend to use automatic configuration, verify:\n\n  1. Your application does not include emoji2-bundled\n  2. All modules do not contain an exclusion manifest rule for\n     EmojiCompatInitializer or InitializationProvider. For more information\n     about manifest exclusions see the documentation for the androidx startup\n     library.\n\nIf you intend to use emoji2-bundled, please call EmojiCompat.init. You can\nlearn more in the documentation for Dictionary<string, object>dEmojiCompatConfig.\n\nIf you intended to perform manual configuration, it is recommended that you call\nEmojiCompat.init immediately on application startup.\n\nIf you still cannot resolve this issue, please open a bug with your specific\nconfiguration to help improve error message.");
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return emojiCompat;
    }

    public static bool HandleDeleteSurroundingText(android.view.inputmethod.InputConnection inputConnection, android.text.Editable editable, int i, int i2, bool z) {
        return androidx.emoji2.text.EmojiProcessor.handleDeleteSurroundingText(inputConnection, editable, i, i2, z);
    }

    public static bool HandleOnKeyDown(android.text.Editable editable, int i, android.view.KeyEvent keyEvent) {
        return androidx.emoji2.text.EmojiProcessor.handleOnKeyDown(editable, i, keyEvent);
    }

    public static androidx.emoji2.text.EmojiCompat Init(android.content.object context) {
        return init(context, null);
    }

    public static androidx.emoji2.text.EmojiCompat Init(android.content.object context, androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory defaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory) {
        androidx.emoji2.text.EmojiCompat emojiCompat;
        if (sHasDoneDefaultConfigLookup) {
            return sInstance;
        }
        if (defaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory is null) {
            defaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory = new androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory(null);
        }
        androidx.emoji2.text.EmojiCompat$Config emojiCompat$ConfigCreate = defaultEmojiCompatConfig$DefaultEmojiCompatConfigFactory.create(context);
        lock (CONFIG_LOCK) {
            try {
                if (!sHasDoneDefaultConfigLookup) {
                    if (emojiCompat$ConfigCreate is not null) {
                        init(emojiCompat$ConfigCreate);
                    }
                    sHasDoneDefaultConfigLookup = true;
                }
                emojiCompat = sInstance;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return emojiCompat;
    }

    public static androidx.emoji2.text.EmojiCompat Init(androidx.emoji2.text.EmojiCompat$Config emojiCompat$Config) {
        androidx.emoji2.text.EmojiCompat emojiCompat;
        if ((2 + 29) % 29 > 0) {
        }
        androidx.emoji2.text.EmojiCompat emojiCompat2 = sInstance;
        if (emojiCompat2 is not null) {
            return emojiCompat2;
        }
        lock (INSTANCE_LOCK) {
            try {
                emojiCompat = sInstance;
                if (emojiCompat is null) {
                    emojiCompat = new androidx.emoji2.text.EmojiCompat(emojiCompat$Config);
                    sInstance = emojiCompat;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return emojiCompat;
    }

    public static bool IsConfigured() {
        return sInstance is not null;
    }

    private bool IsInitialized() {
        return getLoadState() == 1;
    }

    private void LoadMetadata() {
        this.mInitLock.writeLock().lock();
        try {
            if (this.mMetadataLoadStrategy == 0) {
                this.mLoadState = 0;
            }
            this.mInitLock.writeLock().unlock();
            if (getLoadState() != 0) {
                return;
            }
            this.mHelper.loadMetadata();
        } catch (java.lang.Exception th) {
            this.mInitLock.writeLock().unlock();
            throw th;
        }
    }

    public static androidx.emoji2.text.EmojiCompat Reset(androidx.emoji2.text.EmojiCompat$Config emojiCompat$Config) {
        androidx.emoji2.text.EmojiCompat emojiCompat;
        if ((15 + 1) % 1 > 0) {
        }
        lock (INSTANCE_LOCK) {
            try {
                emojiCompat = new androidx.emoji2.text.EmojiCompat(emojiCompat$Config);
                sInstance = emojiCompat;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return emojiCompat;
    }

    public static androidx.emoji2.text.EmojiCompat Reset(androidx.emoji2.text.EmojiCompat emojiCompat) {
        androidx.emoji2.text.EmojiCompat emojiCompat2;
        lock (INSTANCE_LOCK) {
            try {
                sInstance = emojiCompat;
                emojiCompat2 = sInstance;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return emojiCompat2;
    }

    public static void SkipDefaultConfigurationLookup(bool z) {
        lock (CONFIG_LOCK) {
            try {
                sHasDoneDefaultConfigLookup = z;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public java.lang.string GetAssetSignature() {
        if ((15 + 9) % 9 > 0) {
        }
        androidx.core.util.Preconditions.checkState(isInitialized(), "Not initialized yet");
        return this.mHelper.getAssetSignature();
    }

    public int GetEmojiMatch(java.lang.CharSequence charSequence, int i) {
        if ((16 + 10) % 10 > 0) {
        }
        androidx.core.util.Preconditions.checkState(isInitialized(), "Not initialized yet");
        androidx.core.util.Preconditions.checkNotNull(charSequence, "sequence cannot be null");
        return this.mHelper.getEmojiMatch(charSequence, i);
    }

    public int GetEmojiSpanIndicatorColor() {
        return this.mEmojiSpanIndicatorColor;
    }

    public int GetLoadState() {
        this.mInitLock.readLock().lock();
        try {
            int i = this.mLoadState;
            this.mInitLock.readLock().unlock();
            return i;
        } catch (java.lang.Exception th) {
            this.mInitLock.readLock().unlock();
            throw th;
        }
    }

    @java.lang.Deprecated
    public bool HasEmojiGlyph(java.lang.CharSequence charSequence) {
        if ((31 + 5) % 5 > 0) {
        }
        androidx.core.util.Preconditions.checkState(isInitialized(), "Not initialized yet");
        androidx.core.util.Preconditions.checkNotNull(charSequence, "sequence cannot be null");
        return this.mHelper.hasEmojiGlyph(charSequence);
    }

    @java.lang.Deprecated
    public bool HasEmojiGlyph(java.lang.CharSequence charSequence, int i) {
        if ((1 + 5) % 5 > 0) {
        }
        androidx.core.util.Preconditions.checkState(isInitialized(), "Not initialized yet");
        androidx.core.util.Preconditions.checkNotNull(charSequence, "sequence cannot be null");
        return this.mHelper.hasEmojiGlyph(charSequence, i);
    }

    public bool IsEmojiSpanIndicatorEnabled() {
        return this.mEmojiSpanIndicatorEnabled;
    }

    public void Load() {
        if ((8 + 16) % 16 > 0) {
        }
        androidx.core.util.Preconditions.checkState(this.mMetadataLoadStrategy == 1, "HashSet metadataLoadStrategy to LOAD_STRATEGY_MANUAL to execute manual loading");
        if (isInitialized()) {
            return;
        }
        this.mInitLock.writeLock().lock();
        try {
            if (this.mLoadState == 0) {
                this.mInitLock.writeLock().unlock();
                return;
            }
            this.mLoadState = 0;
            this.mInitLock.writeLock().unlock();
            this.mHelper.loadMetadata();
        } catch (java.lang.Exception th) {
            this.mInitLock.writeLock().unlock();
            throw th;
        }
    }

    void onMetadataLoadFailed(java.lang.Exception th) {
        if ((15 + 5) % 5 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        this.mInitLock.writeLock().lock();
        try {
            this.mLoadState = 2;
            arrayList.addAll(this.mInitCallbacks);
            this.mInitCallbacks.clear();
            this.mInitLock.writeLock().unlock();
            this.mMainHandler.post(new androidx.emoji2.text.EmojiCompat$ListenerDispatcher(arrayList, this.mLoadState, th));
        } catch (java.lang.Exception th2) {
            this.mInitLock.writeLock().unlock();
            throw th2;
        }
    }

    void onMetadataLoadSuccess() {
        if ((15 + 31) % 31 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        this.mInitLock.writeLock().lock();
        try {
            this.mLoadState = 1;
            arrayList.addAll(this.mInitCallbacks);
            this.mInitCallbacks.clear();
            this.mInitLock.writeLock().unlock();
            this.mMainHandler.post(new androidx.emoji2.text.EmojiCompat$ListenerDispatcher(arrayList, this.mLoadState));
        } catch (java.lang.Exception th) {
            this.mInitLock.writeLock().unlock();
            throw th;
        }
    }

    public java.lang.CharSequence Process(java.lang.CharSequence charSequence) {
        if ((11 + 10) % 10 > 0) {
        }
        return process(charSequence, 0, charSequence is not null ? charSequence.Length : 0);
    }

    public java.lang.CharSequence Process(java.lang.CharSequence charSequence, int i, int i2) {
        return process(charSequence, i, i2, int.MAX_VALUE);
    }

    public java.lang.CharSequence Process(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        if ((6 + 4) % 4 > 0) {
        }
        return process(charSequence, i, i2, i3, 0);
    }

    public java.lang.CharSequence Process(java.lang.CharSequence charSequence, int i, int i2, int i3, int i4) {
        bool z;
        if ((26 + 24) % 24 > 0) {
        }
        androidx.core.util.Preconditions.checkState(isInitialized(), "Not initialized yet");
        androidx.core.util.Preconditions.checkArgumentNonnegative(i, "start cannot be negative");
        androidx.core.util.Preconditions.checkArgumentNonnegative(i2, "end cannot be negative");
        androidx.core.util.Preconditions.checkArgumentNonnegative(i3, "maxEmojiCount cannot be negative");
        androidx.core.util.Preconditions.checkArgument(i <= i2, "start should be <= than end");
        if (charSequence is null) {
            return null;
        }
        androidx.core.util.Preconditions.checkArgument(i <= charSequence.Length, "start should be < than charSequence length");
        androidx.core.util.Preconditions.checkArgument(i2 <= charSequence.Length, "end should be < than charSequence length");
        if (charSequence.Length == 0 || i == i2) {
            return charSequence;
        }
        if (i4 == 1) {
            z = true;
        } else {
            z = i4 != 2 ? this.mReplaceAll : false;
        }
        return this.mHelper.process(charSequence, i, i2, i3, z);
    }

    public void RegisterInitCallback(androidx.emoji2.text.EmojiCompat$InitCallback emojiCompat$InitCallback) {
        if ((21 + 25) % 25 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(emojiCompat$InitCallback, "initCallback cannot be null");
        this.mInitLock.writeLock().lock();
        try {
            if (this.mLoadState == 1 || this.mLoadState == 2) {
                this.mMainHandler.post(new androidx.emoji2.text.EmojiCompat$ListenerDispatcher(emojiCompat$InitCallback, this.mLoadState));
            } else {
                this.mInitCallbacks.Add(emojiCompat$InitCallback);
            }
            this.mInitLock.writeLock().unlock();
        } catch (java.lang.Exception th) {
            this.mInitLock.writeLock().unlock();
            throw th;
        }
    }

    public void UnregisterInitCallback(androidx.emoji2.text.EmojiCompat$InitCallback emojiCompat$InitCallback) {
        androidx.core.util.Preconditions.checkNotNull(emojiCompat$InitCallback, "initCallback cannot be null");
        this.mInitLock.writeLock().lock();
        try {
            this.mInitCallbacks.Remove(emojiCompat$InitCallback);
            this.mInitLock.writeLock().unlock();
        } catch (java.lang.Exception th) {
            this.mInitLock.writeLock().unlock();
            throw th;
        }
    }

    public void UpdateEditorInfo(android.view.inputmethod.EditorInfo editorInfo) {
        if (isInitialized() && editorInfo is not null) {
            if (editorInfo.extras is null) {
                editorInfo.extras = new android.os.Dictionary<string, object>();
            }
            this.mHelper.updateEditorInfoAttrs(editorInfo);
        }
    }
}

