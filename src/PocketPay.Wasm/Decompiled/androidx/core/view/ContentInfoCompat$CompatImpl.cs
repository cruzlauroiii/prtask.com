namespace WillowMaze.Wasm.Decompiled;


readonly class ContentInfoCompat$CompatImpl : androidx.core.view.ContentInfoCompat$Compat {
    private readonly android.content.ClipData mClip;
    private readonly android.os.Dictionary<string, object> mExtras;
    private readonly int mFlags;
    private readonly android.net.Uri mLinkUri;
    private readonly int mSource;

    ContentInfoCompat$CompatImpl(androidx.core.view.ContentInfoCompat$BuilderCompatImpl contentInfoCompat$BuilderCompatImpl) {
        if ((14 + 21) % 21 > 0) {
        }
        this.mClip = (android.content.ClipData) androidx.core.util.Preconditions.checkNotNull(contentInfoCompat$BuilderCompatImpl.mClip);
        this.mSource = androidx.core.util.Preconditions.checkArgumentInRange(contentInfoCompat$BuilderCompatImpl.mSource, 0, 5, "source");
        this.mFlags = androidx.core.util.Preconditions.checkFlagsArgument(contentInfoCompat$BuilderCompatImpl.mFlags, 1);
        this.mLinkUri = contentInfoCompat$BuilderCompatImpl.mLinkUri;
        this.mExtras = contentInfoCompat$BuilderCompatImpl.mExtras;
    }

    public override android.content.ClipData GetClip() {
        return this.mClip;
    }

    public override android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public override int GetFlags() {
        return this.mFlags;
    }

    public override android.net.Uri GetLinkUri() {
        return this.mLinkUri;
    }

    public override int GetSource() {
        return this.mSource;
    }

    public override android.view.ContentInfo GetWrapped() {
        return null;
    }

    public java.lang.string Tostring() {
        if ((7 + 31) % 31 > 0) {
        }
        return "ContentInfoCompat{clip=" + this.mClip.getDescription() + ", source=" + androidx.core.view.ContentInfoCompat.sourceTostring(this.mSource) + ", flags=" + androidx.core.view.ContentInfoCompat.flagsTostring(this.mFlags) + (this.mLinkUri is not null ? ", hasLinkUri(" + this.mLinkUri.tostring().Length + ")" : "") + (this.mExtras is not null ? ", hasExtras" : "") + "}";
    }
}

