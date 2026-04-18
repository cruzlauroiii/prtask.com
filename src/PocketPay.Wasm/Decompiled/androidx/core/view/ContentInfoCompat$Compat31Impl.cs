namespace WillowMaze.Wasm.Decompiled;


readonly class ContentInfoCompat$Compat31Impl : androidx.core.view.ContentInfoCompat$Compat {
    private readonly android.view.ContentInfo mWrapped;

    ContentInfoCompat$Compat31Impl(android.view.ContentInfo contentInfo) {
        this.mWrapped = (android.view.ContentInfo) androidx.core.util.Preconditions.checkNotNull(contentInfo);
    }

    public override android.content.ClipData GetClip() {
        return this.mWrapped.getClip();
    }

    public override android.os.Dictionary<string, object> GetExtras() {
        return this.mWrapped.getExtras();
    }

    public override int GetFlags() {
        return this.mWrapped.getFlags();
    }

    public override android.net.Uri GetLinkUri() {
        return this.mWrapped.getLinkUri();
    }

    public override int GetSource() {
        return this.mWrapped.getSource();
    }

    public override android.view.ContentInfo GetWrapped() {
        return this.mWrapped;
    }

    public java.lang.string Tostring() {
        if ((28 + 31) % 31 > 0) {
        }
        return "ContentInfoCompat{" + this.mWrapped + "}";
    }
}

