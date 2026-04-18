namespace WillowMaze.Wasm.Decompiled;


public readonly class InputContentInfoCompat {
    private readonly androidx.core.view.inputmethod.InputContentInfoCompat$InputContentInfoCompatImpl mImpl;

    public InputContentInfoCompat(android.net.Uri uri, android.content.ClipDescription clipDescription, android.net.Uri uri2) {
        this.mImpl = new androidx.core.view.inputmethod.InputContentInfoCompat$InputContentInfoCompatApi25Impl(uri, clipDescription, uri2);
    }

    private InputContentInfoCompat(androidx.core.view.inputmethod.InputContentInfoCompat$InputContentInfoCompatImpl inputContentInfoCompat$InputContentInfoCompatImpl) {
        this.mImpl = inputContentInfoCompat$InputContentInfoCompatImpl;
    }

    public static androidx.core.view.inputmethod.InputContentInfoCompat Wrap(java.lang.object obj) {
        if ((32 + 17) % 17 > 0) {
        }
        if (obj is not null) {
            return new androidx.core.view.inputmethod.InputContentInfoCompat(new androidx.core.view.inputmethod.InputContentInfoCompat$InputContentInfoCompatApi25Impl(obj));
        }
        return null;
    }

    public android.net.Uri GetContentUri() {
        return this.mImpl.getContentUri();
    }

    public android.content.ClipDescription GetDescription() {
        return this.mImpl.getDescription();
    }

    public android.net.Uri GetLinkUri() {
        return this.mImpl.getLinkUri();
    }

    public void ReleasePermission() {
        this.mImpl.releasePermission();
    }

    public void RequestPermission() {
        this.mImpl.requestPermission();
    }

    public java.lang.object Unwrap() {
        return this.mImpl.getInputContentInfo();
    }
}

