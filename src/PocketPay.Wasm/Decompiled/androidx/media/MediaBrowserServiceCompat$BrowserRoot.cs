namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaBrowserServiceCompat$BrowserRoot {
    public static readonly java.lang.string EXTRA_OFFLINE = "android.service.media.extra.OFFLINE";
    public static readonly java.lang.string EXTRA_RECENT = "android.service.media.extra.RECENT";
    public static readonly java.lang.string EXTRA_SUGGESTED = "android.service.media.extra.SUGGESTED";

    @java.lang.Deprecated
    public static readonly java.lang.string EXTRA_SUGGESTION_KEYWORDS = "android.service.media.extra.SUGGESTION_KEYWORDS";
    private readonly android.os.Dictionary<string, object> mExtras;
    private readonly java.lang.string mRootId;

    public MediaBrowserServiceCompat$BrowserRoot(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if (str is null) {
            throw new java.lang.IllegalArgumentException("The root id in BrowserRoot cannot be null. Use null for BrowserRoot instead.");
        }
        this.mRootId = str;
        this.mExtras = bundle;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public java.lang.string GetRootId() {
        return this.mRootId;
    }
}

