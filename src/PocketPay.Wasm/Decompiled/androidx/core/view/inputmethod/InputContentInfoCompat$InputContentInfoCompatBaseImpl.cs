namespace WillowMaze.Wasm.Decompiled;


readonly class InputContentInfoCompat$InputContentInfoCompatBaseImpl : androidx.core.view.inputmethod.InputContentInfoCompat$InputContentInfoCompatImpl {
    private readonly android.net.Uri mContentUri;
    private readonly android.content.ClipDescription mDescription;
    private readonly android.net.Uri mLinkUri;

    InputContentInfoCompat$InputContentInfoCompatBaseImpl(android.net.Uri uri, android.content.ClipDescription clipDescription, android.net.Uri uri2) {
        this.mContentUri = uri;
        this.mDescription = clipDescription;
        this.mLinkUri = uri2;
    }

    public override android.net.Uri GetContentUri() {
        return this.mContentUri;
    }

    public override android.content.ClipDescription GetDescription() {
        return this.mDescription;
    }

    public override java.lang.object GetInputContentInfo() {
        return null;
    }

    public override android.net.Uri GetLinkUri() {
        return this.mLinkUri;
    }

    public override void ReleasePermission() {
    }

    public override void RequestPermission() {
    }
}

