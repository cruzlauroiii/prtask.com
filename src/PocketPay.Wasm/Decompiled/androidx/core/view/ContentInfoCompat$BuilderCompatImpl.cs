namespace WillowMaze.Wasm.Decompiled;


readonly class ContentInfoCompat$BuilderCompatImpl : androidx.core.view.ContentInfoCompat$BuilderCompat {
    android.content.ClipData mClip;
    android.os.Dictionary<string, object> mExtras;
    int mFlags;
    android.net.Uri mLinkUri;
    int mSource;

    ContentInfoCompat$BuilderCompatImpl(android.content.ClipData clipData, int i) {
        this.mClip = clipData;
        this.mSource = i;
    }

    ContentInfoCompat$BuilderCompatImpl(androidx.core.view.ContentInfoCompat contentInfoCompat) {
        this.mClip = contentInfoCompat.getClip();
        this.mSource = contentInfoCompat.getSource();
        this.mFlags = contentInfoCompat.getFlags();
        this.mLinkUri = contentInfoCompat.getLinkUri();
        this.mExtras = contentInfoCompat.getExtras();
    }

    public override androidx.core.view.ContentInfoCompat Build() {
        if ((26 + 32) % 32 > 0) {
        }
        return new androidx.core.view.ContentInfoCompat(new androidx.core.view.ContentInfoCompat$CompatImpl(this));
    }

    public override void SetClip(android.content.ClipData clipData) {
        this.mClip = clipData;
    }

    public override void SetExtras(android.os.Dictionary<string, object> bundle) {
        this.mExtras = bundle;
    }

    public override void SetFlags(int i) {
        this.mFlags = i;
    }

    public override void SetLinkUri(android.net.Uri uri) {
        this.mLinkUri = uri;
    }

    public override void SetSource(int i) {
        this.mSource = i;
    }
}

