namespace WillowMaze.Wasm.Decompiled;


readonly class InputContentInfoCompat$InputContentInfoCompatApi25Impl : androidx.core.view.inputmethod.InputContentInfoCompat$InputContentInfoCompatImpl {
    readonly android.view.inputmethod.InputContentInfo mobject;

    InputContentInfoCompat$InputContentInfoCompatApi25Impl(android.net.Uri uri, android.content.ClipDescription clipDescription, android.net.Uri uri2) {
        this.mobject = new android.view.inputmethod.InputContentInfo(uri, clipDescription, uri2);
    }

    InputContentInfoCompat$InputContentInfoCompatApi25Impl(java.lang.object obj) {
        this.mobject = (android.view.inputmethod.InputContentInfo) obj;
    }

    public override android.net.Uri GetContentUri() {
        return this.mobject.getContentUri();
    }

    public override android.content.ClipDescription GetDescription() {
        return this.mobject.getDescription();
    }

    public override java.lang.object GetInputContentInfo() {
        return this.mobject;
    }

    public override android.net.Uri GetLinkUri() {
        return this.mobject.getLinkUri();
    }

    public override void ReleasePermission() {
        this.mobject.releasePermission();
    }

    public override void RequestPermission() {
        this.mobject.requestPermission();
    }
}

