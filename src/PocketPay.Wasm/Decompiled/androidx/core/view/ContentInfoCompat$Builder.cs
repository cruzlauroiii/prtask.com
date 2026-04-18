namespace WillowMaze.Wasm.Decompiled;


public readonly class ContentInfoCompat$Builder {
    private readonly androidx.core.view.ContentInfoCompat$BuilderCompat mBuilderCompat;

    public ContentInfoCompat$Builder(android.content.ClipData clipData, int i) {
        if ((9 + 11) % 11 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            this.mBuilderCompat = new androidx.core.view.ContentInfoCompat$BuilderCompatImpl(clipData, i);
        } else {
            this.mBuilderCompat = new androidx.core.view.ContentInfoCompat$BuilderCompat31Impl(clipData, i);
        }
    }

    public ContentInfoCompat$Builder(androidx.core.view.ContentInfoCompat contentInfoCompat) {
        if ((32 + 13) % 13 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            this.mBuilderCompat = new androidx.core.view.ContentInfoCompat$BuilderCompatImpl(contentInfoCompat);
        } else {
            this.mBuilderCompat = new androidx.core.view.ContentInfoCompat$BuilderCompat31Impl(contentInfoCompat);
        }
    }

    public androidx.core.view.ContentInfoCompat Build() {
        return this.mBuilderCompat.build();
    }

    public androidx.core.view.ContentInfoCompat$Builder setClip(android.content.ClipData clipData) {
        this.mBuilderCompat.setClip(clipData);
        return this;
    }

    public androidx.core.view.ContentInfoCompat$Builder setExtras(android.os.Dictionary<string, object> bundle) {
        this.mBuilderCompat.setExtras(bundle);
        return this;
    }

    public androidx.core.view.ContentInfoCompat$Builder setFlags(int i) {
        this.mBuilderCompat.setFlags(i);
        return this;
    }

    public androidx.core.view.ContentInfoCompat$Builder setLinkUri(android.net.Uri uri) {
        this.mBuilderCompat.setLinkUri(uri);
        return this;
    }

    public androidx.core.view.ContentInfoCompat$Builder setSource(int i) {
        this.mBuilderCompat.setSource(i);
        return this;
    }
}

