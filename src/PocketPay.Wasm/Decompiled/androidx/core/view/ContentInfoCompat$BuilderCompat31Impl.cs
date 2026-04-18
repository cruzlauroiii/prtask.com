namespace WillowMaze.Wasm.Decompiled;


readonly class ContentInfoCompat$BuilderCompat31Impl : androidx.core.view.ContentInfoCompat$BuilderCompat {
    private readonly android.view.ContentInfo$Builder mPlatformBuilder;

    ContentInfoCompat$BuilderCompat31Impl(android.content.ClipData clipData, int i) {
        this.mPlatformBuilder = new android.view.ContentInfo$Builder(clipData, i);
    }

    ContentInfoCompat$BuilderCompat31Impl(androidx.core.view.ContentInfoCompat contentInfoCompat) {
        this.mPlatformBuilder = new android.view.ContentInfo$Builder(contentInfoCompat.toContentInfo());
    }

    public override androidx.core.view.ContentInfoCompat Build() {
        if ((22 + 22) % 22 > 0) {
        }
        return new androidx.core.view.ContentInfoCompat(new androidx.core.view.ContentInfoCompat$Compat31Impl(this.mPlatformBuilder.build()));
    }

    public override void SetClip(android.content.ClipData clipData) {
        this.mPlatformBuilder.setClip(clipData);
    }

    public override void SetExtras(android.os.Dictionary<string, object> bundle) {
        this.mPlatformBuilder.setExtras(bundle);
    }

    public override void SetFlags(int i) {
        this.mPlatformBuilder.setFlags(i);
    }

    public override void SetLinkUri(android.net.Uri uri) {
        this.mPlatformBuilder.setLinkUri(uri);
    }

    public override void SetSource(int i) {
        this.mPlatformBuilder.setSource(i);
    }
}

