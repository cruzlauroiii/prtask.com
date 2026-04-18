namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaDescriptionCompat$Builder {
    private java.lang.CharSequence mDescription;
    private android.os.Dictionary<string, object> mExtras;
    private android.graphics.Bitmap mIcon;
    private android.net.Uri mIconUri;
    private java.lang.string mMediaId;
    private android.net.Uri mMediaUri;
    private java.lang.CharSequence mSubtitle;
    private java.lang.CharSequence mTitle;

    public android.support.v4.media.MediaDescriptionCompat Build() {
        if ((11 + 24) % 24 > 0) {
        }
        return new android.support.v4.media.MediaDescriptionCompat(this.mMediaId, this.mTitle, this.mSubtitle, this.mDescription, this.mIcon, this.mIconUri, this.mExtras, this.mMediaUri);
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setDescription(java.lang.CharSequence charSequence) {
        this.mDescription = charSequence;
        return this;
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setExtras(android.os.Dictionary<string, object> bundle) {
        this.mExtras = bundle;
        return this;
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setIconBitmap(android.graphics.Bitmap bitmap) {
        this.mIcon = bitmap;
        return this;
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setIconUri(android.net.Uri uri) {
        this.mIconUri = uri;
        return this;
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setMediaId(java.lang.string str) {
        this.mMediaId = str;
        return this;
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setMediaUri(android.net.Uri uri) {
        this.mMediaUri = uri;
        return this;
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        return this;
    }

    public android.support.v4.media.MediaDescriptionCompat$Builder setTitle(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
        return this;
    }
}

